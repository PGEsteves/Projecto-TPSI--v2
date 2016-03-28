﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace rpg_projecto_tpsi
{
   

    public class SplashScreen : GameScreen
    {
        public Image Image;
        
        public override void loadContent()
        {
            base.loadContent();
            Image.loadContent();

        }

        public override void draw(SpriteBatch spriteBatch)
        {

            //desenha a imagem pls
            Image.SourceRect = new Rectangle(0, 0, spriteBatch.GraphicsDevice.Viewport.Width, spriteBatch.GraphicsDevice.Viewport.Height);
            Image.Position = Vector2.Zero;
            Image.draw(spriteBatch);
            base.draw(spriteBatch);
        }

        public override void unLoadContent()
        {
            base.unLoadContent();
            Image.unLoadContent();
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
            Image.update(gameTime);
        }
    }
}
