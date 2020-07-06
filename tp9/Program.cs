using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Helpers;
 
namespace tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //__________________PUNTO 1 a
            //string directorio = @"C:\taller1_2020(C#)\tpn9-NTVGcele";
            //string nombreDelArchivo = @"\detino.dat";
            //SoporteParaConfiguracion.CrearArchivoDeConfiguracion(directorio);
            //SoporteParaConfiguracion.LeerConfiguracion(directorio);


            //b

            //string Path = @"C:\taller1_2020(C#)\tpn9-NTVGcele\tp9\bin\Debug";
            //List<string> ListaDeArchivos = Directory.GetFiles(Path).ToList();
            //string[] ext;
            //foreach (string Arc in ListaDeArchivos)
            //{
            //    ext = Arc.Split(".");
            //    int i = 0;

            //    if (ext[1] == "mp3" || ext[1] == "txt")
            //    {

            //        string PathCopia = @"C:\taller1_2020(C#)\tpn9-NTVGcele\" + "_Copia" + i + "." + ext[1];
            //        File.Move(Arc, PathCopia);
            //        i++;
            //    }
            //}

            //_____________________PUNTO 2 
            //texto a morse
            string palabra;
            Console.Write("\nEscriba un texto para traducirlo a codigo Morse: ");
            palabra = Console.ReadLine();
            string aux = ConversorDeMorse.TextoAMorse(palabra);
            Console.Write(aux);


            //creo archivo de texto a Morse
            string[] arr = { aux };
            string textAMorse = @"C:\taller1_2020(C#)\tpn9-NTVGcele\TextAMorse.txt";
            if (!File.Exists(textAMorse))
            {
                File.Create(textAMorse);
                File.WriteAllLines(textAMorse, arr);
            }
            else
            {
                File.WriteAllLines(textAMorse, arr);
            }


            //morse a texto
            string palabra1;
            Console.Write("\nEscriba en Morse para traducirlo a castellano: ");
            palabra1 = Console.ReadLine();
            string aux1 = ConversorDeMorse.MorseATexto(palabra1);
            Console.WriteLine(aux1);

            //creo archivo de morse a texto
            string morse = File.ReadAllText(textAMorse);
            string aux2 = ConversorDeMorse.MorseATexto(morse);
            string[] arrmorse = {aux2};
            string MorseAText = @"C:\taller1_2020(C#)\tpn9-NTVGcele\MorseATexto.txt";
            if (!File.Exists(MorseAText))
            {

                File.Create(MorseAText);
                Console.WriteLine("CDScdasc  CREADO");
                File.WriteAllLines(MorseAText, arrmorse);
            }
            else
            {
                Console.WriteLine("CDScdasya esta");

                File.WriteAllLines(MorseAText, arrmorse);
            }

        }
    }
}
