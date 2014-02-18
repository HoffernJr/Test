using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hopp
{
    class Map
    {
        private List<CollisionTiles> collisionTiles = new List<CollisionTiles>();

        public List<CollisionTiles> CollisionTiles
        {
            get { return collisionTiles; }
        }

        private int width, height;

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }
        public Map()
        {
        
        }

        public void Generate(int[,] map, int sizeWidth, int sizeHeight) 
        {
            for (int x = 0; x < map.GetLength(1); x++)
                for(int y = 0; y<map.GetLength(0); y++)
                {
                    int number = map[y, x];

                    if (number > 0)
                        collisionTiles.Add(new CollisionTiles(number, new Rectangle(x * sizeWidth, y * sizeWidth, sizeWidth, sizeHeight)));

                    width = (x + 1) * sizeWidth; //The space between the start of a platform
                    height = (y + 1) * sizeWidth;//The space between the platforms in height
                }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (CollisionTiles tile in collisionTiles)
                tile.Draw(spriteBatch);
        }
    }
}
