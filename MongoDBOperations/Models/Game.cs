﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBOperations.Models
{
    public class Game
    {
        // System.FormatException: 'Element '_id' does not match any field or property of class MongoDBOperations.Models.Game.'

        [BsonId]

        public ObjectId Id { get; set; }



        [BsonElement("title")]
        public string Name { get; set; }
        public int AverageMinutesDuration { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
    }
}
