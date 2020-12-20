using AutoMapper;
using MagacinskoRobnoMaterijalno.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno
{
    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {
            CreateMap<Document, Models.DocumentModel>().ReverseMap();
        }
    }
}
