using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace TestingDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn;
                
                try
                {
                   conn = new SqlConnection(Connector.ConnString("C:\\Users\\Graphics\\Documents\\Software_Development\\C#Practises\\TestingDB\\TestingDB\\"));

                    
                    string sQuery = "SELECT * FROM [Table] WHERE Id = '" + 1 + "';";
                    List < message > list= new List<message>();

                    try
                    {
                       list = conn.Query<message>(sQuery).ToList();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error Message: " + ex);
                    }
                   
                   MessageBox.Show("It worked for Ghune, Message from DB: " + list[0].text );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable To connet to ghune database " + ex);
                    try
                    {
                        conn = new SqlConnection(Connector.ConnString("C:\\Users\\Graphics\\Documents\\Software_Development\\C#Practises\\TestingDB\\TestingDB\\"));
                        
                        MessageBox.Show("It worked for shwan");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            conn = new SqlConnection(Connector.ConnString("C:\\Users\\Graphics\\Documents\\Software_Development\\C#Practises\\TestingDB\\TestingDB\\"));
                            
                            MessageBox.Show("It worked for james");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Unable To connet to either of the databases");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}