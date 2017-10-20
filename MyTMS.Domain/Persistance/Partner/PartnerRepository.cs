using MyTMS.Domain.Persistance.Partner.Interface;
using System;
using System.Collections.Generic;

namespace MyTMS.Domain.Persistance.Partner
{
    public class PartnerRepository : IPartnerRepository
    {
        public List<Entities.Partner> SearchByName()
        {
            throw new NotImplementedException();
        }
    }
}
