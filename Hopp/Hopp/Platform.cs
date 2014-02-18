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
    class Platform
    {
        Texture2D texture;
        Vector2 position;
        Vector2 velocity;
        bool move;

        public Platform(Texture2D newTexture, Vector2 newPosition, bool newMove) {
            texture = newTexture;
            position = newPosition;
            move = newMove;
            if (move)
            {
                velocity.X = 1f;
            }
        }
        public void Update(GameTime gameTime)
        {
            position += velocity;
            if (move)
            {
                if ((position.X + texture.Width) == 512) velocity.X = -1f;
                else if ((position.X) == 0) velocity.X = 1f;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
        
    }
}
