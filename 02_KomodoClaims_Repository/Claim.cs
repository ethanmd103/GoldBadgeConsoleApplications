using System;

namespace _02_KomodoClaims_Repository
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft,
    }
    public class Claim
    {
        public int ClaimID { get; set; }

        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }

        // Open get and set, make set automatically calculate based on 
        public bool IsValid { get; set; }
        public ClaimType ClaimType { get; set; }

        public Claim() { }
        public Claim(int claimID, ClaimType claimtype, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            ClaimType = claimtype;

        }

    }
}
