using System.Collections.Generic;

namespace MyTMS.Domain.Persistance.Partner.Interface
{
    public interface IPartnerRepository
    {
        List<Entities.Partner> SearchByName();
    }
}
