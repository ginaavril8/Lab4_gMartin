//Gina Martin                       Lab 4                                 8.14.20                 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_gMartin
{
    class Program
    {
        public class Demographics
        {
            //Public varibales representing demograpgic information
            private string firstname;
            private string middlename;
            private string lastname;
            private string addressone;
            private string addresstwo;
            private string city;
            private string state;
            private Double zipcode;
            private Double phonenumber;
            private string email;


            public string FirstName
            {
                get
                {
                    return firstname;
                }

                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        firstname = value;
                    }
                    else
                    {
                        firstname = "Please enter a valid first name.";
                    }
                    
                }
            }

            public string MiddleName
            {
                get
                {
                    return middlename;
                }
                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        middlename = value;
                    }
                    else
                    {
                        middlename = "Please enter a valid middle name.";
                    }
                }
            }
            
          
                

            public string LastName
            {
                get
                {
                    return lastname;
                }
                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        lastname = value;

                    }
                    else
                    {
                        lastname = "Please enter a valid last name.";
                    }

                }
            }


            public string AddressOne
            {
                get
                {
                    return addressone;
                }

                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        addressone = value;
                    }
                    else
                    {
                        addressone = "Please enter a valid address.";
                    }
                }
            }

            public string AddressTwo
            {
                get
                {
                    return addresstwo;
                }
                set
                {
                    addresstwo = value;
                }

            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        city = value;
                    }
                    else
                    {
                        city = "Please enter valid city or town.";
                    }
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    if (ValidationLib.dataEntered(value))
                    {
                        state = value;
                    }
                    else
                    {
                        state = "Please enter a valid state.";
                    }
                }
            }

            public Double Zipcode
            {
                get
                {
                    return zipcode;
                }

                set
                {
                
                    {
                        zipcode = value;
                    }
                }
            }

            public Double PhoneNumber
            {
                get
                {
                    return phonenumber;
                }
                set
                {
                    phonenumber = value;
                }
            }



            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (ValidationLib.validateEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        email = "Invaild Email.";
                    }

                }
                
            }
        }


        static void Main(string[] args)
        {

            Console.Write("Demographic's Intake Information \n");

            //Boolean value for validation
            bool blnResult = false;

            //Create a demogrphaic form to store objects in 
            Demographics temp = new Demographics();


            //Fill in Demographics starting below

            //First name input
            Console.Write("\nFirst Name: ");
            temp.FirstName = Console.ReadLine();
            
            //Middle name input
            Console.Write("\nMiddle Name: ");
             temp.MiddleName = Console.ReadLine();
            
            //Last name input
             Console.Write("\nLast Name: ");
             temp.LastName = Console.ReadLine();

            //First address input
            Console.Write("\nAddress 1: ");
            temp.AddressOne = Console.ReadLine();

            //Second address input
            Console.Write("\nAddress 2 (optional): ");
            temp.AddressTwo = Console.ReadLine();

            //City input
            Console.Write("\nCity: ");
            temp.City = Console.ReadLine();

            //State input
            Console.Write("\nState: ");
            temp.State = Console.ReadLine();

            //Zipcode input
            //Console.Write("\n\nZipcode: ");
            //temp.Zipcode = Console.ReadLine();


            do
            {
                Console.Write("\nZipcode: ");
                Double tmpZip;
                blnResult = Double.TryParse(Console.ReadLine(), out tmpZip);

                if (blnResult == false)
                {
                    Console.Write("\nPlease enter a five digit number. (Ex. 02818)");
                }
                else
                {
                    temp.Zipcode = tmpZip;
                }
            } while (blnResult == false);




            //Phone number input
            //Console.Write("\nPhone Number: ");
            //temp.PhoneNumber = Console.ReadLine();

            do
            {
                Console.Write("\nPhone Number: ");
                Double tmpPhoneNumber;
                blnResult = Double.TryParse(Console.ReadLine(), out tmpPhoneNumber);

                if (blnResult == false)
                {
                    Console.Write("\nPlease enter a ten digit number. (Ex. 888222555)");
                }
                else
                {
                    temp.PhoneNumber = tmpPhoneNumber;
                }
            } while (blnResult == false);


            //Email input
            Console.Write("\nEmail: ");
            temp.Email = Console.ReadLine();



            //Output all demographic inputs
            Console.Write("\n\nDemographic Intake Information\n");
              Console.Write($"\n First Name: {temp.FirstName}");
              Console.Write($"\n Middle Name: {temp.MiddleName}");
              Console.Write($"\n Last Name: {temp.LastName}");
              Console.Write($"\n Address 1: {temp.AddressOne}");
              Console.Write($"\n Address 2: {temp.AddressTwo}");
              Console.Write($"\n City: {temp.City}");
              Console.Write($"\n State: {temp.State}");
              Console.Write($"\n Zipcode: {temp.Zipcode}");
              Console.Write($"\n Phone Number: {temp.PhoneNumber}");
              Console.Write($"\n Email: {temp.Email}");



              BasicTools.Pause();





            }
        }
}
