## AWS S3 Console App

Example based on converting [this tutorial](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/quick-start-s3-1-winvs.html)

![images](https://user-images.githubusercontent.com/58792/147970576-b72abb2f-61ea-48ec-8dd2-fed582e1fbb1.png)


* Create new Console App project targeting .NET 6
* Install  AWSSDK.S3 With the newly created project loaded, choose Tools, NuGet Package Manager, Manage NuGet Packages for Solution.
* Paste the following code

```csharp
using System;
using System.Threading.Tasks;

// To interact with Amazon S3.
using Amazon.S3;
using Amazon.S3.Model;

// Create an S3 client object.
var s3Client = new AmazonS3Client();

// Display Prompt
Console.WriteLine("AWS Bucket Lister" + Environment.NewLine);

// Process API Calls Async List AWS Buckets
var listResponse = await MyListBucketsAsync(s3Client);
Console.WriteLine($"Number of buckets: {listResponse.Buckets.Count}");

// Loop through the AWS buckets
foreach (S3Bucket b in listResponse.Buckets)
{
    Console.WriteLine(b.BucketName);
}

static async Task<ListBucketsResponse> MyListBucketsAsync(IAmazonS3 s3Client)
{
    return await s3Client.ListBucketsAsync();
}
```
