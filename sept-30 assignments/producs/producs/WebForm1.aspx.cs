using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace producs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c=new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=kannan;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie=null;
            cookie = Request.Cookies.Get("prodData");
            Products p2 = new Products();
            p2.Prodid = Convert.ToInt32(cookie["pid"]);
            p2.ProdName = cookie["pname"].ToString();
            p2.Price = Convert.ToInt32(cookie["price"]);

            ListBox1.Items.Add(p2.Prodid + " " + p2.ProdName + " " + p2.Price);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid.Text);
            p.ProdName = txtprodname.Text;
            p.Price = Convert.ToInt32(txtprice.Text);


            HttpCookie cookie = new HttpCookie("prodData");
            cookie.Expires = DateTime.Now.AddMinutes(10);


            cookie.Values.Add("pid", p.Prodid.ToString());
            cookie.Values.Add("pname", p.ProdName);
            cookie.Values.Add("price", p.Price.ToString());
            Response.Cookies.Add(cookie);
            Label1.Text = "cookies addede succesfully";

           // Response.Redirect("~/WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                  Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid.Text);
            p.ProdName = txtprodname.Text;
            p.Price = Convert.ToInt32(txtprice.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into products values('"+p.Prodid+"','"+p.ProdName+"','"+p.Price+"')",c);
            cmd.ExecuteNonQuery();
            lbl.Text = "record added succesfully";
            
            c.Close(); 
        }

        
    }
}