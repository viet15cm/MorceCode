using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ModeCode
{
    class Program
    {
       public static void Main(string[] args)

        {
            string morseCode = "···· · −·−−   ·−−− ··− −·· ·";

            string morseBit = "0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111" +
             "000000101100011111100000111110011101100000100000";


            //Console.WriteLine("\n\n" + "MorseCode : " + TranslaterMorseBit.decodeBitsAdvanced(morseBit));

            //Console.WriteLine("\n\n" + "Translater MorseCode : " + 
            //TranslaterMorseCharacters.decodeMorse(TranslaterMorseBit.decodeBitsAdvanced(morseBit)));


            if (String.Compare("HEY JUDE", TranslaterMorseCharacters.decodeMorse(TranslaterMorseBit.decodeBitsAdvanced(morseBit)), false) == 0)

             Console.WriteLine("True");

             else Console.WriteLine("False");
            
           

            

            Console.ReadKey();
        
        }
    }
}
