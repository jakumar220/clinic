using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using Npgsql;

namespace Przychodnia
{




    public partial class Form1 : Form
    {

        public static string logindalej;
        public static string roladalej;

        private readonly static string Host = "ec2-34-249-49-9.eu-west-1.compute.amazonaws.com";
        private readonly static string User = "ankrxqeujmqvzi";
        private readonly static string DBname = "d7fhe39d8c4j5d";
        private readonly static string Password = "0eb8e4dfb3f7e8b99fe142d6bd002be70865b9fcf78e9d0038ca9f74532b7130";
        private readonly static string Port = "5432";

        static readonly string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4}",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        public Form1()
        {
            InitializeComponent();
        }

       
       
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams 
        {
            get 
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            
            }
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loginhelp.Visible = false;
            this.warn1.Visible = false;
            this.passhelp.Visible = false;
            this.warn2.Visible = false;
            this.warn3.Visible = false;
            this.loginfailedcomm.Visible = false;

           string login = textBox1.Text;
            logindalej = login;
            string haslo = textBox2.Text;

            if (textBox1.Text.Length == 0)
            {
                this.loginhelp.Visible = true;
                this.warn1.Visible = true;
                this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
            else 
            {
                if (textBox2.Text.Length == 0)
                {
                    this.passhelp.Visible = true;
                    this.warn2.Visible = true;
                    this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

                }
                else //tu proba zalogowania
                {

                    var conn = new NpgsqlConnection(connString);
                    conn.Open();

                   

                    NpgsqlCommand comm = new NpgsqlCommand();
                    NpgsqlCommand comm2 = new NpgsqlCommand();
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = $"select rola from public.users where username ='{login}' and passwd ='{haslo}'";
                    comm2.Connection = conn;
                    comm2.CommandType = CommandType.Text;
                    comm2.CommandText = $"select aktywny from public.users where username ='{login}' and passwd ='{haslo}'";
                    string odczytanarola = (string)comm.ExecuteScalar();
                    bool odczytystatus;

                     roladalej = odczytanarola;
                    // NpgsqlDataReader dr = comm.ExecuteReader();


                    

                    if (odczytanarola != null)
                    {
                        this.warn3.Visible = false ;
                        this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        odczytystatus = (bool)comm2.ExecuteScalar();

                        if (odczytystatus == true)
                        {
                            this.labelcomminactive.Visible = false;
                           
                            if (odczytanarola == "lekarz")
                            {
                                this.Hide();
                                oknolekarz11 f2 = new oknolekarz11();
                                f2.ShowDialog();
                            }
                            if (odczytanarola == "rejestracja")
                            {
                                this.Hide();
                                oknorejestracja11 f3 = new oknorejestracja11();
                                f3.ShowDialog();
                            }
                            if (odczytanarola == "laborant")
                            {
                                this.Hide();
                                oknolaborant1 f4 = new oknolaborant1();
                                f4.ShowDialog();
                            }
                            if (odczytanarola == "kierownik_laboratorium")
                            {
                                this.Hide();
                                oknokierownik1 f5 = new oknokierownik1();
                                f5.ShowDialog();
                            }
                            if (odczytanarola == "administrator")
                            {
                                this.Hide();
                                oknoadmin1 f6 = new oknoadmin1();
                                f6.ShowDialog();
                            }
                        }
                        if (odczytystatus == false)
                        {
                            this.labelcomminactive.Visible = true;
                            this.warn3.Visible = true;
                        }

                        

                    

                    }

                    else 
                    {
                        odczytystatus = false;
                        this.warn3.Visible = true;
                        this.loginfailedcomm.Visible = true;
                        this.textBox2.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                        this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));


                    }


                    //wyswietlanie w gridzie wynikow zapytania
                    // if (dr.HasRows)
                    // {
                    //    DataTable dt = new DataTable();
                    //    dt.Load(dr);
                    //    dataGridView1.DataSource = dt;
                    // }

                    comm.Dispose();
                    comm2.Dispose();

                }

            }

           

            
        }

        private void button1_Hover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
        }

        private void loginhelp_Click(object sender, EventArgs e)
        {

        }

        private void loginfailedcomm_Click(object sender, EventArgs e)
        {

        }

        private void passhelp_Click(object sender, EventArgs e)
        {

        }

        private void warn3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterclick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}