using Terraria.ID;
using Terraria.ModLoader;

namespace TPUG.Items
{
	public class TheGreatestPlan: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Greatest Plan"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is The greatest plaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LiquidERROR>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}