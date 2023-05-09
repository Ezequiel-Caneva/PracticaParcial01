using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Specialized;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void formatearFecha()
        {
            var fechadehoy = DateTime.Now;

            //lunes 08 de Mayo de 2023 a las "hora actual" 
            var fechaStri = fechadehoy.ToString("dddd dd \\de MMMM \\de yyyy a la\\s H:mm");

            // opcion con hora: Assert.Equal("lunes 08 de mayo de 2023 a las 22:22", fechaStri);



            //ejer 2 formato extendido 
            var fechatoString = fechadehoy.ToString("D");
            Assert.Equal("lunes, 8 de mayo de 2023", fechatoString);

            var fechaStringCorto = fechadehoy.ToString("dd/MM/yyyy");
            Assert.Equal("08/05/2023", fechaStringCorto);


        }
        [Fact]
        public void DebeDarNombre()
        {
            var d = Directory.CreateDirectory("C:/Users/ezeca/Desktop/Archivo");
            d.CreateSubdirectory("a01");

            Assert.True(true);
            var fechadehoy = DateTime.Now.ToString("D");

            var a = new Class1();
            a._Fecha = fechadehoy;
            a._NombreArchivo = fechadehoy;
            var writer = new StreamWriter($"C:/Users/ezeca/Desktop/Archivo/a01/{a._NombreArchivo}.txt");

            writer.Write(a._Fecha);
            writer.Close();


            var reader = new System.IO.StreamReader(path: $"C:/Users/ezeca/Desktop/Archivo/a01/{a._NombreArchivo}.txt");
            var contenido = reader.ReadToEnd();

            reader.Close();
            Assert.Equal("martes, 9 de mayo de 2023", contenido);

            Assert.True(true);



        }
        [Fact]
        public void coleccion()
        {
            var a = new Class1();

            a.addcoleccion("Juan", 8);
            a.addcoleccion("Elias", 10);
            a.addcoleccion("Federico", 7);
            a.addcoleccion("Joaquin", 5);
            a.addcoleccion("Alvaro", 16);

            //ordenar
            var elementosOrdenados = a.e.Cast<DictionaryEntry>()
                            .OrderByDescending(x => (int)x.Value)
                            .ToList();


            Hashtable g = CollectionsUtil.CreateCaseInsensitiveHashtable();

            g.Add("JoaQuin", 5);
            g.Add("FeDErico", 7);
            g.Add("JuAN", 8);
            g.Add("ELIAS", 10);
            g.Add("ALVARO", 16);

            Assert.Equal(g[0], a.e[0]);
            Assert.Equal(g[4], a.e[4]);

            //seleccionar
            var seleccion = (from DictionaryEntry e in a.e
                             where string.Equals(e.Key.ToString(), "Joaquin", StringComparison.OrdinalIgnoreCase)
                             select e).FirstOrDefault();

            Assert.Equal("Joaquin", seleccion.Key);

            //Remover

            var clave = (from DictionaryEntry e in a.e
                         where string.Equals(e.Key.ToString(), "Joaquin", StringComparison.OrdinalIgnoreCase)
                         select e.Key).FirstOrDefault();

            if (clave != null)
            {
                g.Remove(clave);
            }

            /*
            var lista = new Queue<string>();

            lista.Enqueue("a");
            lista.Enqueue("B"); 
            lista.Enqueue("C");

            var aux = (from c in lista
                       where c == "c"
                       select c).ToList().FindIndex(c => c == "C");

            
            if (aux >= 0)
            {
                for (int i = 0; i <= lista.Count; i++)
                {
                    if (i < aux)
                    {
                        lista.Enqueue(lista.Dequeue());
                    }
                    else
                    {
                        lista.Dequeue();
                    }
                }

            }
            lista = new Queue<string>((from c in lista
                                       where c != "C"
                                       select c).ToList());

            Assert.False(lista.Contains("C"));



            var listanueva = new Queue<string>();

            listanueva.Enqueue("a");
            listanueva.Enqueue("B");
            

            Assert.Equal(listanueva, lista);

            */

        }
    }
}
