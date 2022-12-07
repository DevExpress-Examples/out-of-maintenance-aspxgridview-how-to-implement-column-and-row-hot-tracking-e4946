using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridViewTableDataCellEventArgs e) {
        String colIdx = "col_idx_" + e.DataColumn.Index.ToString();
        String rowIdx = "row_idx_" + e.VisibleIndex.ToString();
        e.Cell.Attributes.Add("onmouseover", "OnCellOver(this, '" + colIdx + "', '" + rowIdx + "');");
        e.Cell.Attributes.Add("onmouseout", "OnCellOut(this, '" + colIdx + "', '" + rowIdx + "');");
        e.Cell.CssClass += " " + colIdx + " " + rowIdx;
    }
}