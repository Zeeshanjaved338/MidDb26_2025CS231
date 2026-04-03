using System;

namespace MidDb_2025CS231.Models
{
    public class Advisor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Designation { get; set; }
        public decimal Salary { get; set; }
        public int Gender { get; set; }
    }
}