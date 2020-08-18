
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_gMartin
{
    class ValidationLib
    {
        public static bool GotPoop(string temp)
        {
            bool result = false;

            if (temp.Contains("Poopy"))
            {
                result = true;
            }

            return result;
        }


        //Requires input 
        public static bool dataEntered(string temp)
        {
            bool result = false;
            
            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }



        //Validate that the email is formatted correctly
        public static bool validateEmail(string temp) 
        {
            bool blnResult = true;
            int atLocation = temp.IndexOf("@");
            int NextLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResult = false;
            }

            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }

            return blnResult;
            }
            
          

    }
}