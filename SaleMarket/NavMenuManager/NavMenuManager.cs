using System;

namespace SaleMarket.NavMenuManager
{
	public enum NavMenuButton
	{
		Cart = 5,
		Discount = 4,
		Home = 3,
		Login = 2,
		Burger
	}

// CONSTANT strings URL used for navigation


	
	
	public class NavMenuManager
	{
		public NavMenuButton SelectedButton { get; private set; }
		public string ButtonColor { get; private set; }
		

		
		public NavMenuManager()
		{
			SelectedButton = NavMenuButton.Home;
			ButtonColor = "green";

			Console.WriteLine("NavMenuManager created with color: " + ButtonColor);
		}

		public void SetButtonColor(NavMenuButton button, string color)
		{
			SelectedButton = button;
			ButtonColor = color;

			Console.WriteLine($"NavMenuManager updated to Button: {SelectedButton}, Color: {ButtonColor}");
		}

		public void ResetToDefault()
		{
			SelectedButton = NavMenuButton.Home;
			ButtonColor = "green";
			Console.WriteLine("NavMenuManager reset to default.");
		}
	}
}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SaleMarket.Shared.Classes;
//using SaleMarket.Shared.NavMenuManager;

//namespace SaleMarket.Shared.NavMenuManager
//{

//	public enum NavMenuButton
//	{
//		Cart = 5,
//		Discount= 4,   
//		Home = 3,               
//		Login = 2,        
//		Burger        
//	}

//	public  class NavMenuManager
//	{

//		private NavMenuButton SelectedButton;
//		private string ButtonColor;


//		public NavMenuManager()
//		{
//			//SelectedButton = NavMenuButton.Home;
//			//ButtonColor = "green";

//			Console.WriteLine("NavMenuManager created witch color: " + ButtonColor);

//		}



//		public void SetButtonColor(NavMenuButton button, string color)
//		{
//			SelectedButton = button;
//			ButtonColor = color;

//			Console.WriteLine("NavMenuManager SetButtonColor: " + ButtonColor);
//		}

//		public string GetButtonColor()
//		{
//			Console.WriteLine("NavMenuManager GetButtonColor: " + ButtonColor);
//			return ButtonColor;
//		}

//		public NavMenuButton GetSelectedButton()
//		{
//			Console.WriteLine("NavMenuManager GetSelectedButton: " + SelectedButton);
//			return SelectedButton;
//		}





//	}
//}
