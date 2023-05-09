using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionMonitoreo.V4._0.BaseDatos
{
    class crearCsv
    {
        static void datos(string[] args)
        {
            escribirCSV(args[1], args[2], args[3], args[4]);
            leerCSV();
        }

        static void escribirCSV(String dat1, String dat2, String dat3, String rut)
        {
  
            String separador = ",";
            StringBuilder salida = new StringBuilder();

            String cadena = dat1 + "," + dat2 + "," + dat3;
            List<String> lista = new List<string>();
            lista.Add(cadena);

            for (int i = 0; i < lista.Count; i++)
                salida.AppendLine(string.Join(separador, lista[i]));

            // CREA Y ESCRIBE EL ARCHIVO CSV
            //File.WriteAllText(ruta, salida.ToString());

            // AÑADE MAS LINEAS AL ARCHIVO CSV
            File.AppendAllText(@"Escritorio\Datos.csv", salida.ToString());
        }

        static void leerCSV()
        {
            var reader = new StreamReader(File.OpenRead(@"Escritorio\Datos.csv"));
            List<String> lista = new List<string>();
            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                var valores = linea.Split(',');
                for (int i = 0; i < valores.Length; i++)
                {
                    if ((i % 3) == 0)
                    {
                        Console.Write(valores[i] + "-" + valores[i + 1] + "-" + valores[i + 2]);
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
