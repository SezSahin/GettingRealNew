using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Diagnostics;

namespace GettingRealNew
{
    public class Controller
    {

        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";

        public void Search(string keyword, int departmentID)
        {
            Menu menu = new Menu();
            string[] word = keyword.Split(' ');

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    if (word.Length == 1)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", word[0]));
                        if (word[0] == "")
                        {
                            word[0] = null;
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                Console.ForegroundColor = ConsoleColor.White;
                                string ID = reader["ID"].ToString();

                                //if (!idCheck.Contains(ID))
                                //{
                                //idCheck[i] = ID;
                                string Username = reader["Brugernavn"].ToString();
                                string Firstname = reader["Navn"].ToString();
                                string Lastname = reader["Efternavn"].ToString();
                                string Address1 = reader["Addresse"].ToString();
                                string Address2 = reader["Addresse_l2"].ToString();
                                string City = reader["Addresse_by"].ToString();
                                string Zip = reader["Addresse_postnr"].ToString();
                                string PhoneNo = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SecurityNo = reader["CPR_nr"].ToString();
                                string AccountNo = reader["konto_nr"].ToString();
                                string RegNo = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string Jobtype = reader["JobType"].ToString();
                                string EmployeeNo = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNo = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                if (departmentID > 3)
                                {
                                    Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + Username + "\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Adresselinje 1: " + Address1 + "\n - Adresselinje 2: " + Address2 + "\n - By: " + City + "\n - Post nr: " + Zip + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email + "\n - CPR nr: " + SecurityNo + "\n - Konto nr: " + AccountNo + "\n - Reg nr: " + RegNo + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + Jobtype + "\n - MedarbejderNr: " + EmployeeNo + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNo);
                                }
                                else
                                {
                                    Console.WriteLine("\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email);
                                }
                            }
                        }
                    }
                    //reader.Close();
                    //}

                    if (word.Length == 2)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg2P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", word[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", word[1]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string Username = reader["Brugernavn"].ToString();
                                string Firstname = reader["Navn"].ToString();
                                string Lastname = reader["Efternavn"].ToString();
                                string Address1 = reader["Addresse"].ToString();
                                string Address2 = reader["Addresse_l2"].ToString();
                                string City = reader["Addresse_by"].ToString();
                                string Zip = reader["Addresse_postnr"].ToString();
                                string PhoneNo = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SecurityNo = reader["CPR_nr"].ToString();
                                string AccountNo = reader["konto_nr"].ToString();
                                string RegNo = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string Jobtype = reader["JobType"].ToString();
                                string EmployeeNo = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNo = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                if (departmentID > 3)
                                {
                                    Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + Username + "\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Adresselinje 1: " + Address1 + "\n - Adresselinje 2: " + Address2 + "\n - By: " + City + "\n - Post nr: " + Zip + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email + "\n - CPR nr: " + SecurityNo + "\n - Konto nr: " + AccountNo + "\n - Reg nr: " + RegNo + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + Jobtype + "\n - MedarbejderNr: " + EmployeeNo + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNo);
                                }
                                else
                                {
                                    Console.WriteLine("\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email);
                                }
                            }
                        }
                    }

                    if (word.Length == 3)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg3P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", word[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", word[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", word[2]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string Username = reader["Brugernavn"].ToString();
                                string Firstname = reader["Navn"].ToString();
                                string Lastname = reader["Efternavn"].ToString();
                                string Address1 = reader["Addresse"].ToString();
                                string Address2 = reader["Addresse_l2"].ToString();
                                string City = reader["Addresse_by"].ToString();
                                string Zip = reader["Addresse_postnr"].ToString();
                                string PhoneNo = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SecurityNo = reader["CPR_nr"].ToString();
                                string AccountNo = reader["konto_nr"].ToString();
                                string RegNo = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string Jobtype = reader["JobType"].ToString();
                                string EmployeeNo = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNo = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                if (departmentID > 3)
                                {
                                    Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + Username + "\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Adresselinje 1: " + Address1 + "\n - Adresselinje 2: " + Address2 + "\n - By: " + City + "\n - Post nr: " + Zip + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email + "\n - CPR nr: " + SecurityNo + "\n - Konto nr: " + AccountNo + "\n - Reg nr: " + RegNo + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + Jobtype + "\n - MedarbejderNr: " + EmployeeNo + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNo);
                                }
                                else
                                {
                                    Console.WriteLine("\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email);
                                }
                            }
                        }
                    }

                    if (word.Length == 4)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg4P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", word[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", word[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", word[2]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword4", word[3]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string Username = reader["Brugernavn"].ToString();
                                string Firstname = reader["Navn"].ToString();
                                string Lastname = reader["Efternavn"].ToString();
                                string Address1 = reader["Addresse"].ToString();
                                string Address2 = reader["Addresse_l2"].ToString();
                                string City = reader["Addresse_by"].ToString();
                                string Zip = reader["Addresse_postnr"].ToString();
                                string PhoneNo = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SecurityNo = reader["CPR_nr"].ToString();
                                string AccountNo = reader["konto_nr"].ToString();
                                string RegNo = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string Jobtype = reader["JobType"].ToString();
                                string EmployeeNo = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNo = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                if (departmentID > 3)
                                {
                                    Console.WriteLine(" - ID: " + ID + "\n - Brugernavn: " + Username + "\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Adresselinje 1: " + Address1 + "\n - Adresselinje 2: " + Address2 + "\n - By: " + City + "\n - Post nr: " + Zip + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email + "\n - CPR nr: " + SecurityNo + "\n - Konto nr: " + AccountNo + "\n - Reg nr: " + RegNo + "\n - AfdelingsID: " + DepartmentID + "\n - Sundhedsolysninger: " + Health + "\n - Jobtype: " + Jobtype + "\n - MedarbejderNr: " + EmployeeNo + "\n - KontaktPerson: " + ContactName + "\n - KontaktNr: " + ContactNo);
                                }
                                else
                                {
                                    Console.WriteLine("\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email);
                                }
                            }
                        }
                    }

                    if (word.Length == 5)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSøg4P", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Keyword", word[0]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword2", word[1]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword3", word[2]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword4", word[3]));
                        cmd.Parameters.Add(new SqlParameter("@Keyword5", word[4]));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string Username = reader["Brugernavn"].ToString();
                                string Firstname = reader["Navn"].ToString();
                                string Lastname = reader["Efternavn"].ToString();
                                string Address1 = reader["Addresse"].ToString();
                                string Address2 = reader["Addresse_l2"].ToString();
                                string City = reader["Addresse_by"].ToString();
                                string Zip = reader["Addresse_postnr"].ToString();
                                string PhoneNo = reader["Tlf"].ToString();
                                string Email = reader["Email"].ToString();
                                string SecurityNo = reader["CPR_nr"].ToString();
                                string AccountNo = reader["konto_nr"].ToString();
                                string RegNo = reader["reg_nr"].ToString();
                                string DepartmentID = reader["AfdelingsID"].ToString();
                                string Health = reader["Sundhedsoplysninger"].ToString();
                                string Jobtype = reader["JobType"].ToString();
                                string EmployeeNo = reader["MedarbejderNr"].ToString();
                                string ContactName = reader["KontaktPerson"].ToString();
                                string ContactNo = reader["KontaktNr"].ToString();
                                Console.WriteLine("\n Medarbejder:");
                                if (departmentID > 3)
                                {
                                    Console.WriteLine(" - ID: " + ID +
                                        "\n - Brugernavn: " + Username +
                                        "\n - Fornavn " + Firstname +
                                        "\n - Efternavn " + Lastname +
                                        "\n - Adresselinje 1: " + Address1 +
                                        "\n - Adresselinje 2: " + Address2 +
                                        "\n - By: " + City +
                                        "\n - Post nr: " + Zip +
                                        "\n - Telefon nr: " + PhoneNo +
                                        "\n - Email: " + Email +
                                        "\n - CPR nr: " + SecurityNo +
                                        "\n - Konto nr: " + AccountNo +
                                        "\n - Reg nr: " + RegNo +
                                        "\n - AfdelingsID: " + DepartmentID +
                                        "\n - Sundhedsolysninger: " + Health +
                                        "\n - Jobtype: " + Jobtype +
                                        "\n - MedarbejderNr: " + EmployeeNo +
                                        "\n - KontaktPerson: " + ContactName +
                                        "\n - KontaktNr: " + ContactNo);
                                }
                                else
                                {
                                    Console.WriteLine("\n - Fornavn " + Firstname + "\n - Efternavn " + Lastname + "\n - Telefon nr: " + PhoneNo + "\n - Email: " + Email);
                                }
                            }
                        }
                    }
                    if (word.Length > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Din søgning var for lang.");
                        Thread.Sleep(2000);
                        con.Close();
                        menu.ShowMenu(departmentID);
                    }
                    Console.WriteLine("\nTryk 'Enter' for at vende tilbage til menuen");
                    Console.ReadKey();
                    con.Close();
                    menu.ShowMenu(departmentID);


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ugyldig information " + e.Message + "\n");
                }
            }
        }


        public void Create(string newUser, string newPassword, string newFirstname,
            string newLastname, string newAddress1, string newAddress2, string newCity,
            string newZip, string newPhoneNo, string email, string newSecurityNo,
            string newAccountNo, string newReqNo, string newDepartmentNo, string newHealth,
            string jobtype, string newEmployeeNo, string newContactPerson,
            string newContactPhoneNo, int newDepartmentID)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (newDepartmentID > 3)
                {
                    try
                    {
                        con.Open();
                        SqlCommand handling = new SqlCommand("spOpretBruger", con);
                        handling.CommandType = System.Data.CommandType.StoredProcedure;
                        handling.Parameters.Add(new SqlParameter("@Brugernavn", newUser));
                        handling.Parameters.Add(new SqlParameter("@Password", newPassword));
                        handling.Parameters.Add(new SqlParameter("@Navn", newFirstname));
                        handling.Parameters.Add(new SqlParameter("@Efternavn", newLastname));
                        handling.Parameters.Add(new SqlParameter("@Addresse", newAddress1));
                        handling.Parameters.Add(new SqlParameter("@Addresse_l2", newAddress2));
                        handling.Parameters.Add(new SqlParameter("@Addresse_by", newCity));
                        handling.Parameters.Add(new SqlParameter("@Addresse_postnr", newZip));
                        handling.Parameters.Add(new SqlParameter("@Tlf", newPhoneNo));
                        handling.Parameters.Add(new SqlParameter("@Email", email));
                        handling.Parameters.Add(new SqlParameter("@CPR_nr", newSecurityNo));
                        handling.Parameters.Add(new SqlParameter("@konto_nr", newAccountNo));
                        handling.Parameters.Add(new SqlParameter("@reg_nr", newReqNo));
                        handling.Parameters.Add(new SqlParameter("@AfdelingsID", newDepartmentNo));
                        handling.Parameters.Add(new SqlParameter("@Sunhedsoplysninger", newHealth));
                        handling.Parameters.Add(new SqlParameter("@JobType", jobtype));
                        handling.Parameters.Add(new SqlParameter("@MedarbejderNr", newEmployeeNo));
                        handling.Parameters.Add(new SqlParameter("@KontaktPerson", newContactPerson));
                        handling.Parameters.Add(new SqlParameter("@KontaktNr", newContactPhoneNo));


                        Console.Clear();

                        //cmd.ExecuteNonQuery();

                        Console.Clear();

                        Console.WriteLine("Gem? Ja = y|| Nej = n ");

                        var input = Console.ReadKey(true).Key;

                        Menu menu = new Menu();
                        switch (input)
                        {

                            case ConsoleKey.Y: Save(handling); con.Close(); menu.ShowMenu(newDepartmentID); break;

                            case ConsoleKey.N: con.Close(); menu.ShowMenu(newDepartmentID); break;

                            default:
                                Console.WriteLine("Default case");
                                break;

                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("UPS " + e.Message + "\n");
                    }
                }
                else
                {
                    con.Close();
                    Menu menu = new Menu();
                    menu.ShowMenu(newDepartmentID);
                }
            }
        }

        public void Edit(string arbejdernr, int afdelingsID)
        {
            if (3 < afdelingsID)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {

                        con.Open();
                        SqlCommand handling = new SqlCommand("spFinnMedarbejder", con);
                        handling.CommandType = System.Data.CommandType.StoredProcedure;
                        Console.Clear();
                        handling.Parameters.Add(new SqlParameter("@MedarbejderNr", arbejdernr));
                        handling.ExecuteNonQuery();

                        SqlDataReader reader = handling.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string UserName = reader["Brugernavn"].ToString();
                                Console.WriteLine("Indtast Brugernavn");
                                Console.WriteLine("Nuværende Brugernavn: " + UserName);
                                string Username1 = Console.ReadLine();
                                if (Username1 != "")
                                {
                                    UserName = Username1;
                                }

                                string Firstname = reader["Navn"].ToString();
                                Console.WriteLine("Indtast Navn");
                                Console.WriteLine("Nuværende Navn: " + Firstname);
                                string Firstname1 = Console.ReadLine();
                                if (Firstname1 != "")
                                {
                                    Firstname = Firstname1;
                                }

                                string Lastname = reader["Efternavn"].ToString();
                                Console.WriteLine("Indtast Efternavn");
                                Console.WriteLine("Nuværende Efternavn: " + Lastname);
                                string Lastname1 = Console.ReadLine();
                                if (Lastname1 != "")
                                {
                                    Lastname = Lastname1;
                                }

                                string Address = reader["Addresse"].ToString();
                                Console.WriteLine("Indtast Addresse");
                                Console.WriteLine("Nuværende Addresse: " + Address);
                                string Address1 = Console.ReadLine();
                                if (Address1 != "")
                                {
                                    Address = Address1;
                                }

                                string Address2 = reader["Addresse_l2"].ToString();
                                Console.WriteLine("Indtast Addresse2");
                                Console.WriteLine("Nuværende Addresse2: " + Address2);
                                string Address21 = Console.ReadLine();
                                if (Address21 != "")
                                {
                                    Address2 = Address21;
                                }

                                string Address_city = reader["Addresse_by"].ToString();
                                Console.WriteLine("Indtast By");
                                Console.WriteLine("Nuværende By: " + Address_city);
                                string Address_city1 = Console.ReadLine();
                                if (Address_city1 != "")
                                {
                                    Address_city = Address_city1;
                                }

                                string Address_postnr = reader["addresse_postnr"].ToString();
                                Console.WriteLine("Indtast Postnummer");
                                Console.WriteLine("Nuværende Postnummer: " + Address_postnr);
                                string Address_postnr1 = Console.ReadLine();
                                if (Address_postnr1 != "")
                                {
                                    Address_postnr = Address_postnr1;
                                }

                                string Phone = reader["Tlf"].ToString();
                                Console.WriteLine("Indtast telefonnummer");
                                Console.WriteLine("Nuværende telefonnummer: " + Phone);
                                string Phone1 = Console.ReadLine();
                                if (Phone1 != "")
                                {
                                    Phone = Phone1;
                                }

                                string Email = reader["Email"].ToString();
                                Console.WriteLine("Indtast email");
                                Console.WriteLine("Nuværende email: " + Email);
                                string Email1 = Console.ReadLine();
                                if (Email1 != "")
                                {
                                    Email = Email1;
                                }

                                string CPR_nr = reader["CPR_nr"].ToString();
                                Console.WriteLine("Indtast CPR nr");
                                Console.WriteLine("Nuværende CPR nr: " + CPR_nr);
                                string CPR_nr1 = Console.ReadLine();
                                if (CPR_nr1 != "")
                                {
                                    CPR_nr = CPR_nr1;
                                }

                                string Account_nr = reader["konto_nr"].ToString();
                                Console.WriteLine("Indtast Konto nr");
                                Console.WriteLine("Nuværende Konto nr: " + Account_nr);
                                string Account_nr1 = Console.ReadLine();
                                if (Account_nr1 != "")
                                {
                                    Account_nr = Account_nr1;
                                }

                                string Reg_nr = reader["reg_nr"].ToString();
                                Console.WriteLine("Indtast Registrerings nr");
                                Console.WriteLine("Nuværende Registrerings nr: " + Reg_nr);
                                string Reg_nr1 = Console.ReadLine();
                                if (Reg_nr1 != "")
                                {
                                    Reg_nr = Reg_nr1;
                                }

                                string Health = reader["Sundhedsoplysninger"].ToString();
                                Console.WriteLine("Indtast Sundhedsoplysninger");
                                Console.WriteLine("Nuværende Sundhedsoplysninger: " + Health);
                                string Health1 = Console.ReadLine();
                                if (Health1 != "")
                                {
                                    Health = Health1;
                                }

                                string JobType = reader["JobType"].ToString();
                                Console.WriteLine("Indtast JobType");
                                Console.WriteLine("Nuværende JobType: " + JobType);
                                string JobType1 = Console.ReadLine();
                                if (JobType1 != "")
                                {
                                    JobType = JobType1;
                                }

                                string EmployeeNr = reader["MedarbejderNr"].ToString();
                                Console.WriteLine("Indtast MedarbejderNr");
                                Console.WriteLine("Nuværende MedarbejderNr: " + EmployeeNr);
                                string EmployeeNr1 = Console.ReadLine();
                                if (EmployeeNr1 != "")
                                {
                                    EmployeeNr = EmployeeNr1;
                                }

                                string ContactPerson = reader["KontaktPerson"].ToString();
                                Console.WriteLine("Indtast Kontaktperson");
                                Console.WriteLine("Nuværende Kontaktperson: " + ContactPerson);
                                string ContactPerson1 = Console.ReadLine();
                                if (ContactPerson1 != "")
                                {
                                    ContactPerson = ContactPerson1;
                                }

                                string ContactNr = reader["KontaktNr"].ToString();
                                Console.WriteLine("Indtast kontaktpersons telefonnummer");
                                Console.WriteLine("Nuværende kontaktpersons telefonnummer: " + ContactNr);
                                string ContactNr1 = Console.ReadLine();
                                if (ContactNr1 != "")
                                {
                                    ContactNr = ContactNr1;
                                }

                                string DepartmentID = reader["AfdelingsID"].ToString();
                                Console.WriteLine("Indtast kontaktpersons telefonnummer");
                                Console.WriteLine("Nuværende kontaktpersons telefonnummer: " + DepartmentID);
                                string DepartmentID1 = Console.ReadLine();
                                if (DepartmentID1 != "")
                                {
                                    DepartmentID = DepartmentID1;
                                }
                                reader.Close();

                                SqlCommand handling2 = new SqlCommand("spOpdater", con);
                                handling2.CommandType = System.Data.CommandType.StoredProcedure;
                                handling2.Parameters.Add(new SqlParameter("@BrugerNavn", UserName));
                                handling2.Parameters.Add(new SqlParameter("@Fornavn", Firstname));
                                handling2.Parameters.Add(new SqlParameter("@Efternavn", Lastname));
                                handling2.Parameters.Add(new SqlParameter("@Adresse", Address));
                                handling2.Parameters.Add(new SqlParameter("@Adressel2", Address2));
                                handling2.Parameters.Add(new SqlParameter("@By", Address_city));
                                handling2.Parameters.Add(new SqlParameter("@Postnr", Address_postnr));
                                handling2.Parameters.Add(new SqlParameter("@Tlf", Phone));
                                handling2.Parameters.Add(new SqlParameter("@Email", Email));
                                handling2.Parameters.Add(new SqlParameter("@CPR", CPR_nr));
                                handling2.Parameters.Add(new SqlParameter("@Konto", Account_nr));
                                handling2.Parameters.Add(new SqlParameter("@Reg", Reg_nr));
                                handling2.Parameters.Add(new SqlParameter("@AfdelingsID", afdelingsID));
                                handling2.Parameters.Add(new SqlParameter("@Sundhedsoplysninger", Health));
                                handling2.Parameters.Add(new SqlParameter("@JobType", JobType));
                                handling2.Parameters.Add(new SqlParameter("@MedarbejderNr", EmployeeNr));
                                handling2.Parameters.Add(new SqlParameter("@KontaktPerson", ContactPerson));
                                handling2.Parameters.Add(new SqlParameter("@KontaktNr", ContactNr));

                                Console.Clear();

                                Console.WriteLine("Gem? Ja = y|| Nej = n ");

                                var input = Console.ReadKey(true).Key;

                                Menu menu = new Menu();
                                switch (input)
                                {

                                    case ConsoleKey.Y: Save(handling2); con.Close(); menu.ShowMenu(afdelingsID); break;

                                    case ConsoleKey.N: con.Close(); menu.ShowMenu(afdelingsID); break;

                                    default:
                                        Console.WriteLine("Default case");
                                        break;

                                }

                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Medarbejder Finn's ikke \n prøv igen");
                            con.Close();
                            Menu menu = new Menu();
                            menu.ShowMenu(afdelingsID);
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Prøv igen " + e.Message + "\n");
                    }
                }
            }
        }

        public void Save(SqlCommand handling)
        {
            handling.ExecuteNonQuery();
            Console.WriteLine("Gemt!");
            Thread.Sleep(2000);
        }

        public void Delete(string firstname, string lastname, string employeeNo, int departmentID)
        {
            if (3 < departmentID)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("spSletBruger", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Fornavn", firstname));
                        cmd.Parameters.Add(new SqlParameter("@Efternavn", lastname));
                        cmd.Parameters.Add(new SqlParameter("@MedarbejderNr", employeeNo));

                        Console.Clear();

                        Console.WriteLine("Medarbejder slettet! \n");

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Tryk 'Enter' for at fortsætte");
                        var input = Console.ReadKey(true).Key;

                        Menu menu = new Menu();
                        switch (input)
                        {
                            case ConsoleKey.Enter: con.Close(); menu.ShowMenu(departmentID); break;

                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Dårligt lavet.." + e.Message + "\n");
                    }
                }
            }
            else
            {

                Menu menu = new Menu();
                menu.ShowMenu(departmentID);
            }
        }

        public void ChangePassword(int id, string username, string password, int departmentID)
        {
            Menu menu = new Menu();
            Login l = new Login();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SkiftPassword", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast Nyt Password \n");
                    cmd.Parameters.Add(new SqlParameter("@Password", Console.ReadLine()));
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    l.Login1();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("UPS S S S S " + e.Message);
                }
            }
        }

    }
}