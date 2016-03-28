using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace rpg_projecto_tpsi
{
    public class ScreenManager
    {
        
        private static ScreenManager instance;
        public ContentManager content { private set; get; }
        public Vector2 dimensions {private set; get;}
        XmlManager<GameScreen> xmlGameScreenManager;

        GameScreen currentScreen;
        public GraphicsDevice GraphicsDevice;
        public SpriteBatch SpriteBatch;

        public static ScreenManager Instance {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
             }

        }

        public ScreenManager() {
            //dimensions = new Vector2(840, 480);
            currentScreen = new SplashScreen();
            xmlGameScreenManager = new XmlManager<GameScreen>();
            xmlGameScreenManager.Type = currentScreen.Type;          
            currentScreen = xmlGameScreenManager.Load("Load/SplashScreen.xml");
        }

        public void loadContent(ContentManager content) {

            //content- img/sons etc substituir depois
            this.content = new ContentManager(content.ServiceProvider, "content");
            currentScreen.loadContent();
        }
        public void unloadContent() {
            currentScreen.unLoadContent();
        }
        public void update(GameTime gameTime) {
            currentScreen.update(gameTime);
        }
        public void draw(SpriteBatch spriteBatch) {
            currentScreen.draw(spriteBatch);
        }
    
    }
}
