using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using KYS.Models;

namespace KYS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; database = User; integrated security = SSPI;";
        }

        [HttpPost]
        public ActionResult Verify(User user)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from [User] where UserMail='"+user.UserMail+"' and UserPassword='"+user.UserPassword+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Index");
            }
            else
            {
                con.Close();
                return View("Index");
            }
        }
        public ActionResult Haberlesme()
        {
            return View();
        }
        public ActionResult Veri_Alisverisi()
        {
            return View();
        }
        public ActionResult Panels()
        {
            return View();
        }
        public ActionResult Izin_Talebi()
        {
            return View();
        }
    }
}