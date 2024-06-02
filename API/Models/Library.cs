﻿namespace API.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address  { get; set; }
        public ICollection<User> Members { get; } = new List<User>();
    }
}
