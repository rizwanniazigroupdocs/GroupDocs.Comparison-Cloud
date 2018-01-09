using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using NUnit.Framework;
using Configuration = GroupDocs.Comparison.Cloud.Sdk.Api.Configuration;

namespace GroupDocs.Comparison.Cloud.Sdk.Test
{
    public class TestsSetup
    {
        private readonly string _appSid = ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        protected ComparisonApi ComparisonApi;
        protected ChangesApi ChangesApi;
        protected StorageApi StorageApi;

        public TestsSetup()
        {
            var comparisonConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            ComparisonApi = new ComparisonApi(comparisonConfig);
            ChangesApi = new ChangesApi(comparisonConfig);

            var storageConfig = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };

            StorageApi = new StorageApi(storageConfig);
        }

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            UploadTestFiles();
        }

        private void UploadTestFiles()
        {
            var path = GetTestDataPath();

            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = StorageApi.IsExist(relativeDirPath);
                if (!response.FileExist.IsExist)
                    StorageApi.CreateFolder(relativeDirPath);
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = StorageApi.IsExist(relativeFilePath);
                if (!response.FileExist.IsExist)
                {
                    var fileName = Path.GetFileName(file);
                    var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
                    var bytes = File.ReadAllBytes(file);

                    StorageApi.CreateFile(fileName, relativeDirPath, bytes);
                }
            }
        }

        private string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath);
            if (workingDir == null)
                workingDir = Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "..\\..\\..\\..\\..", "TestData");

            return Path.GetFullPath(baseDir);
        }

        [TearDown]
        public void AfterEachTest()
        {
            RemoveTempFiles();
        }

        private void RemoveTempFiles()
        {
            StorageApi.DeleteFolder("cache");
            StorageApi.DeleteFolder("tests");
        }
    }
}