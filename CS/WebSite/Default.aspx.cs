using System;
using System.Collections.Generic;
using System.Linq;
 
using DevExpress.Web.ASPxMenu;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void ASPxMenu1_Load(object sender, EventArgs e) {
		ASPxMenu menu = sender as ASPxMenu;
		
		//Uncomment the following code to use it in a real application
		//CorrectItem(menu.RootItem);

		//The following code is used for the demo purpose only. Do not use it in a real scenario
		CorrectItem(menu.Items[1]);
	}

	private void CorrectItem(MenuItem item) {
		if (item == null)
			return;
		if (item.HasChildren) {
			item.NavigateUrl = null;
			foreach (MenuItem subItem in item.Items)
				CorrectItem(subItem);
		}
	}
}