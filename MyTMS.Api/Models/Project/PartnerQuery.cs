using MediatR;
using MyTMS.Domain.Dto;
using System.Collections.Generic;

namespace MyTMS.Api.Models.Project
{
    public class PartnerQuery : IRequest<List<PartnerDto>>
    {
        public string SearchName { get; set; }
    }

}
