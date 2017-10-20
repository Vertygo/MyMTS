using System.Collections.Generic;
using MyTMS.Domain.Dto;
using MyTMS.Domain.Entities;
using MyTMS.Domain.Interfaces.Service;
using System;
using MyTMS.Domain.Persistance.Partner.Interface;

namespace MyTMS.Domain.Services
{
    public class PartnerService : IPartnerService
    {
        private IPartnerRepository _repository;

        public PartnerService(IPartnerRepository repository)
        {
            _repository = repository;
        }

        public void GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Partner partner)
        {
            throw new System.NotImplementedException();
        }

        public List<PartnerDto> SearchByName(string searchName)
        {
            //repository.
            throw new NotImplementedException();
        }
    }
}
