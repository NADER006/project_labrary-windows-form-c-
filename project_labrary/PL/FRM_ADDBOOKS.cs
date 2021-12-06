using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_labrary.PL
{
    
    public partial class FRM_ADDBOOKS : Form
    {
        public int ID;

        public FRM_ADDBOOKS()
        {
            InitializeComponent();
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                DataTable dt = new DataTable();
                dt = BLBOOKS.LOADCAT();
                object[] obj = new object[dt.Rows.Count];
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    obj[i] = dt.Rows[i]["CAT_NAME"];
                }
                comboBox1.Items.AddRange(obj);

            }
            catch { }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                //cover.Image = Image.FromFile(OFD.FileName);
                cover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "اضافة";
                FCAT.id = 0;
                FCAT.Show();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "" || txt_auther.Text == "" || txt_price.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.ShowDialog();
            }
            else
            {
                MemoryStream ma = new MemoryStream();
                cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);

                if (ID == 0)
                {
                    //ADD
                    BL.CLS_BOOKS BLCAT = new BL.CLS_BOOKS();
                    BLCAT.Insert(txt_title.Text, txt_auther.Text, comboBox1.Text, txt_price.Text, txt_date.Value.ToString(), ma, txt_rate.Value);    //  pass ma replace cover
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else
                {
                    // edit 
                    MemoryStream maa = new MemoryStream();
                    cover.Image.Save(maa, System.Drawing.Imaging.ImageFormat.Jpeg);

                    BL.CLS_BOOKS BLCAT = new BL.CLS_BOOKS();
                    BLCAT.update(txt_title.Text, txt_auther.Text, comboBox1.Text, txt_price.Text, txt_date.Value.ToString(), maa, txt_rate.Value, ID);
                    PL.FRM_DEDIT fEDIT = new FRM_DEDIT();
                    fEDIT.Show();
                    this.Close();
                }


            }
           
        }
    }
}
