﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;


namespace LogicUniv1._1.webpage.deptEmpRep
{
    public partial class DepEmpHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User userbean = (User)Session["UserEntity"];

            rep.Text = "Hello," + userbean.Name;
        }
    }
}