using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameWindowsStarter
{
    public class Enemy
    {
        Game game;
        Texture2D texture;
        public BoundingRectangle Bounds;
        public bool destroyed;

        public Enemy(Game game)
        {
            this.game = game;
        }

        public void Initialize(BoundingRectangle bounds) 
        {
            Bounds = bounds;
        }
        public virtual void LoadContent() { }
        public virtual void Update() { }
        public virtual void Draw() { }
    }
}
