using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font1;
        Texture2D ship;
        Vector2 ShipLocation = new Vector2(500, 500);
        MouseState mouse;
        Texture2D enemy1, enemy2, enemy3;
        KeyboardState restart = new KeyboardState();
        Vector2 EnemyLocation1 = new Vector2(100, 5);
        Vector2 EnemyLocation2 = new Vector2(15, 400);
        Vector2 EnemyLocation3 = new Vector2(505, 200);
        Rectangle rec1, rec2, rec3, recs;
        int a1 = 1, a2 = 2, a3 = 4, b = 1, mark = 0, time = 0;
        bool rs = false;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font1 = Content.Load<SpriteFont>("SpriteFont1");
            ship = Content.Load<Texture2D>("phithuyen");
            enemy1 = Content.Load<Texture2D>("enemy1");
            enemy2 = Content.Load<Texture2D>("enemy1");
            enemy3 = Content.Load<Texture2D>("enemy1");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                //this.Exit();

            // TODO: Add your update logic here

            if (rs)
            {
                mouse = Mouse.GetState();
                if (mouse.X <= 750 && mouse.X >= 0 && mouse.Y >= 0 && mouse.Y <= 450)
                {
                    ShipLocation.X = mouse.X;
                    ShipLocation.Y = mouse.Y;
                }
                rec1 = new Rectangle((int)EnemyLocation1.X, (int)EnemyLocation1.Y, enemy1.Width, enemy1.Height);
                rec2 = new Rectangle((int)EnemyLocation2.X, (int)EnemyLocation2.Y, enemy1.Width, enemy1.Height);
                rec3 = new Rectangle((int)EnemyLocation3.X, (int)EnemyLocation3.Y, enemy1.Width, enemy1.Height);
                if (recs.Intersects(rec1) || recs.Intersects(rec2) || recs.Intersects(rec3)) { rs = false; }
                recs = new Rectangle((int)mouse.X, (int)mouse.Y, ship.Width, ship.Height);
                //Enemy1

                if (a1 == 1)
                {
                    EnemyLocation1.X += b;
                    EnemyLocation1.Y += b;
                }
                if (a1 == 2)
                {
                    EnemyLocation1.X += b;
                    EnemyLocation1.Y -= b;
                }
                if (a1 == 3)
                {
                    EnemyLocation1.X -= b;
                    EnemyLocation1.Y -= b;
                }
                if (a1 == 4)
                {
                    EnemyLocation1.X -= b;
                    EnemyLocation1.Y += b;
                }


                if (EnemyLocation1.X >= 750)
                {
                    if (a1 == 2) { a1 = 3; }
                    else
                    {
                        a1 = 4;
                    }
                }
                if (EnemyLocation1.X <= 0)
                {
                    if (a1 == 3) { a1 = 2; }
                    else
                    {
                        a1 = 1;
                    }
                }
                if (EnemyLocation1.Y >= 450)
                {
                    if (a1 == 4) { a1 = 3; }
                    else
                    {
                        a1 = 2;
                    }
                }
                if (EnemyLocation1.Y <= 0)
                {
                    if (a1 == 3) { a1 = 4; }
                    else
                    { a1 = 1; }
                }

                //Enemy2

                if (a2 == 1)
                {
                    EnemyLocation2.X += b;
                    EnemyLocation2.Y += b;
                }
                if (a2 == 2)
                {
                    EnemyLocation2.X += b;
                    EnemyLocation2.Y -= b;
                }
                if (a2 == 3)
                {
                    EnemyLocation2.X -= b;
                    EnemyLocation2.Y -= b;
                }
                if (a2 == 4)
                {
                    EnemyLocation2.X -= b;
                    EnemyLocation2.Y += b;
                }


                if (EnemyLocation2.X >= 750)
                {
                    if (a2 == 2) { a2 = 3; }
                    else
                    {
                        a2 = 4;
                    }
                }
                if (EnemyLocation2.X <= 0)
                {
                    if (a2 == 3) { a2 = 2; }
                    else
                    {
                        a2 = 1;
                    }
                }
                if (EnemyLocation2.Y >= 450)
                {
                    if (a2 == 4) { a2 = 3; }
                    else
                    {
                        a2 = 2;
                    }
                }
                if (EnemyLocation2.Y <= 0)
                {
                    if (a2 == 3) { a2 = 4; }
                    else
                    { a2 = 1; }
                }

                //Enemy3

                if (a3 == 1)
                {
                    EnemyLocation3.X += b;
                    EnemyLocation3.Y += b;
                }
                if (a3 == 2)
                {
                    EnemyLocation3.X += b;
                    EnemyLocation3.Y -= b;
                }
                if (a3 == 3)
                {
                    EnemyLocation3.X -= b;
                    EnemyLocation3.Y -= b;
                }
                if (a3 == 4)
                {
                    EnemyLocation3.X -= b;
                    EnemyLocation3.Y += b;
                }


                if (EnemyLocation3.X >= 750)
                {
                    if (a3 == 2) { a3 = 3; }
                    else
                    {
                        a3 = 4;
                    }
                }
                if (EnemyLocation3.X <= 0)
                {
                    if (a3 == 3) { a3 = 2; }
                    else
                    {
                        a3 = 1;
                    }
                }
                if (EnemyLocation3.Y >= 450)
                {
                    if (a3 == 4) { a3 = 3; }
                    else
                    {
                        a3 = 2;
                    }
                }
                if (EnemyLocation3.Y <= 0)
                {
                    if (a3 == 3) { a3 = 4; }
                    else
                    { a3 = 1; }
                }

                time += gameTime.ElapsedGameTime.Milliseconds;
                mark += gameTime.ElapsedGameTime.Milliseconds;
                if (time > 1000)
                {
                    time = 0;
                    b++;
                }
                
            }
            restart = Keyboard.GetState();
            if (restart.IsKeyDown(Keys.Enter)) { rs = !rs; }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();           
            spriteBatch.Draw(ship, ShipLocation, Color.White);
            spriteBatch.Draw(enemy1, EnemyLocation1, Color.White);
            spriteBatch.Draw(enemy2, EnemyLocation2, Color.White);
            spriteBatch.Draw(enemy3, EnemyLocation3, Color.White);
            spriteBatch.DrawString(font1, mark.ToString(), Vector2.Zero, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            if(rs) base.Draw(gameTime);
        }
    }
}
