using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTempConversion
{
    class Dao
    {
        public static IMongoCollection<Conversion> ConnecterBd()
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:1701");
            var database = mongoClient.GetDatabase("dbTemp");
            var collection = database.GetCollection<Conversion>("appels");
            return collection;
        }

        public static void InsertAppel(Conversion conversion)
        {
            IMongoCollection<Conversion> collection = ConnecterBd();
            collection.InsertOne(conversion);
        }

        public static List<Conversion> GetAppel()
        {
            IMongoCollection<Conversion> collection = ConnecterBd();
            var liste = collection.Find(new BsonDocument()).ToList();
            return liste;
        }
    }
}
