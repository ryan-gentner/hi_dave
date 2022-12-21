using System;
using System.Collections.Generic;
using System.Linq;


namespace CINQA
{
		public class InventoryPurchase
	{

		/* this is a code for dave to see ;) */
		
		public int InventoryPurchaseID { get; set; }
		public int InventoryItemID { get; set; }
		public string InventoryItemName { get; set; }
		public string InventoryItemDescription { get; set; }
		public decimal InventoryItemCost { get; set; }
		public int InventoryPurchaseQuantity { get; set; }
		public int InventoryBuyerID { get; set; }
	}

	class Program
    {
			public static List<InventoryPurchase> LoadInventory()
	{
		List<InventoryPurchase> InventoryPurchaseList = new List<InventoryPurchase>();
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 1, InventoryItemID = 3, InventoryItemName = "Shirt", InventoryItemDescription = "Shirt", InventoryBuyerID = 2, InventoryItemCost = 13.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 2, InventoryItemID = 3, InventoryItemName = "Shirt", InventoryItemDescription = "Shirt", InventoryBuyerID = 3, InventoryItemCost = 13.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 3, InventoryItemID = 12, InventoryItemName = "Dinner Jacket", InventoryItemDescription = "Dinner Jacket", InventoryBuyerID = 3, InventoryItemCost = 77.63M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 4, InventoryItemID = 14, InventoryItemName = "Cufflinks", InventoryItemDescription = "Cufflinks", InventoryBuyerID = 2, InventoryItemCost = 8.74M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 5, InventoryItemID = 73, InventoryItemName = "Nightgown", InventoryItemDescription = "Nightgown", InventoryBuyerID = 1, InventoryItemCost = 1.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 6, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 6, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 2 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 7, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 5, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 4 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 8, InventoryItemID = 1, InventoryItemName = "Misc Adjustment", InventoryItemDescription = "Misc Adjustment", InventoryBuyerID = 4, InventoryItemCost = 0.3M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 9, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 4, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 10, InventoryItemID = 14, InventoryItemName = "Cufflinks", InventoryItemDescription = "Cufflinks", InventoryBuyerID = 5, InventoryItemCost = 12.99M, InventoryPurchaseQuantity = 5 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 11, InventoryItemID = 54, InventoryItemName = "Winter Gloves4", InventoryItemDescription = "Winter Gloves4", InventoryBuyerID = 5, InventoryItemCost = 13.99M, InventoryPurchaseQuantity = 3 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 12, InventoryItemID = 65, InventoryItemName = "Sweatshirt", InventoryItemDescription = "Sweatshirt", InventoryBuyerID = 6, InventoryItemCost = 64.33M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 13, InventoryItemID = 6, InventoryItemName = "Slippers", InventoryItemDescription = "Slippers", InventoryBuyerID = 1, InventoryItemCost = 4.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 14, InventoryItemID = 98, InventoryItemName = "Cardigan", InventoryItemDescription = "Cardigan", InventoryBuyerID = 2, InventoryItemCost = 22.74M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 15, InventoryItemID = 32, InventoryItemName = "Shirt", InventoryItemDescription = "Shirt", InventoryBuyerID = 3, InventoryItemCost = 32.9M, InventoryPurchaseQuantity = 4 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 16, InventoryItemID = 6, InventoryItemName = "Slippers", InventoryItemDescription = "Slippers", InventoryBuyerID = 3, InventoryItemCost = 4.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 17, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 3, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 3 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 18, InventoryItemID = 6, InventoryItemName = "Slippers", InventoryItemDescription = "Slippers", InventoryBuyerID = 1, InventoryItemCost = 4.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 19, InventoryItemID = 9, InventoryItemName = "Cardigan", InventoryItemDescription = "Cardigan", InventoryBuyerID = 7, InventoryItemCost = 22.74M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 20, InventoryItemID = 56, InventoryItemName = "Winter Gloves6", InventoryItemDescription = "Winter Gloves6", InventoryBuyerID = 8, InventoryItemCost = 33.11M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 21, InventoryItemID = 6, InventoryItemName = "Slippers", InventoryItemDescription = "Slippers", InventoryBuyerID = 9, InventoryItemCost = 4.99M, InventoryPurchaseQuantity = 3 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 22, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 8, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 23, InventoryItemID = 5, InventoryItemName = "Winter Gloves", InventoryItemDescription = "Winter Gloves", InventoryBuyerID = 8, InventoryItemCost = 3.99M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 24, InventoryItemID = 6, InventoryItemName = "Slippers", InventoryItemDescription = "Slippers", InventoryBuyerID = 9, InventoryItemCost = 4.99M, InventoryPurchaseQuantity = 2 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 25, InventoryItemID = 65, InventoryItemName = "Sweatshirt", InventoryItemDescription = "Sweatshirt", InventoryBuyerID = 9, InventoryItemCost = 64.33M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 26, InventoryItemID = 45, InventoryItemName = "T-Shirt", InventoryItemDescription = "T-Shirt", InventoryBuyerID = 7, InventoryItemCost = 7.44M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 27, InventoryItemID = 12, InventoryItemName = "Dinner Jacket", InventoryItemDescription = "Dinner Jacket", InventoryBuyerID = 4, InventoryItemCost = 77.63M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 28, InventoryItemID = 8, InventoryItemName = "Skirt", InventoryItemDescription = "Skirt", InventoryBuyerID = 5, InventoryItemCost = 8.13M, InventoryPurchaseQuantity = 2 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 29, InventoryItemID = 12, InventoryItemName = "Dinner Jacket", InventoryItemDescription = "Dinner Jacket", InventoryBuyerID = 2, InventoryItemCost = 77.63M, InventoryPurchaseQuantity = 1 });
		InventoryPurchaseList.Add(new InventoryPurchase() { InventoryPurchaseID = 30, InventoryItemID = 10, InventoryItemName = "Robe", InventoryItemDescription = "Robe", InventoryBuyerID = 1, InventoryItemCost = 1.75M, InventoryPurchaseQuantity = 1 });
		return InventoryPurchaseList;
	}

        static void Main(string[] args)
        {
			List<InventoryPurchase> Purchases = LoadInventory();

			decimal highest = 0;
			InventoryPurchase highest_purch = null;
			decimal total_sales = 0;
			Dictionary<int, decimal> buyer_total = new Dictionary<int, decimal>();

            foreach (InventoryPurchase item in Purchases)
            {
				decimal item_purchase = item.InventoryItemCost * item.InventoryPurchaseQuantity;
				total_sales += item.InventoryItemCost * item.InventoryPurchaseQuantity;
				if (item_purchase > highest)
                {
					highest = item_purchase;
					highest_purch = item;
                }
				if (buyer_total.ContainsKey(item.InventoryBuyerID) == false)
				buyer_total[item.InventoryBuyerID] = 0;
				
				buyer_total[item.InventoryBuyerID] += item_purchase;

				Console.WriteLine("{0} {1} {2} {3}",
					item.InventoryItemDescription.PadRight(30),
					item.InventoryItemCost.ToString().PadRight(30),
					item.InventoryPurchaseQuantity.ToString().PadRight(30),
					item_purchase);
            }

			//1. Find the most expensive item purchase
			Console.WriteLine("1. Most expensive item purchase was {0},{1},{2},{3},{4}",
				highest_purch.InventoryBuyerID,
				highest_purch.InventoryItemDescription,
				highest_purch.InventoryItemCost,
				highest_purch.InventoryPurchaseQuantity, highest);

			//2. Calculate our total sales
			Console.WriteLine("2. Total sales: {0:C}", total_sales);

			//3. What buyer is buying from us the most
			int buyer_id = buyer_total.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
			Console.WriteLine("3. Buyer ID who is buying from us the most: {0}", buyer_id);

			//4. Can you think of another way to answer these requests?
			Console.WriteLine("4. Could have put the data in a text file or a database.");
			Console.WriteLine("   Also, probably could have done more with Linq statements but I am less familiar with Linq.");

		}
	}
}

public class Inventory
{
	//get Inventory
	//List<InventoryPurchase> Purchases = LoadInventory();

	//Given the small subset of data - write code that will:
	//1. Find the most expensive item purchase
	//2. Calculate our total sales
	//3. What buyer is buying from us the most
	//4. Can you think of another way to answer these requests?
}
