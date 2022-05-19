using System;
using System.Collections.Generic;

// To interact with AWS DynamoDB
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

// Create client
var client = new AmazonDynamoDBClient();
var fruitTable = Table.LoadTable(client, "fruit");

// Display Prompt
Console.WriteLine("Table Scan " + Environment.NewLine);

// Scan
ScanFilter scanFilter = new ScanFilter();
Search search = fruitTable.Scan(scanFilter);

//All Fruit
var fruitList = new List<string> ();

//Print
do
{
    var documentList = await search.GetNextSetAsync();

    foreach (Document document in documentList)
    {
        var fruit = document.First().Value;
        Console.WriteLine($"Fruit: {fruit}");
        fruitList.Add(fruit);   //Add scanned fruit to list
    }
} while (!search.IsDone);

//Now pick a random fruit
var random = new Random();
int index = random.Next(fruitList.Count);
Console.WriteLine($"Random Fruit: {fruitList[index]}");