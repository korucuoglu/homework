using System;
using System.Collections.Generic;

namespace Homework1.SOLID.Models.DependencyInversion.Good
{
    public class Good
    {
        public void Run()
        {
            List<string> data = new Repository(new DataAccesLayer()).GetAllData();

            Console.WriteLine(String.Join(",", data));
        }
    }

    public class DataAccesLayer: IDataAccesLayer
    {
        public List<string> GetAll()
        {
            return new List<string>() { "data1", "data2" };
        }
    }

    public interface IDataAccesLayer
    {
        List<string> GetAll();
    }

    public class Repository
    {
        public IDataAccesLayer _db { get; set; }

        public Repository(IDataAccesLayer db)
        {
            _db = db;
        }

        public List<string> GetAllData()
        {
            return _db.GetAll();
        }
    }
}
