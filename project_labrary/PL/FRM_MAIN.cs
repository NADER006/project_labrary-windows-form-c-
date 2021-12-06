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
    public partial class FRM_MAIN : Form
    {
        string state;
       // int ID;

        //Instance for CAT 
        BL.CLS_CAT BLCAT= new BL.CLS_CAT();
        //Instance Of BOOKS
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        //Instance OF USERS
        BL.CLS_USERS BLUSER = new BL.CLS_USERS();

        
        public FRM_MAIN()
        {
            
            InitializeComponent();
           
        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width == 200)
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                P_MB.Width = 200;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
                button7.RightToLeft = RightToLeft.No;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = false;
            txt_search.Visible=true;
            state = "CAT";
            Lb_Title.Text = "الأصناف";
            //load Data =====================================================
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الصنف";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)            
        {
       
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسة";

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Add catagegory======================================================= 

            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "اضافة";
                FCAT.id = 0;
                bunifuTransition1.ShowSync(FCAT);
            }
            // Add books ======================================================= 

            if (state == "BOOKS")
            {
                PL.FRM_ADDBOOKS FBOOKS = new FRM_ADDBOOKS();
                FBOOKS.btnadd.ButtonText = "اضافة";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);
            }
            //Add USER ==============================================================
            if (state == "USER")
            {
                PL.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                FUSER.btnadd.ButtonText = "اضافة";
                FUSER.ID= 0;
                bunifuTransition1.ShowSync(FUSER);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //add category 
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.Show();

            }

        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {

          
            
            //For Check Number
            //Book
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.load();
                lb_books.Text = dt.Rows.Count.ToString();


            }
            catch { }
            //User
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                lb_user.Text = dt.Rows.Count.ToString();


            }
            catch { }
            //CAT
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.load();
                lb_cat.Text = dt.Rows.Count.ToString();


            }
            catch { }

            ////                                                 إعطاء صلاحيات مختلفة للمستخدمين   ==================================
            ////   كمثال توضحي اسقطنا صلاحية الحذف لدى المستخدم العادي التي صلاحيته ليس مدير   ==================================
            if (lb_prem.Text == "مدير")
            {
                bunifuThinButton22.Enabled = true;
                bunifuThinButton23.Enabled = true;
                button6.Enabled = true;


            }
            else
            {
                bunifuThinButton22.Enabled = false;
                bunifuThinButton23.Enabled = false;
                button6.Enabled = false;
               

            }



            if (state == "CAT")
            {
                // load data category ==============================================
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الصنف";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "BOOKS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "BOOKS";
                Lb_Title.Text = "الكتب";
                //load Data =====================================================
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                    dataGridView1.Columns[2].HeaderText = "المؤلف";
                    dataGridView1.Columns[3].HeaderText = "التصنيف";
                    dataGridView1.Columns[4].HeaderText = "السعر";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (state == "user")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                // txt_serach.Visible = false;

                state = "USER";
                Lb_Title.Text = "المستخدمين";
                //Load Data================================================================================================
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSER.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الكامل";
                    dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
                    dataGridView1.Columns[3].HeaderText = "كلمة السر";
                    dataGridView1.Columns[4].HeaderText = "الصلاحية";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            // edit catagegory =================================================================================
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "تعديل";
                FCAT.txt_catname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);
            }

            //Edit Books============================================================================================
            else if (state == "BOOKS")
            {
                try
                {
                    PL.FRM_ADDBOOKS FBOOKS = new FRM_ADDBOOKS();
                    FBOOKS.btnadd.ButtonText = "تعديل";
                    FBOOKS.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["COVER"];
                    object obj7 = dt.Rows[0]["RATE"];
                    FBOOKS.txt_title.Text = obj1.ToString();
                    FBOOKS.txt_auther.Text = obj2.ToString();
                    FBOOKS.comboBox1.Text = obj3.ToString();
                    FBOOKS.txt_price.Text = obj4.ToString();
                            //FBOOKS.txt_date.Value = (DateTime)obj5;
                    FBOOKS.txt_date.Text = obj5.ToString(); ;
                            //FBOOKS.txt_rate.Value = (int)obj6;
                    //Load Image===============================
                    byte[] ob = (byte[])obj6;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOKS.cover.Image = Image.FromStream(ma);
                    FBOOKS.txt_rate.Value = (int)obj7;
                    bunifuTransition1.ShowSync(FBOOKS);
                   

                }
                catch { }

            }
            //Edit USER ============================================================================================
            else if (state == "USER")
            {
                try
                {
                    PL.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                    FUSER.btnadd.ButtonText = "تعديل";
                    FUSER.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    DataTable dt = new DataTable();
                    dt = BLUSER.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["CNAME"];
                    object obj2 = dt.Rows[0]["CUSER"];
                    object obj3 = dt.Rows[0]["CPASSWORD"];
                    object obj4 = dt.Rows[0]["CPREM"];
                   // object obj5 = dt.Rows[0]["CSTATE"];

                    FUSER.txt_name.Text = obj1.ToString();
                    FUSER.txt_user.Text = obj2.ToString();
                    FUSER.txt_password.Text = obj3.ToString();
                    FUSER.txt_prem.Text = obj4.ToString();
                    //FUSER.txt_price.Text = obj4.ToString();

                    bunifuTransition1.ShowSync(FUSER);

                }
                catch { }


            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Delete catagegory===============================================================
            if (state == "CAT")
            {
                BLCAT.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DELETE Edelete = new FRM_DELETE();
                Edelete.Show();
            }
            //DELETE BOOKS=============================================================================
            else if (state == "BOOKS")
            {
                BLBOOKS.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DELETE Fdelete = new FRM_DELETE();
                Fdelete.Show();
            }
            //DELETE USER==================================================================================
            else if (state == "USER")
            {
                BLUSER.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DELETE Fdelete = new FRM_DELETE();
                Fdelete.Show();
            }
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            // search catagegory======================================================= 

            if (state == "CAT")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.serach(txt_search.Text);
                dataGridView1.DataSource = dt;
            }
            // search BOOKS ======================================================= 
            if (state == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.serach(txt_search.Text);
                dataGridView1.DataSource = dt;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = true;
            txt_search.Visible = true;
            state = "BOOKS";
            Lb_Title.Text = "الكتب";
            //load Data =====================================================
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[2].HeaderText = "المؤلف";
                dataGridView1.Columns[3].HeaderText = "التصنيف";
                dataGridView1.Columns[4].HeaderText = "السعر";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //detailes of Books=====================================================================================================
            if (state == "BOOKS")
            {
                try
                {
                    //PL.FRM_ADDBOOKS FBOOKS = new FRM_ADDBOOKS();
                    //FBOOKS.btnadd.ButtonText = "تعديل";
                    //FBOOKS.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["COVER"];
                    object obj7 = dt.Rows[0]["RATE"];
                    PL.FRM_DETBOOKS DETBOOKS = new FRM_DETBOOKS();
                    DETBOOKS.txt_title.Text = obj1.ToString();
                    DETBOOKS.txt_auther.Text = obj2.ToString();
                    DETBOOKS.txt_cat.Text = obj3.ToString();
                    DETBOOKS.txt_price.Text = obj4.ToString();
                    //FBOOKS.txt_date.Value = (DateTime)obj5;
                    DETBOOKS.txt_date.Text = obj5.ToString(); ;
                    //FBOOKS.txt_rate.Value = (int)obj6;
                    //Load Image===============================
                    byte[] ob = (byte[])obj6;
                    MemoryStream ma = new MemoryStream(ob);
                    DETBOOKS.cover.Image = Image.FromStream(ma);
                    DETBOOKS.txt_rate.Value = (int)obj7;
                    bunifuTransition1.ShowSync(DETBOOKS);


                }
                catch { }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = false;
            txt_search.Visible = false;

            state = "USER";
            Lb_Title.Text = "المستخدمين";
            //Load Data================================================================================================
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الكامل";
                dataGridView1.Columns[2].HeaderText = "اسم المستخدم";
                dataGridView1.Columns[3].HeaderText = "كلمة السر";
                dataGridView1.Columns[4].HeaderText = "الصلاحية";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN Login = new FRM_LOGIN();
            BLUSER.logout();
            this.Hide();
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسة";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lb_prem_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Add catagegory======================================================= 

            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "اضافة";
                FCAT.id = 0;
                bunifuTransition1.ShowSync(FCAT);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Add books ======================================================= 

            if (state == "BOOKS")
            {
                PL.FRM_ADDBOOKS FBOOKS = new FRM_ADDBOOKS();
                FBOOKS.btnadd.ButtonText = "اضافة";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);
            }
        }
    }
}
