using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public static string global_var2 = "";
        public static string global_var3 = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            txt_date.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("IdNumberList.txt");

            txt_enumerator.Text = File.ReadAllText("EnumeratorName.txt");

            foreach (string line in lines)
            {
                cbox_idnum.Items.Add(line);
            }

            cbox_validity.SelectedIndex = 0;
            cbox_species.SelectedIndex = 0;
            //MessageBox.Show(MainForm.global_var1);

            string[] str = MainForm.global_var1.Split('&');
            if (str.Length != 22) { return; }
            txt_boatid.Text = str[0];
            txt_fishid.Text = str[1];
            txt_lat.Text = str[2];
            txt_lng.Text = str[3];
            txt_date.Text = str[4];
            txt_weit.Text = str[5];
            cbox_species.Text = str[6];
            cbox_validity.Text = str[7];
            txt_boatCap.Text = str[8];
            txt_boatName.Text = str[9];
            txt_LicId.Text = str[10];
            txt_locattion.Text = str[11];
            cbox_idnum.Text = str[12];
            txt_departTime.Text = str[13];
            txt_arrivTime.Text = str[14];
            txt_supplier.Text = str[15];
            txt_tagId.Text = str[16];
            txt_classification.Text = str[17];
            txt_enumerator.Text = str[18];
            txt_processor.Text = str[19];
            txt_fairTradeTagId.Text = str[20];
            chkbox_certified.Checked = str[21] == "Yes"? true:false;

            if (global_var3 == "save")
            {
                txt_classification.Clear();
                txt_weit.Clear();
                txt_tagId.Clear();
            }

            //if (str.Length != 22) { return; }
            //txt_boatid.Text = str[0];
            //txt_fishid.Text = str[1];
            //string[] loc = str[2].Split(' ');
            //txt_lat.Text = loc[0];
            //txt_lng.Text = loc[1];
            //txt_date.Text = str[3];  //19413213414
            //txt_boatCap.Text = str[4]; //-----------------------
            //txt_boatName.Text = str[5];
            //txt_LicId.Text = str[6];
            //txt_locattion.Text = str[7];


            ////if (global_var3 == "edit")
            ////{

            //    txt_weit.Text = str[4];
            //    txt_size.Text = str[5];
            //    cbox_species.Text = str[5];
            //    txt_size.Text = str[6];
            //    txt_boatCap.Text = str[7];
            //    txt_boatName.Text = str[8];
            //    txt_LicId.Text = str[9];
            //    txt_locattion.Text = str[10];
            //    cbox_idnum.Text = str[11];
            //    txt_departTime.Text = str[12];
            //    txt_arrivTime.Text = str[13];
            //    txt_supplier.Text = str[14];
            //    txt_tagId.Text = str[15];
            //    txt_classification.Text = str[16];
            //    txt_enumerator.Text = str[17];
            //    txt_processor.Text = str[18];
            //    txt_fairTradeTagId.Text = str[19];
            //    chkbox_certified.Checked = str[20] == "Yes"? true : false;

            ////}

        }

        private void txt_weit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void txt_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }
        
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (cbox_validity.Text.Trim() != "" && txt_weit.Text.Trim() != "" && cbox_idnum.Text.Trim() != "")
            {
                string boatid = txt_boatid.Text;
                string fishid = txt_fishid.Text;
                string lat = txt_lat.Text;
                string lng = txt_lng.Text;
                string date = txt_date.Text;
                string weit = txt_weit.Text;
                string validity = cbox_validity.Text;
                string cap = txt_boatCap.Text;
                string botname = txt_boatName.Text;
                string license = txt_LicId.Text;
                string locationz = txt_locattion.Text;
                string species = cbox_species.Text;
                string idno = cbox_idnum.Text;
                string departureTime = txt_departTime.Text;
                string arrivalTime = txt_arrivTime.Text;
                string supplier = txt_supplier.Text;
                string tagId = txt_tagId.Text;
                string classification = txt_classification.Text;
                string enumeratorName = txt_enumerator.Text;
                string processor = txt_processor.Text;
                string fairTradeTagId = txt_fairTradeTagId.Text;
                string certified = chkbox_certified.Checked == true? "Yes" : "No";

                global_var2 = boatid + "&" + 
                              fishid + "&" + 
                              lat + "&" +
                              lng + "&" +
                              date + "&" +
                              weit + "&" +
                              species + "&" +
                              validity + "&" +
                              cap + "&" +
                              botname + "&" +
                              license + "&" +
                              locationz + "&" +
                              idno + "&" + 
                              departureTime + "&" + 
                              arrivalTime + "&" +
                              supplier + "&" +
                              tagId + "&" +
                              classification + "&" +
                              enumeratorName + "&" +
                              processor + "&" +
                              fairTradeTagId + "&" +
                              certified; 

                if (global_var3 == "edit") //
                {
                    global_var3 = "edit";
                }
                else
                {
                    MainForm.global_var1 = global_var2;
                    global_var3 = "save";
                }

                int chkz = 0;

                for (int i = 0; i < cbox_idnum.Items.Count; i++)
                {
                    if (cbox_idnum.Text.Trim() == cbox_idnum.GetItemText(cbox_idnum.Items[i]))
                    {
                        chkz = 1;
                    }
                }
                if (chkz == 0)
                {
                    string notepad_append = cbox_idnum.Text;
                    StreamWriter log = File.AppendText("IdNumberList.txt");
                    log.WriteLine(notepad_append);
                    log.Close();
                }

                chkz = 0;

                if (chkBox_rememberEnumerator.Checked)
                {
                    File.WriteAllText("EnumeratorName.txt", enumeratorName);
                }

                this.Close();
            }
            else
            {

                if (txt_weit.Text.Trim() == "")
                {
                    txt_weit.BackColor = Color.Yellow;
                }
                else
                {
                    txt_weit.BackColor = Color.White;
                }
                if (cbox_idnum.Text.Trim() == "")
                {
                    cbox_idnum.BackColor = Color.Yellow;
                }
                else
                {
                    cbox_idnum.BackColor = Color.White;
                }
                MessageBox.Show("Please fill-up the Yellow Box. Required !!");
             
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            global_var3 = "cancel";
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void link_select_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             new FormAddCaptain().ShowDialog();
           
        }
    }
}
