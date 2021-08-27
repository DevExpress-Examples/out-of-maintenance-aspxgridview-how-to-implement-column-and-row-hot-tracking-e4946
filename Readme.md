<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128534680/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4946)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to implement column and row hot tracking
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4946/)**
<!-- run online end -->


<p>ASPxGridView supports only row hot tracking. But, this mechanism will interfere with our column tracking approach, so we will implement our own row hot tracking.</p><p>First, we will need to handle the HtmlDataCellPrepared event:</p>

```cs
    protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e) {
        String colIdx = "col_idx_" + e.DataColumn.Index.ToString();
        String rowIdx = "row_idx_" + e.VisibleIndex.ToString();
        e.Cell.Attributes.Add("onmouseover", "OnCellOver(this, '" + colIdx + "', '" + rowIdx + "');");
        e.Cell.Attributes.Add("onmouseout", "OnCellOut(this, '" + colIdx + "', '" + rowIdx + "');");
        e.Cell.CssClass += " " + colIdx + " " + rowIdx;
    }

```

<p>Here we will add two DOM events for a cell element and pass its row and column identifiers to them. We are also assigning css classes here.<br />
Then, we will handle cell colors in JavaScript events. In this example, JQuery is used to get elements by a class name. However, it can be done using other methods. For example, you can get all elements by a tag name and then check their css classes to match our class.</p><br />


<br/>


