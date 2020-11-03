using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace TPUG.NPCs
{
	public class PosessedSword : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Posessed Sword");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 50;
			npc.damage = 5;
			npc.defense = 30;
			npc.knockBackResist = 0.3f;
			npc.width = 70;
			npc.alpha = 0;
			npc.height = 46;
			animationType = 244;
			npc.aiStyle = 23;
			aiType = 138;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 1.5f;
		}
		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.expertMode || Main.rand.NextBool())
			{
				player.AddBuff(BuffID.OnFire, 600, true);
			}
		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LiquidERROR"));
		}
		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LiquidERROR"));
		}
	}
}