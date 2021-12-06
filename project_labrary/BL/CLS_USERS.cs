using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace project_labrary.BL
{
    class CLS_USERS
    {
       

        DAL.CLS_DAL DAL = new project_labrary.DAL.CLS_DAL();
        //Load Data========================================================================================================
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PL_LOADUSER", pr);
            return dt;
        }

        // INSERT DATA====================================================================================================
        public void Insert(string CNAME, string CUSER, string CPASSWORD, string CPREM, string CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("CSTATE", CSTATE);
            DAL.open();
            DAL.excute("PR_INSERTUSER", pr);
            DAL.close();
        }

        // UPDATE DATA====================================================================================================
        public void update(string CNAME, string CUSER, string CPASSWORD, string CPREM, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.excute("PR_EDITUSER", pr);
            DAL.close();
        }
        //Load Data FOR EDIT =====================================================================================================
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELACTEDITUSER", pr);
            return dt;
        }
        //  delete data ====================================================================================================
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.excute("PR_DELETEUSER", pr);
            DAL.close();
        }
        // Logout  =========================================================================================================
        public void logout()
        {
            SqlParameter[] pr = null;
            DAL.open();
            DAL.excute("PR_LOGOUT", pr);
            DAL.close();
        }
        //Load Data for login ==============================================================================================

        public DataTable login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;
        }
        // UPDATE DATA FOR LOGIN==============================================================================================

        public void upadteLOGIN(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DAL.open();
            DAL.excute("PR_updatelogin", pr);
            DAL.close();
        }
    }
}
