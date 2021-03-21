using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MeetingPlannerAPI.Models
{
    public class MeetingProgram
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Date { get; set; }
        public string Conductor { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string SpecialSong { get; set; }
        public string ClosingSong { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
