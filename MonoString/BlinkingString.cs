using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoString
{
    internal class BlinkingString : SimpleString
    {
        protected int delay;
        private int delayCounter;
        private bool flag;
        public BlinkingString(Game game, SpriteBatch spriteBatch, SpriteFont font, string message, Vector2 position, Color color, int delay) : base(game, spriteBatch, font, message, position, color)
        {
            this.delay = delay;
        }

        public override void Update(GameTime gameTime)
        {
            delayCounter++;
            Debug.WriteLine(flag);
            if (delayCounter >= delay) //5
            {
                flag = !flag;
                delayCounter = 0;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            if (flag)
            {
                base.Draw(gameTime);
            }
        }
    }
}
