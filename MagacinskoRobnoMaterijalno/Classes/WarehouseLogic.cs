using MagacinskoRobnoMaterijalno.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class WarehouseLogic
    {
        private MainRepository _mainRepository;
        public WarehouseLogic()
        {
            _mainRepository = new MainRepository();
        }

        internal BindingList<Warehouse> GetAllWarehouseForTypeID(int typeID)
        {
            return _mainRepository.GetWarehouseByTypeID(typeID);
        }

        internal BindingList<Warehouse> GetAllWarehouse()
        {
            return _mainRepository.GetAllWarehouse();
        }
    }
}
