using MediatR;
using MyTMS.Domain.Dto;
using MyTMS.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace MyTMS.Api.Models.Project
{
    public class PartnerQueryHandler : IRequestHandler<PartnerQuery, List<PartnerDto>>
    {
        private IPartnerService _partnerService;

        public PartnerQueryHandler(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        public List<PartnerDto> Handle(PartnerQuery query)
        {
            return _partnerService.SearchByName(query.SearchName);
        }
    }
}
