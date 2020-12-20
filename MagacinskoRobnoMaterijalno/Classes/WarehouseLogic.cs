using MagacinskoRobnoMaterijalno.Data.UnitOfWork;
using MagacinskoRobnoMaterijalno.Data.Model;
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
        public WarehouseLogic()
        {
        }

        internal BindingList<Warehouse> GetAllWarehouseForTypeID(int typeID)
        {
            using (UOW uow = new UOW())
            {
                var warehouses = uow.WarehouseRepository.Find(x => x.WarehouseTypeID == typeID).ToList();
                BindingList<Warehouse> bindingListWarehouses = new BindingList<Warehouse>(warehouses);
                return bindingListWarehouses;

            }
        }

        internal BindingList<Warehouse> GetAllWarehouse()
        {
            using(UOW uow = new UOW())
            {
                var warehouses = uow.WarehouseRepository.Find().ToList();
                BindingList<Warehouse> bindingListWarehouses = new BindingList<Warehouse>(warehouses);
                return bindingListWarehouses;
            }
        }
    }
}
