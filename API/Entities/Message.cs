using System;

namespace API.Entities;
    
    public class Message
    {
        public string Id {get; set;} = Guid.NewGuid().ToString();
        public required string Text {get; set;}
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public required string RoomUserId { get; set; }
         public RoomUser? RoomUser { get; set; }
    }

