using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TPUG.Projectiles
{
	public class ERROR_proj : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("ERROR");
		}

		public override void SetDefaults() {
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.light = 30f;  
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.aiStyle = 3;
			projectile.CloneDefaults(ProjectileID.JavelinFriendly);
		}
	}
}