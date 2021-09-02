using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataAccessLayer.Repositories
{
    public abstract class AbstractRepository
    {
        public abstract void AddRecord(Student st); //Abstract

        public void Print() // Non Abstract
        {
            Console.WriteLine("Printing a document.....");
        }
    }
    public class HR : AbstractRepository
    {
        public HR()
        {
        }

        public override void AddRecord(Student st)
        {
            throw new NotImplementedException();
        }

        public void GeneratePDF()
        {
            //TODO -- Generate a document

            base.Print();
        }
    }

    public class Admin : AbstractRepository
    {
        public Admin()
        {
        }

        public override void AddRecord(Student st)
        {
            throw new NotImplementedException();
        }

        public void GeneratePDF()
        {
            //TODO -- Generate a document

            base.Print();
        }
    }
}
