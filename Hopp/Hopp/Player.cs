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

namespace Hopp
{
    class Player
    {
        private Texture2D texture;
        private Vector2 position = new Vector2(200,852);
        private Vector2 velocity;
        private Rectangle rectangle;
        private bool hasJumped;

        public Vector2 Position
        {
            get { return position; }
        }

        public Player() { }

        public void Load(ContentManager Content, int width, int height)
        {
            texture = Content.Load<Texture2D>(@"Images\player1");
            position = new Vector2((float)width / 2, (float)height - texture.Height);
        }

        public void Update(GameTime gameTime) {
            position += velocity;
            rectangle = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            Input(gameTime);

            if (velocity.Y < 10)
                velocity.Y += 0.4f;
        }

        private void Input(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) 
                velocity.X = (float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
                velocity.X = -(float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
            else velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false)
            {
                position.Y -= 16f;
                velocity.Y = -12f;
                hasJumped = true;
            }
        }

        public void Collision(Rectangle newRectangle, int xOffset, int yOffset) 
        {
            if (rectangle.TouchTopOf(newRectangle))
            {
                rectangle.Y = newRectangle.Y - rectangle.Height;
                velocity.Y = 0f;
                hasJumped = false;
            }

            if (rectangle.TouchLeftOf(newRectangle))
            {
                position.X = newRectangle.X - rectangle.Width -2;
            }

            if (rectangle.TouchRightOf(newRectangle))
            {
                position.X = newRectangle.X + newRectangle.Width +2;
            }
            
            //If you don't wan't the player to jump through a platform
            /*if (rectangle.TouchBottomOf(newRectangle))
                velocity.Y = 1f;
            */

            if (position.X <= 0) position.X = 0;
            if (position.X >= xOffset - rectangle.Width) position.X = xOffset - rectangle.Width;
            if (position.Y <= 0) velocity.Y = 1f;
            if (position.Y > yOffset - rectangle.Height)
            { 
                position.Y = yOffset - rectangle.Height;
                velocity.Y = 0f;
                hasJumped = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
