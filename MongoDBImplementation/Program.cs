
using MongoDB.Bson;
using MongoDB.Driver;

//Define the mongoDb connection string and database name
string connectionString = "mongodb://localhost:27017/";
string databaseName = "EDUDB";

//Create a MongoClient to connect to the mongo server
MongoClient client = new MongoClient(connectionString);

//Access the database
IMongoDatabase database =  client.GetDatabase(databaseName);

Console.WriteLine("Connected to Database");

var collection = database.GetCollection<BsonDocument>("EDUDBCollection");
var document = new BsonDocument
{
    {"name", "Peter" },
    {"age", 32 },
    {"salary", 25000 }
};

collection.InsertOne(document);
Console.WriteLine("Record Added to Database");

//var filter = Builders<BsonDocument>.Filter