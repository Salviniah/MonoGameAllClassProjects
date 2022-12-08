using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MeteorApplication
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Meteor m1;
        private SpriteFont font;
        private SimpleString ss;
        

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
            Texture2D tex = this.Content.Load<Texture2D>("images/Meteor1");
            Vector2 position = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
            m1 = new Meteor(this, _spriteBatch, tex, position);
            this.Components.Add(m1);

            font = this.Content.Load<SpriteFont>("fonts/MyFont");
            ss = new SimpleString(this,_spriteBatch, font,"Selam",position:new Vector2(0,0),Color.White);
            this.Components.Add(ss);    
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            float rotation = m1.rotation;
            ss.message = "Rotation: " + rotation.ToString("N2");
            Vector2 messageVec = font.MeasureString(ss.message);
            Vector2 pos = new Vector2(_graphics.PreferredBackBufferWidth - messageVec.X, 0);
            ss.position = pos;
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