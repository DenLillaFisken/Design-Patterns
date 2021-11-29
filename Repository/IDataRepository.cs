using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public interface IDataRepository
    {
        public void SaveData(string data);

        public  string GetData();
        public string GetCustomer();
        public string GetAnimal();
    }
}
