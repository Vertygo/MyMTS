using MyTMS.Domain.Dto;
using MyTMS.Domain.Entities;
using System.Collections.Generic;

namespace MyTMS.Domain.Interfaces.Service
{
    public interface IPartnerService
    {
        void GetById(long id);
        void Save(Partner partner);
        List<PartnerDto> SearchByName(string searchName);
    }
}
