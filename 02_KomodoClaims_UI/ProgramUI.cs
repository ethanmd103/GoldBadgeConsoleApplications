using _02_KomodoClaims_Repository;
using System;
using System.Collections.Generic;

namespace _02_KomodoClaims_UI
{
    public class ProgramUI
    {
        private readonly ClaimsRepo _claimsRepo = new ClaimsRepo();
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter a menu option: \n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n");

                String Input = Console.ReadLine();
                switch (Input)
                {
                    case "1":
                        GetClaims();
                        break;
                    case "2":
                        HandleClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                }
            }
        }


        private void GetClaims()
        {
            Console.Clear(); Queue<Claim> claims = new Queue<Claim>();
            foreach (var Claim in claims)
            {
                Console.WriteLine($"{Claim.ClaimID} {Claim.ClaimType} {Claim.Description} {Claim.ClaimAmount} {Claim.DateOfIncident} {Claim.DateOfClaim} {Claim.IsValid}");
            }
            Console.ReadKey();
        }

        private void HandleClaim()
        {
            Console.Clear();
            Console.WriteLine("Here are the details for the next claim to be handled: ");
            var claims = _claimsRepo.GetClaims();
            Console.WriteLine("Do you want to deal with this claim now(y/n)?");
            if (claims == null)
                Console.WriteLine("No claim to be handled!");
            Console.ReadKey();
        }
        private void EnterNewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();
            
            Console.WriteLine("Enter the claim ID: \n");
            newClaim.ClaimID = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the claim type: \n" +
                "1. Car \n" +
                "2. House \n" +
                "3. Theft \n");
            string claimType = Console.ReadLine();
            
            Console.WriteLine("Enter a description of the claim: ");
            string claimDescription = Console.ReadLine();
            Claim.Description = claimDescription;

            Console.WriteLine("Enter a damage amount: ");
            string claimAmount = Console.WriteLine();
            

           
            





           

            









        }
        private void Seed()
        {
            Claim claim1 = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);
            Claim claim2 = new Claim(2, ClaimType.Home, "House fire in kitchen", 4000.00d, new DateTime(2018, 04, 11), new DateTime(2018, 12, 18), true);
            Claim claim3 = new Claim(3, ClaimType.Theft, "Stolen pancakes!", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 18), false);

            //Need to add these claims to repository later for this to work 

        }

        
    }
    



}
