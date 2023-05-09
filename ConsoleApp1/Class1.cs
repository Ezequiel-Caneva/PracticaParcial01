using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
       public string _Fecha { set; get; }
       public string _NombreArchivo { set; get; }

       public Hashtable e = CollectionsUtil.CreateCaseInsensitiveHashtable();


        public void addcoleccion(string e,int i)
        {
            this.e.Add(e , i);
        }

        public Class1()
        {

        }

    }
}
