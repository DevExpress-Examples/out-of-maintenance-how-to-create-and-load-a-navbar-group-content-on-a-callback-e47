<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [UserControl.ascx](./CS/WebSite/UserControl.ascx) (VB: [UserControl.ascx](./VB/WebSite/UserControl.ascx))
* [UserControl.ascx.cs](./CS/WebSite/UserControl.ascx.cs) (VB: [UserControl.ascx.vb](./VB/WebSite/UserControl.ascx.vb))
<!-- default file list end -->
# How to create and load a NavBar group content on a callback


<p>This sample demonstrates how to create and load a NavBar group content on a callback. This allows you to reduce Page_Load time on the server, because content hierarchy won't be created for collapsed groups. However, this approach implies some restrictions. For example, input values for a dynamically created group content will be unavailable on postbacks.</p>

<br/>


