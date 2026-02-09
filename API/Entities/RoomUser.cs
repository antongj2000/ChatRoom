using System;

namespace API.Entities;

    public class RoomUser
    {

        public string Id {get; set;} = Guid.NewGuid().ToString();

        
        public required string screenName {get; set;}
        public required string email {get; set;}
        public required string phoneNo{get; set;}
        public required string address{get; set;}

        public ICollection<Message>Messages { get; set; } = new List<Message>();


    }

