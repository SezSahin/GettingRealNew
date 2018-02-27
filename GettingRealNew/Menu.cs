using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNew
{
    public class Menu
    {
        private string username;
        private string password;
        private int id;

        Controller controller = new Controller();
        Login l = new Login();
        public void ShowMenu(int departmentID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Velkommen! Du har nu følgende valgmuligheder. \n");
            Console.WriteLine("1. Søg efter medarbejder.");
            Console.WriteLine("2. Skift din adgangskode");
            if (departmentID > 3)
            {
                Console.WriteLine("3. Opret Ny medarbejder.");
                Console.WriteLine("4. Rediger medarbejder.");
                Console.WriteLine("5. Slet medarbejder.");
                Console.WriteLine("6. Log af.");
            }
            if (departmentID < 4)
            {
                Console.WriteLine("3. Log af.");
            }
            Console.WriteLine("\n0. Luk konsol \n");
            string menu_answer = Console.ReadLine();
            if (departmentID > 3)
            {
                switch (menu_answer)
                {
                    case "1":
                        Console.WriteLine("Søg efter medarbejder. \n");
                        Search(departmentID);
                        break;
                    case "2":
                        Console.WriteLine("Skift din adgangskode");
                        controller.ChangePassword(id, username, password, departmentID);
                        break;
                    case "3":
                        Console.WriteLine("Opret medarbejder \n");
                        Console.WriteLine("Indtast Brugernavn \n");
                        string newUser = Console.ReadLine();
                        Console.WriteLine("Indtast Pasword \n");
                        string newPassword = Console.ReadLine();
                        Console.WriteLine("Indtast Navn og mellem navn \n");
                        string newFirstname = Console.ReadLine();
                        Console.WriteLine("Indtast Efternavn \n");
                        string newLastname = Console.ReadLine();
                        Console.WriteLine("Indtast Addresselinje 1 \n");
                        string newAddress1 = Console.ReadLine();
                        Console.WriteLine("Indtast Addresselinje 2 \n");
                        string newAddress2 = Console.ReadLine();
                        Console.WriteLine("Indtast Addresse By\n");
                        string newCity = Console.ReadLine();
                        Console.WriteLine("Indtast Post nr.\n");
                        string newZip = Console.ReadLine();
                        Console.WriteLine("Indtast Telefon nr.\n");
                        string newPhoneNo = Console.ReadLine();
                        Console.WriteLine("Indtast e-mail \n \n");
                        string newEmail = Console.ReadLine();
                        Console.WriteLine("Indtast CPR \n");
                        string newSecurityNo = Console.ReadLine();
                        Console.WriteLine("Indtast Konto nr. \n");
                        string newAccountNo = Console.ReadLine();
                        Console.WriteLine("Indtast Reg nr. \n");
                        string newReqNo = Console.ReadLine();
                        Console.WriteLine("Indtast AfdelingsID \n");
                        string newDepartmentid = Console.ReadLine();
                        Console.WriteLine("Indtast Sundhedsoplysninger \n");
                        string newHealth = Console.ReadLine();
                        Console.WriteLine("Indtast Jobtype \n");
                        string newJobtype = Console.ReadLine();
                        Console.WriteLine("Indtast Medarbejder nr. \n");
                        string newEmploymentNo = Console.ReadLine();
                        Console.WriteLine("Indtast Kontakt navn \n");
                        string newContactPerson = Console.ReadLine();
                        Console.WriteLine("Indtast Kontakt nr. \n");
                        string newContactPhoneNo = Console.ReadLine();
                        controller.Create(newUser, newPassword, newFirstname, newLastname,
                            newAddress1, newAddress2, newCity, newZip, newPhoneNo, newEmail,
                            newSecurityNo, newAccountNo, newReqNo, newDepartmentid, newHealth, newJobtype,
                            newEmploymentNo, newContactPerson, newContactPhoneNo,
                            departmentID);
                        break;
                    case "4":
                        Console.WriteLine("Rediger medarbejder \n");
                        Console.WriteLine("Indtast Medarbejder nr.");
                        string employeeNo = Console.ReadLine();
                        controller.Edit(employeeNo, departmentID);
                        break;
                    case "5":
                        Console.WriteLine("Slet medarbejder \n");
                        Console.WriteLine("\nSlet bruger med fornavn: \n");
                        newFirstname = Console.ReadLine();
                        Console.WriteLine("\nSlet bruger med efternavn: \n");
                        newLastname = Console.ReadLine();
                        Console.WriteLine("\nSlet bruger med medarbejder nummer: \n");
                        employeeNo = Console.ReadLine();
                        controller.Delete(newFirstname, newLastname, employeeNo, departmentID);
                        break;
                    case "6":
                        l.Login1();
                        break;
                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                        ShowMenu(departmentID);
                        break;
                }
            }
            else if (departmentID < 4)
            {
                {
                    switch (menu_answer)
                    {
                        case "1":
                            Console.WriteLine("\nSøg efter medarbejder. \n");
                            Search(departmentID);
                            break;
                        case "2":
                            Console.WriteLine("Skift din adgangskode");
                            controller.ChangePassword(id, username, password, departmentID);
                            break;
                        case "3":
                            l.Login1();
                            break;
                        case "0":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal der passer til valgmulighederne");
                            ShowMenu(departmentID);
                            break;
                    }
                }
            }
        }
        public void Search(int ID)
        {
            Console.WriteLine("\nIndtast Nøgleord \n");
            string keyword = Console.ReadLine();

            controller.Search(keyword, ID);


        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}