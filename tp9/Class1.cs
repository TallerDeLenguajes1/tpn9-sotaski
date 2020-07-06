using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string Directorio)
        {
            string nuevoArchivo = Directorio + @"\detino.dat";
            if (!File.Exists(nuevoArchivo))
            {
                File.Create(nuevoArchivo);
            }
        }
        public static void LeerConfiguracion(string Directorio)
        {
            string nuevoArchivo = Directorio + @"\detino.dat";
            string leerArchiv = File.ReadAllText(nuevoArchivo);
            Console.WriteLine(leerArchiv);
           
        }
    }
    public static class ConversorDeMorse
    {
        public static string TextoAMorse(string palabra)
        {
            string aux = "";
            for(int i = 0; i < palabra.Length; i++)
            {
                switch (palabra[i])
                 {
                    case 'a':
                    case 'A': aux = aux +".- ";break;
                    case 'b':
                    case 'B': aux = aux +"-... "; break;
                    case 'c':
                    case 'C': aux = aux + "-.-. "; break;
                    case 'd':
                    case 'D': aux = aux + "-.. "; break;
                    case 'e':
                    case 'E': aux = aux + ". "; break;
                    case 'f':
                    case 'F': aux = aux + "..-. "; break;
                    case 'g':
                    case 'G': aux = aux + "--. "; break;
                    case 'h':
                    case 'H': aux = aux + ".... "; break;
                    case 'i':
                    case 'I': aux = aux + ".. "; break;
                    case 'j':
                    case 'J': aux = aux + ".--- "; break;
                    case 'k':
                    case 'K': aux = aux + "-.- "; break;
                    case 'l':
                    case 'L': aux = aux + ".-.. "; break;
                    case 'm':
                    case 'M': aux = aux + "-- "; break;
                    case 'n':
                    case 'N': aux = aux + "-. "; break;
                    case 'o':
                    case 'O': aux = aux + "--- "; break;
                    case 'p':
                    case 'P': aux = aux + ".--. "; break;
                    case 'q':
                    case 'Q': aux = aux + "--.- "; break;
                    case 'r':
                    case 'R': aux = aux + ".-. "; break;
                    case 's':
                    case 'S': aux = aux + "... "; break;
                    case 't':
                    case 'T': aux = aux + "- "; break;
                    case 'u':
                    case 'U': aux = aux + "..- "; break;
                    case 'v':
                    case 'V': aux = aux + "...- "; break;
                    case 'w':
                    case 'W': aux = aux + ".-- "; break;
                    case 'x':
                    case 'X': aux = aux + "-..- "; break;
                    case 'y':
                    case 'Y': aux = aux + "-.-- "; break;
                    case 'z':
                    case 'Z': aux = aux + "--.. "; break;
                    case '1': aux = aux + ".---- "; break;
                    case '2': aux = aux + "..--- "; break;
                    case '3': aux = aux + "...-- "; break;
                    case '4': aux = aux + "....- "; break;
                    case '5': aux = aux + "..... "; break;
                    case '6': aux = aux + "-.... "; break;
                    case '7': aux = aux + "--... "; break;
                    case '8': aux = aux + "---.. "; break;
                    case '9': aux = aux + "----. "; break;
                    case '0': aux = aux + "----- "; break;
                    case ' ': aux = aux + " ";break;                        
                }
                
            }
            return aux;
        }
        static Dictionary<char, String> morseDict = new Dictionary<char, String>()
        {
            {'A' , ".-"},
            {'B' , "-..."},
            {'C' , "-.-."},
            {'D' , "-.."},
            {'E' , "."},
            {'F' , "..-."},
            {'G' , "--."},
            {'H' , "...."},
            {'I' , ".."},
            {'J' , ".---"},
            {'K' , "-.-"},
            {'L' , ".-.."},
            {'M' , "--"},
            {'N' , "-."},
            {'O' , "---"},
            {'P' , ".--."},
            {'Q' , "--.-"},
            {'R' , ".-."},
            {'S' , "..."},
            {'T' , "-"},
            {'U' , "..-"},
            {'V' , "...-"},
            {'W' , ".--"},
            {'X' , "-..-"},
            {'Y' , "-.--"},
            {'Z' , "--.."},
            {'0' , "-----"},
            {'1' , ".----"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
        };

        public static string MorseATexto​(string morse)
        {
            string texto = "";
            string aux = "";

            for (int i = 0; i < morse.Length; i++)
            {
                if (morse[i] == '/')
                {
                    texto += ' ';
                }
                else
                {
                    if (morse[i] != ' ')
                    {
                        aux += morse[i];
                    }
                    else
                    {
                        foreach (KeyValuePair<char, string> item in morseDict)
                        {
                            if (aux == item.Value)
                            {
                                texto += item.Key;
                                aux = "";
                            }
                        }
                    }
                }
            }

            return texto;
        }
           
    }
}
