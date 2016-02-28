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
    //incompleto - video 5 -apartir dos 3 min e 15 seg
    public class Image
    {
        public float Alpha;
        public string Text, FontName, Path;
        public Vector2 Position, Scale;
        public Rectangle SourceRect;

        public Texture2D texture;
        Vector2 origin;
        ContentManager content;
        RenderTarget2D renderTarget;
        SpriteFont font;

        public Image()
        {
            Path = String.Empty;
            FontName = "Comic Sans MS";
            Position = Vector2.Zero;
            Scale = Vector2.One;
            Alpha = 1.0f;
            SourceRect = Rectangle.Empty;

        }

        public void loadContent()
        {
            content = new ContentManager(ScreenManager.Instance.content.ServiceProvider, "content");

            if (Path != String.Empty)
            {
                texture = content.Load<Texture2D>(Path);
            }

            font = content.Load<SpriteFont>(FontName);

            Vector2 dimensions = Vector2.Zero;

            if (texture != null) {
                dimensions.X += texture.Width;
            }
            dimensions.X = +font.MeasureString(Text).X;

            if (texture != null)
            {
                dimensions.Y = Math.Max(texture.Height, font.MeasureString(Text).Y);
            }
            else
            {
                dimensions.Y = font.MeasureString(Text).Y;
            }

             if (SourceRect == Rectangle.Empty)
            {
                SourceRect = new Rectangle(0, 0, (int)dimensions.X, (int)dimensions.Y);
            }

            renderTarget = new RenderTarget2D(ScreenManager.Instance.GraphicsDevice, (int)dimensions.X, (int)dimensions.Y);
            ScreenManager.Instance.GraphicsDevice.SetRenderTarget(renderTarget);
            ScreenManager.Instance.GraphicsDevice.Clear(Color.Transparent);
            ScreenManager.Instance.SpriteBatch.Begin();
            if (texture != null)
            {
                ScreenManager.Instance.SpriteBatch.Draw(texture, Vector2.Zero, Color.White);
            }
            ScreenManager.Instance.SpriteBatch.DrawString(font, Text, Vector2.Zero, Color.White);
            ScreenManager.Instance.SpriteBatch.End();


            texture = renderTarget;
            ScreenManager.Instance.GraphicsDevice.SetRenderTarget(null);
        }   
        public void unLoadContent()
        {
            content.Unload();
        }
        public void update(GameTime gameTime) { }
        public void draw(SpriteBatch spriteBatch)
        {
            origin = new Vector2(SourceRect.Width / 2, SourceRect.Height / 2);
            spriteBatch.Draw(texture, Position, SourceRect, Color.White * Alpha, 0.0f, origin, Scale, SpriteEffects.None, 0.0f);

        }
    }
}
