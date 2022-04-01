using System;
using System.Collections.Generic;

namespace Homework1.SOLID.Models.DependencyInversion.Bad
{
    public class Bad
    {
        public void Run()
        {
            List<string> data = new Repository().GetAllData();

            Console.WriteLine(String.Join(",", data));
        }
    }

    public class DataAccesLayer
    {
        public List<string> GetAll()
        {
            return new List<string>() { "data1", "data2" };
        }
    }

    public class Repository
    {
        public DataAccesLayer _db { get; set; }

        public Repository()
        {
            _db = new DataAccesLayer();
        }

        public List<string> GetAllData()
        {
            return _db.GetAll();
        }
    }
}
