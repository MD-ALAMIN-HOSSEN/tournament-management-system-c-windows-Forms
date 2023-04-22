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
    public partial class PlayerDash : Form
    {
        public static string user = "not data for user";
        sqlConnectionClass x = new sqlConnectionClass();
        public static int Id = 2000;
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        public PlayerDash(string a,int x)
        {
            InitializeComponent();
            user = a;
            Id = x;
            //MessageBox.Show(Id.ToString());
            //MessageBox.Show(user);
        }
        public PlayerDash(string a)
        {
            InitializeComponent();
            user = a;
           // Id = x.get_player_id(a);
           // MessageBox.Show(Id.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createteam_Click(object sender, EventArgs e)
        {
            Create_team forme = new Create_team();
            forme.Show();
        }

        private void PlayerDash_Load(object sender, EventArgs e)
        {

        }

        private void profile_icon_Click(object sender, EventArgs e)
        {
            update_profile forme = new update_profile(user);
            forme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
