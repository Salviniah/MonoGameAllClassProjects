using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MeteorApplication
{
    public class Meteor : DrawableGameComponent
    {
        public SpriteBatch spriteBatch { get; set; }
        public Texture2D tex { get; set; }
        public Vector2 position { get; set; }

        public float rotation { get; set; }
        public float scale { get; set; } = 1;
        public Vector2 origin { get; set; }

        private const float ROTATION_FACTOR = 0.05F;
        private float SCALE_FACTOR = 0.01F;

        private const float MAX_SCALE = 3.0F;
        private const float MIN_SCALE = 0.1F;

        private Rectangle srcRect;
        public Meteor(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position) : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.tex = tex;
            this.srcRect = new Rectangle(0, 0, tex.Width / 2, tex.Height / 2);
            this.position = position;
            this.origin = new Vector2(tex.Width / 2, tex.Height / 2);
        }


        public override void Update(GameTime gameTime)
        {
            rotation += ROTATION_FACTOR;
            scale += SCALE_FACTOR;

            if (scale > MAX_SCALE || scale < MIN_SCALE)
            {
                SCALE_FACTOR = -SCALE_FACTOR;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(tex, position, srcRect, Color.White, rotation, origin, scale, SpriteEffects.None, 1);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
