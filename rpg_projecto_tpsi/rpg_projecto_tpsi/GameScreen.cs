using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace rpg_projecto_tpsi
{
    public class GameScreen
    {
        protected ContentManager content;
        [XmlIgnore]
        public Type Type;

        public GameScreen() {
            Type = this.GetType();
        }


        public virtual void loadContent() {

            //content- img/sons etc substituir depois
            content = new ContentManager(ScreenManager.Instance.content.ServiceProvider, "Content");
        }

        public virtual void unLoadContent() {
            content.Unload();
        }

        public virtual void update(GameTime gameTime) {
        }

        public virtual void draw(SpriteBatch spriteBatch) {
        }
    }
}
