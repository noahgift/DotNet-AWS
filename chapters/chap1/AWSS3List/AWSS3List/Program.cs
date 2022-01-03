using System;
using System.Threading.Tasks;

// To interact with AWS S3
using Amazon.S3;
using Amazon.S3.Model;

// Create s3 client
var s3Client = new AmazonS3Client();

// Display Prompt
Console.WriteLine("AWS S3 Bucket Lister " + Environment.NewLine);

// Process API Calls Async List AWS Buckets
var listResponse = await MyListBucketsAsync(s3Client);
Console.WriteLine($"Number of buckets: {listResponse.Buckets.Count}");

// Loop through the AWS buckets
foreach (S3Bucket b in listResponse.Buckets)
{
    Console.WriteLine($"BucketName: {b.BucketName}");
}


static async Task<ListBucketsResponse> MyListBucketsAsync(IAmazonS3 s3Client)
{
    return await s3Client.ListBucketsAsync();
}