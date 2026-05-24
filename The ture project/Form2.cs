using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ture_project
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            User.Clear();
            Passtxt.Clear();
            Passtxt1.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Uname = User.Text;
            string Pass = Passtxt.Text;
            string Pass1 = Passtxt1.Text;
           // Console.Write(Uname + Pass + Pass1 + "\n");
           if (Uname.Length < 5 ) 
            {
                MessageBox.Show("Username needs to be more then 5 charecters");
                return;
            }
           if (Pass != Pass1)
            {
                MessageBox.Show("Passwords are not identical");
                return;
            }
           if (!CheckPassword(Pass, 6))
            {
                MessageBox.Show("Passwords does not contain: Num, Cap, Spec, or is shorter than 6 charecters");
                return;
            }
            var jsonPath = Path.Combine(AppContext.BaseDirectory, "PasswordManager.json"); // file placed in output
            string json = File.ReadAllText(jsonPath);
            var accounts = JsonSerializer.Deserialize<List<Account>>(json);
            int NewId = 0;
            foreach (var acc in accounts)
            {
                //Console.WriteLine($"ID: {acc.id}, Username: {acc.username}, Password: {acc.password}");
                if (acc.username == Uname)
                {
                    MessageBox.Show("User already exists");
                    return;
                }
                if (acc.id > NewId)
                {
                    NewId = acc.id + 1;

                }
            }
            
            var newItem = new Account { id = NewId, username = Uname, password = Pass };
            accounts.Add(newItem);
            string updatedJson = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });

            // Console.WriteLine(updatedJson);
            File.WriteAllText(jsonPath, updatedJson);
            MessageBox.Show("User has been registerd");
            this.Owner.Show();
            this.Close();

        }
        static bool CheckPassword(string input, int minimum)
        {
            bool hasNum = false;
            bool hasCap = false;
            bool hasLow = false;
            bool hasSpec = false;
            char currentCharacter;
            //string thepass = "MrAnjunisthebest1!";

            if(input.Length < minimum)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                currentCharacter = input[i];
                if (char.IsDigit(currentCharacter))
                {
                    hasNum = true;
                }
                else if (char.IsUpper(currentCharacter))
                {
                    hasCap = true;
                }
                else if (char.IsLower(currentCharacter))
                {
                    hasLow = true;
                }
                else if (!char.IsLetterOrDigit(currentCharacter))
                {
                    hasSpec = true;
                }
                
            }
            if (hasNum && hasCap && hasLow && hasSpec)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
      
    }
}
