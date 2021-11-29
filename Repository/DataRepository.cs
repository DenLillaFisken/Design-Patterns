using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepository : IDataRepository
    {
        public string GetAnimal()
        {
            var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve");
            return animal;
        }

        public string GetCustomer()
        {
            var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve");
            return customer;
        }

        public string GetData()
        {
            string data = SimulatedDatabase.Load("Dataset A");
            return data;
        }

        public void SaveData(string data)
        {
            SimulatedDatabase.Save(data);
        }
    }
}
