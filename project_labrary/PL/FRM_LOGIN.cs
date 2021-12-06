using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project_labrary.PL
{
    public partial class FRM_LOGIN : Form
    {
        
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USERS CLSUSER = new BL.CLS_USERS();
                DataTable dt = new DataTable();
                dt = CLSUSER.login(txt_user.Text, txt_password.Text);
                if (dt.Rows.Count > 0)
                {
                    CLSUSER.upadteLOGIN(txt_user.Text, txt_password.Text);
                    PL.FRM_MAIN frmmain = new FRM_MAIN();
                    object lbname = dt.Rows[0]["CNAME"];
                    object lbprem = dt.Rows[0]["CPREM"];
                    frmmain.lb_name.Text = lbname.ToString();
                    frmmain.lb_prem.Text = lbprem.ToString();
                    frmmain.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا في معلومات تسجيل الدخول");
                //MessageBox.Show();

            }
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
           
        }

        private void FRM_LOGIN_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
