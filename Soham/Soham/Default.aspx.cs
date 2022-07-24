using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soham
{
    public partial class Default : System.Web.UI.Page
    {
        //DAL.Class dalclass = new DAL.Class();
        DAL.Class soham = new DAL.Class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnContact_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                string email = txtemail.Text;
                //String phone = Convert.ToInt32(txtPhone.Text);
                //String phone = int.Parse(txtPhone.Text)ToString();
                //int phone = int.Parse(txtPhone.Text);

                int phone = Convert.ToInt32(txtPhone.Text);
                //string mobile = TextMobile.Text;

                int userid = soham.insertUserData(name, email, phone);
            }
            catch (Exception ex)
            {
                string msg;
                msg = ex.Message;

            }
        }
    }
}