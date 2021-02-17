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

namespace Breakout
{
    public class Brick
    {

        Color brickText;
        Rectangle brickRect;
        int pointCount;

        public Brick(Color text, Rectangle rect, int points)
        {
            brickText = text;
            brickRect = rect;
            pointCount = points;
        }

        public Color GetText
        {
            get
            {
                return brickText;
            }
        }

        public Rectangle GetRect
        {
            get
            {
                return brickRect;
            }
        }

        public int GetPoints
        {
            get
            {
                return pointCount;
            }
        }
    }
}
