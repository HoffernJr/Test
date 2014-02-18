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
    class Tiles
    {
        protected Texture2D texture;

        private Rectangle rectangle;
        public Rectangle Rectangle 
        {
            get { return rectangle; }
            protected set { rectangle = value; }
        }
        private static ContentManager content;
        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture,rectangle,Color.White);
        }
    }
    class CollisionTiles : Tiles {
        public CollisionTiles(int i, Rectangle newRectangle) {
            //Loads different tiles with the names Tile1, Tile2 and so on.
            texture = Content.Load<Texture2D>(@"Images\Tile" + i);
            this.Rectangle = newRectangle;
        }
    }
}
