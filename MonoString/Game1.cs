using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoString
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteFont font = this.Content.Load<SpriteFont>("fonts/MyFont");
            SimpleString simple1 = new SimpleString(this,_spriteBatch, font,"First Simple String",position: new Vector2(100,100),Color.Red);
            this.Components.Add(simple1);

            SimpleString simple2 = new SimpleString(this, _spriteBatch, font, "Second Simple String", position: new Vector2(100, 200), Color.Blue);
            this.Components.Add(simple2);

            BlinkingString blinking1 = new BlinkingString(this,_spriteBatch,font,"Blinking String",position: new Vector2(100,400),Color.White,5);
            this.Components.Add(blinking1);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}