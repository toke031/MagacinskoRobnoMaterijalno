using MagacinskoRobnoMaterijalno.Data.Model;
using MagacinskoRobnoMaterijalno.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class ClientLogic
    {
        public ClientLogic()
        {
        }

        public BindingList<Client> GetAllClients()
        {
            using(UOW uow = new UOW())
            {
                var clients = uow.ClientRepository.Find().ToList();
                BindingList<Client> bindingListClients = new BindingList<Client>(clients);
                return bindingListClients;
            }
        }

        public int AddClient(Client client)
        {
            using (UOW uow = new UOW())
            {
                uow.ClientRepository.Insert(client);
                return uow.Save();
            }
        }

        public int EditClient(Client client)
        {
            using (UOW uow = new UOW())
            {
                uow.ClientRepository.Update(client);
                return uow.Save();
            }
        }

        public Client GetClientByClientPIB(string PIB)
        {
            using (UOW uow = new UOW())
            {
                return uow.ClientRepository.Find(x => x.PIB == PIB).FirstOrDefault();
            }
        }

        public void DeleteClient(Client itemForDelete)
        {
            using (UOW uow = new UOW())
            {
                uow.ClientRepository.Delete(itemForDelete);
                uow.Save();
            }
        }

        public List<Client> GetClientByName(string name)
        {
            using (UOW uow = new UOW())
            {
                return uow.ClientRepository.Find(x => x.Name.Contains(name)).ToList();
            }
        }
    }
}
