
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace TPUG.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ERRORL : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ERROR Leggings");
			Tooltip.SetDefault("An ERROR has occured loading TPUG.Armor.ERRORL. PSlease try again later");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "LiquidERROR", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}