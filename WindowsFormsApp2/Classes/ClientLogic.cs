using MagacinskoRobnoMaterijalno.Models;
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
        private MainRepository _mainRepository;
        public ClientLogic()
        {
            _mainRepository = new MainRepository();
        }

        public BindingList<Client> GetAllClients()
        {
            return _mainRepository.GetClients();
        }

        public void AddClient(Client client)
        {
            _mainRepository.AddClient(client);
        }

        public void EditClient(Client client)
        {
            _mainRepository.EditClient(client);
        }

        public bool SaveAllChanges()
        {
            return _mainRepository.SaveChanges();
        }

        public Client GetClientByClientPIB(string PIB)
        {
            return _mainRepository.GetClientByClientPIB(PIB);
        }

        public void DeleteClient(Client itemForDelete)
        {
            _mainRepository.DeleteClient(itemForDelete);
        }

        public List<Client> GetClientByName(string name)
        {
           return _mainRepository.GetClientByName(name);
        }
    }
}
