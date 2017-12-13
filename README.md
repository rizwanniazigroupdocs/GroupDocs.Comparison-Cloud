# GroupDocs.Comparison for Cloud SDKs
This folder contains SDKs for [GroupDocs.Comparison for Cloud](https://products.groupdocs.cloud/comparison/cloud) for various platforms.

# Currently Available SDKs

Directory | Description
--------- | -----------
[.NET SDK](SDKs/NET) | GroupDocs.Comparison for Cloud .NET SDK

To use these SDKs, you will need App SID and App Key which can be looked up at [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) (free registration in GroupDocs Cloud is required for this).

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };
            
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var categoriesType = categoriesType_example;  // string | Type of the categories. (optional) 

            try
            {
                // Posts the categories changes.
                List<ComparisonChangesCategoryDto> result = apiInstance.PostCategoriesChanges(request, categoriesType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PostCategoriesChanges: " + e.Message );
            }

        }
    }
}
```
# Licensing
All GroupDocs.Comparison for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/comparison/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/comparisoncloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/comparison)
+ [**Paid Support Helpdesk**](https://helpdesk.groupdocs.cloud)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-products/groupdocs-comparison-product-family)