using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;

namespace AWSConsole
{
    internal class Program
    {
        public static AmazonDynamoDBClient Client { get; set; }
        public static Table Table { get; set; }

        public static void Main(string[] args)
        {
            ConfigClient();

            //CreateTable("Employees");

            Table = Table.LoadTable(Client, "Employees");

            AddEmployee(1, "John", "Doe");
            
            AddEmployee(1, "Jane", "Doe");//Update Item

            ReadEmployee(1);

            RemoveEmployee(1)

            Console.Read();
        }

        public static void ConfigClient()
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig
            {
                ServiceURL = "http://localhost:8001"
            };

            Client = new AmazonDynamoDBClient(clientConfig);
        }

        public static void CreateTable(string tableName)
        {
            var request = new CreateTableRequest
            {
                TableName = tableName,
                AttributeDefinitions = new List<AttributeDefinition>()
                {
                    new AttributeDefinition
                    {
                      AttributeName = "EmployeeID",
                      AttributeType = "N"
                    }
                },
                KeySchema = new List<KeySchemaElement>()
                {
                    new KeySchemaElement
                    {
                      AttributeName = "EmployeeID",
                      KeyType = "HASH"  //Partition key
                    }
                },
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5
                }
            };

            var response = Client.CreateTable(request);
        }

        public static void AddEmployee(int Id, string Name, string LastName)
        {
            var employee = new Document
            {
                ["EmployeeID"] = Id,
                ["Name"] = Name,
                ["LastName"] = LastName
            };

            Table.PutItem(employee);
        }

        public static void RemoveEmployee(int Id)
        {
            var employee = Table.GetItem(Id);
            Table.DeleteItem(employee);
        }

        public static void ReadEmployee(int Id)
        {
            var employee = Table.GetItem(Id);
            Console.WriteLine($"ID: {employee["EmployeeID"]}");
            Console.WriteLine($"Name: {employee["Name"]}");
            Console.WriteLine($"LastName: {employee["LastName"]}");
        }
    }
}