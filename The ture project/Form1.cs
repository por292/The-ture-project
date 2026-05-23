using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_ture_project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Orders());
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShowScreen(new HomePage());
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {
           ShowScreen(new UCProducts());
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ShowScreen(new Checkout());
        }
        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
          
           /* Console.WriteLine(textBox1.Text); */
            bool passcheck = CheckPasswordNew(textBox1.Text, textBox2.Text);
            if (passcheck)
            {
                MessageBox.Show("Password is correct");
                button1.Enabled = true;
                button2.Enabled = true;
                button7.Enabled = true;
                BuildandEdit.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Password is or Username incorrect");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static bool CheckPasswordNew(string inputPass, string inputUsername)
        {
            /*string json = @"[
          { ""id"": 1, ""username"": ""alex_starling99"", ""password"": ""Tr!$7#qP29"" },
          { ""id"": 2, ""username"": ""bruce_lee_88"", ""password"": ""P@ssw0rd!_88"" },
          { ""id"": 3, ""username"": ""morgan_dev_2026"", ""password"": ""C0d!ng$tr0ng!&"" }
        ]";*/
            var jsonPath = Path.Combine(AppContext.BaseDirectory, "PasswordManager.json"); // file placed in output
            string json = File.ReadAllText(jsonPath);
            var obj = JsonSerializer.Deserialize<List<Account>>(json);

            var accounts = JsonSerializer.Deserialize<List<Account>>(json);

            foreach (var acc in accounts)
            {
                //Console.WriteLine($"ID: {acc.id}, Username: {acc.username}, Password: {acc.password}");
                if (acc.password == inputPass && acc.username == inputUsername)
                {
                    Console.WriteLine("Found good password & username");
                    return true;
                }
            }
            return false;
        }


        /*static bool CheckPassword(string input, int minimum)
        {
            bool hasNum = false;
            bool hasCap = false;
            bool hasLow = false;
            bool hasSpec = false;
            char currentCharacter;
            string thepass = "MrAnjunisthebest1!";

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
                if (input == thepass) { return true; } else { return false; }
            }
            else
            {
                return false;
            }
           
        }*/

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Clear();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
                
            }
            else 
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
