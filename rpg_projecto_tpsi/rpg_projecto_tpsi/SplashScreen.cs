using System;
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
        Texture2D imagem;
        //em maiuscula pq é publica e para ficar igual ao XML- se se quiser por minuscula,usa-se sem ; -[XmlElement("Path")]
        public string Path;
        
        public override void loadContent()
        {
            base.loadContent();
            imagem = content.Load<Texture2D>(Path);

        }

        public override void draw(SpriteBatch spriteBatch)
        {

            //desenha a imagem
            spriteBatch.Draw(imagem, new Rectangle(0, 0, spriteBatch.GraphicsDevice.Viewport.Width, spriteBatch.GraphicsDevice.Viewport.Height), Color.White);
            base.draw(spriteBatch);
        }

        public override void unLoadContent()
        {
            base.unLoadContent();
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
        }
    }
}
