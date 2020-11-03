using Terraria.ID;
using Terraria.ModLoader;

namespace TPUG.Items
{
	public class LiquidERROR: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pure ERROR"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is an ERROR. please contact the developer if you wish to not have Pure ERROR");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
		}
	}
}