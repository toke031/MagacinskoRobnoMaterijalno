using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class DocumentRepository
    {
        MainDBContext _context;

        public DocumentRepository()
        {
            _context = new MainDBContext();
        }
    }
}
