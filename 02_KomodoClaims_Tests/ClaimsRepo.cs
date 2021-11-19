using System;
using System.Collections.Generic;

namespace _02_KomodoClaims_Repository
{
    public class ClaimsRepo
    {
        protected readonly Queue<Claim> _claimRepo = new Queue<Claim>();

        public bool EnterNewClaim(Claim claim)
        {
            if (claim == null)
            {
                return false;

            }

            _claimRepo.Enqueue(claim);
            return true;

        }
        public Queue<Claim> GetClaims()
        {
            return _claimRepo;
        }

        public Claim NextInLine()
        {
            var claim = _claimRepo.Peek();
            return claim;

        }

        public bool HandleClaim()
        {
            if (_claimRepo.Count > 0)
            {
                _claimRepo.Dequeue();
                return true;
            }
            return false;



        }
        public bool IsValidClaim(DateTime DateOfAccident, DateTime DateOfClaim)
        {
            TimeSpan span = DateOfClaim - DateOfAccident;
            if (span.Days < 30)
                return true;
            return false;
        }
    }
}
