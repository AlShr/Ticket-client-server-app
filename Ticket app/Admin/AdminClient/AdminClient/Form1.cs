using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl_SelectedIndexChanged(tabControl, EventArgs.Empty);
        }

        private void mAddCity_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity();

            if (addCity.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void mSeatState_Click(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbCity.Text == string.Empty) return;

            if (btOk.Text == "Добавить")
            {
                using (teamProject2022Entities le = new teamProject2022Entities())
                {
                    Cities city = new Cities()
                    {
                        city = tbCity.Text
                    };
                    le.Cities.Add(city);
                    le.SaveChanges();
                }
                tabControl_SelectedIndexChanged(tabControl, EventArgs.Empty);
            }

            else if (btOk.Text == "Удалить")
            {
                using (teamProject2022Entities le = new teamProject2022Entities())
                {
                    Cities c = le.Cities.FirstOrDefault(x => x.city.Equals(tbCity.Text, StringComparison.InvariantCultureIgnoreCase));
                    if (c != null)
                        le.Cities.Remove(c);
                    le.SaveChanges();
                }
                tabControl_SelectedIndexChanged(tabControl, EventArgs.Empty);
                tbCities.Text = "";
                btOk.Text = "Добавить";
            }


        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc.SelectedTab.Text == "Города")
            {
                lbCities.Items.Clear();
                using (teamProject2022Entities le = new teamProject2022Entities())
                {
                    Cities city = new Cities();
                    foreach (var ct in le.Cities)
                    {
                        lbCities.Items.Add(ct.city);
                    }         
                }
            }
        }

        private void lbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCities.SelectedIndex == -1) return;
            tbCity.Text = lbCities.SelectedItem.ToString();
            btOk.Text = "Удалить";

            
        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {
            
            if (tbCities.Text.Count() > 0)
            {
                lbCities.SelectedIndex = -1;
                btOk.Text = "Добавить";
            }
        }
    }
}
