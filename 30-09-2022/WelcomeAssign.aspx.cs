﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using CustDAL;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class WelcomeAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
             cookie = Request.Cookies.Get("CustData");
            Customer c = new Customer();
            c.firstName = cookie["fName"];
            c.lastName = cookie["lName"];
            c.dob = DateTime.Parse(cookie["dob1"]);
            c.city = cookie["city1"];
            c.state = cookie["state1"];
            lblwelcome.Text = "Welcome " + c.firstName + " " + c.lastName;
          //  ListBox1.Items.Add("Welcome " + c.firstName + " " + c.lastName);
          //ListBox1.Items.Add(new ListItem { Text = "1", Value = "Welecome Anand" });

        }

      
    }
}