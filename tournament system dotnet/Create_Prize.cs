using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet
{
    public partial class Create_Prize : Form
    {
        prizeClass model = new prizeClass();
        public Create_Prize()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate_forme())/////////////////////////////////////////////
            {
                model.prizeName = prize_name_textbox.Text;               
                model.prizeNumber= int.Parse(prize_number_textbox.Text);
                model.prizeAmount = int.Parse(prize_amount_textbox.Text);//////////////////change to amount 

                Create_new_tournament.foem_Create_new_tournament.passPrize_object_to_tournament_forme( model);
                this.Close();
            }
        }
        bool Validate_forme()
        {
            bool output = true;
            if (String.IsNullOrEmpty(prize_name_textbox.Text))
            {             
               output = false;
            }
            if (String.IsNullOrEmpty(prize_number_textbox.Text))
            {
                output = false;
            }
            int number = 0;
            bool numberValidNumber = int.TryParse(prize_amount_textbox.Text, out number);
            if (numberValidNumber == false)
            {              
                output = false;
            }
            if (output == false)
            {
                MessageBox.Show("please fill all the fields. Prize number and Prize amount must be Integer Number");
            }
            return output;
        }
    }
}
