using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeCode
{
    public class TranslaterMorseCharacters
    {

        public static string setStringMorse(string crt)
        {
           
            if(crt != null)
            {
                crt = crt.Replace("  ", " space ");

                return crt;
            }

            return null;
        }



        public static List<string> ListMorse(string crt)
        {
            List<string> listMorse = new List<string>();
            if(crt != null)
            {
                String[] str = crt.Split(' ');
                for(int i = str.Length -1; i>=0; i--)
                {
                    listMorse.Add(str[i]);
                }

                return listMorse;
            }

            return null;
        }

        public static string TranslaterMorse(string crt)
        {
            if(crt != null)
            {
               
                switch (crt)                    // (−) (char) 8722 ; (·) (char)183;
                {
                    
                    case "····":                // byte[] b = { 8722, 8722,8722,8722 }; ====> string str = Encoding.Default.GetString(b);
                        return "H";
                    case "·":                   // byte[] b = { 183 };
                        return "E";
                    case "−·−−":                //byte[] b = { 8722, 183,8722,8722 };
                        return "Y";
                    case "·−−−":
                        return "J";
                    case "··−":
                        return "U";
                    case "−··":
                        return "D";
                    case "space":
                        return " ";
                    default :
                        return "";
                }
            }

            return "";
        }

      /*  public static string TranslaterMorse_2(string crt)
        {
            
            if(crt != null)
            {

                if (crt.ToString().Equals(((char)183).ToString() + ((char)183).ToString() + ((char)183).ToString() + ((char)183).ToString()))
                    return "H";
                else if (crt.ToString().Equals(((char)183).ToString()))
                    return "E";
                else if (crt.ToString().Equals(((char)8722).ToString() + ((char)183).ToString() + ((char)8722).ToString() + ((char)8722).ToString()))
                    return "Y";
                else if (crt.ToString().Equals(((char)183).ToString() + ((char)8722).ToString() + ((char)8722).ToString() + ((char)8722).ToString()))
                    return "J";
                else if (crt.ToString().Equals(((char)183).ToString() + ((char)183).ToString() + ((char)8722).ToString()))
                    return "U";
                else if (crt.ToString().Equals(((char)8722).ToString() + ((char)183).ToString() + ((char)183).ToString()))
                    return "D";
                else if (crt.ToString().Equals("space"))
                    return " ";
                else
                    return "";

            }

            return "";
        }
    */

        public static string decodeMorse(string morseCode)
        {
            if (morseCode != null)
            {
                morseCode = setStringMorse(morseCode);

                List<string> listMorse = ListMorse(morseCode);
                morseCode = "";

                for (int i = listMorse.Count - 1; i >= 0; i--)

                    morseCode += TranslaterMorse(listMorse[i]);

                return morseCode;
            }

            return "";
        }
    }
}
