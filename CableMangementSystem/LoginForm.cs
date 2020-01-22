﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CableMangementSystem
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            string username = UsernameTxtBox.Text;
            string password = PassTxtBox.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Username or Password cannot be empty");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                    conn.Open();

                    // verify col names 
                    SqlCommand cmdUser = new SqlCommand("VERIFY_USER", conn);
                    cmdUser.CommandType = CommandType.StoredProcedure;
                    cmdUser.Parameters.Add(new SqlParameter("@USER_EMAIL", username));

                    SqlCommand cmdStaff = new SqlCommand("VERIFY_STAFF", conn);
                    cmdStaff.CommandType = CommandType.StoredProcedure;
                    cmdStaff.Parameters.Add(new SqlParameter("@STAFF_EMAIL", username));

                    SqlDataReader reader;
                    SqlDataReader readerStaff;

                    string check = "";

                    reader = cmdUser.ExecuteReader();
                    while (reader.Read())
                    {
                        check = reader["USER_PASSWORD"].ToString();
                        break;
                    }


                    if (password == check)
                    {

                        UserForm user = new UserForm(username);
                        user.ShowDialog();
                        this.Dispose();
                        this.Close();
                        
                    }


                    check = "";
                    reader.Close();

                    // no user was found now check for staff members  
                    if (check == "")
                    {
                        
                        readerStaff = cmdStaff.ExecuteReader();
        
                        // checck for staff password 
                        while (readerStaff.Read())
                        {
                            check = readerStaff["STAFF_PASSWORD"].ToString();
                            break;
                        }

                         // password of staff member matches the entered password 
                        if (password == check)
                        {
                            StaffPortal sf = new StaffPortal();
                            sf.ShowDialog();
                            this.Close();
                        }

                        readerStaff.Close();
                    }

                    // no user or staff member found 
                    if(check == "")
                    {
                        UsernameTxtBox.Text = "";
                        PassTxtBox.Text = "";
                        MessageBox.Show("No User or Staff Member Found..");
                    }

                    else if (password != check)
                    {
                        MessageBox.Show("Email & Password does not match");
                        PassTxtBox.Text = "";
                        return; // user and password does not match 
                    }



                    conn.Close();


                } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            } 


       }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Close();
            this.Dispose();
            
        }
    }
}
