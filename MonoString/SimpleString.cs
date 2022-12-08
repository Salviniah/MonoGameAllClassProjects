using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoString
{
    public class SimpleString : DrawableGameComponent
    {
        protected SpriteBatch _spriteBatch;
        protected SpriteFont font;
        protected string message;
        protected Vector2 position;
        protected Color color;
        public SimpleString(Game game, SpriteBatch spriteBatch, SpriteFont font, string message, Vector2 position, Color color) : base(game)
        {
            _spriteBatch = spriteBatch;
            this.font = font;
            this.message = message;
            this.position = position;
            this.color = color;
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.DrawString(font, message, position, color);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
