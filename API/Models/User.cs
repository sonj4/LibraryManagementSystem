﻿namespace API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ProfileImageURL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? LibraryId { get; set; }
        public Library? Library { get; set; }
        public ICollection<Membership>? Memberships { get; set; }
    }
}
