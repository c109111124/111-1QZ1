using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ1
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_MIndex = new int[10] {0, 7, 13, 28, 44, 62, 74, 75, 87, 90};
            char[,] ia_Map = new char[10, 10];
            for (int Row = 0; Row < 10; Row++)
            {
                for(int Col = 0; Col < 10; Col++)
                {
                    ia_Map[Row, Col] = '0';
                }
            }
            for (int Ct = 0; Ct < 10; Ct++)
            {
                int Row = ia_MIndex[Ct] / 10;
                int Col = ia_MIndex[Ct] % 10;
                ia_Map[Row, Col] = '*';
            }           
            for (int Row = 0; Row < 10; Row++)
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    Response.Write(ia_Map[Row, Col]);
                }
                Response.Write("<br />");
            }
        }
    }
}