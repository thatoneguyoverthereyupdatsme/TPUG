using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace TPUG.NPCs
{
	public class TheGrandSquid : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Grand Squid");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 2300;
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
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.buffImmune[24] = true;
			music = MusicID.Boss2;
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.6f);
		}
        public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
        {
            base.OnHitByProjectile(projectile, damage, knockback, crit);
        }
        public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.expertMode || Main.rand.NextBool())
			{
				player.AddBuff(BuffID.Frostburn, 600, true);
			}
		}
	}
}