using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GettingRealNew
{
    public class Login
    {
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";

        private int Login_ID;
        public int login_return;
        public void Login1()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    SqlCommand cmd = new SqlCommand("spLogin", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Indtast Brugernavn \n");
                    string Username = Console.ReadLine();
                    Console.WriteLine("\nIndtast Kodeord \n");
                    string Password = Console.ReadLine();


                    cmd.Parameters.Add(new SqlParameter("@Brugernavn", Username));
                    cmd.Parameters.Add(new SqlParameter("@Password", Password));
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string ID = reader["AfdelingsID"].ToString();
                            string Username2 = reader["Brugernavn"].ToString();
                            string Password2 = reader["Password"].ToString();
                            string LoginString = reader["id"].ToString();
                            Login_ID = int.Parse(LoginString);
                            if (Username == Username2 && Password == Password2)
                            {
                                int departmentID = int.Parse(ID);
                                //returned ID
                                Menu menu = new Menu();
                                menu.Id = Login_ID;
                                menu.Password = Password;
                                menu.Username = Username;
                                menu.ShowMenu(departmentID);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Forkert Brugernavn/Password \n");
                        Console.WriteLine("Tryk 'Enter' for at fortsætte");
                        Console.ReadKey();
                        Console.Clear();
                        Login1();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                }

            }
        }
    }
}
