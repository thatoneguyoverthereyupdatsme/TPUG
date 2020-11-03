using Terraria.ID;
using Terraria.ModLoader;

namespace TPUG.Items
{
	public class ERROR: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("ERROR"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is an ERROR. please contact the developer if you wish to not have ERROR");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("ERROR_proj");
			item.shootSpeed = 9f;
			item.autoReuse = false;
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