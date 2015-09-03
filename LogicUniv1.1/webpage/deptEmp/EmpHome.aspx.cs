using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;

namespace LogicUnivTeam7.webpage.DeptHead
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            User userbean = (User)Session["UserEntity"];

            emp.Text = "Hello," + userbean.Name;

        }
    }
}