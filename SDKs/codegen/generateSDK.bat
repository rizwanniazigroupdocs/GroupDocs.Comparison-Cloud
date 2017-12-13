cd ../..
del /S /Q "c:\tmp\csharp"
java -jar SDKs\codegen\swagger-codegen-cli-2.3.0.jar generate -i SDKs\spec\groupdocsforcloud_comparison_csharp.json -l csharp -t SDKs\codegen\Templates\csharp -o c:/tmp/csharp/ -c SDKs\codegen\config.json

SDKs\codegen\Tools\SplitCSharpCodeFile.exe C:\tmp\csharp\src\GroupDocs.Comparison.Cloud.Sdk\Api\ComparisonApi.cs C:\tmp\csharp\src\GroupDocs.Comparison.Cloud.Sdk\Model\Requests\

del /S /Q "SDKs\NET\GroupDocs.Comparison.Cloud.Sdk\Model"
del /S /Q "SDKs\NET\GroupDocs.Comparison.Cloud.Sdk\Api\WordsApi.cs"

xcopy "c:\tmp\csharp\src\GroupDocs.Comparison.Cloud.Sdk\Model" "SDKs\NET\GroupDocs.Comparison.Cloud.Sdk\Model" /E
xcopy "c:\tmp\csharp\src\GroupDocs.Comparison.Cloud.Sdk\Api" "SDKs\NET\GroupDocs.Comparison.Cloud.Sdk\Api" /E




