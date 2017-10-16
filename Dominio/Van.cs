using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Van
    {
        private int capacity;
        private string name;
        private int idVan;
        private bool available;
        public Van()
        {
            capacity = -1;
            name = "";
            idVan = -1;
            available = false;
        }
        public void EditVanName(string NewName)
        {
            name=NewName;
        }
        public void EditVanCapacity(int NewCapacity)
        {
            capacity = NewCapacity;
        }
        public void EditVanId(int NewId)
        {
            idVan = NewId;
        }
        public void EditVanAvailability(bool NewAvailable)
        {
            available = NewAvailable;
        }
        public bool GetAvailability()
        {
            return available;
        }
        public int GetCapacity()
        {
            return capacity;
        }
        public int GetId()
        {
            return idVan;
        }
        public string GetName()
        {
            return name;
        }
        public override string ToString()
        {
            return name + " " + idVan + " " + capacity;
        }
        public void DeleteVan()
        {
            
        }
        public void CalcularRuta()
        {

        }
    }
}
