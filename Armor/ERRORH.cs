
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TPUG.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ERRORH : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ERROR_HELMET");
			Tooltip.SetDefault("ERROR LOADING HELMET");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 2;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ERRORC>() && legs.type == ModContent.ItemType<ERRORL>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "as you embrace the glitchy armor, your attack rises";
			player.allDamage -= 0.2f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
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