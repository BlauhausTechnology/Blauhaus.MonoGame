using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blauhaus.MonoGame.Scenes
{
    public interface IScene
    {
        public void Initialize();
        public void LoadContent();

        public void Update(GameTime gameTime);

        public void BeforeDraw(SpriteBatch spriteBatch, Color clearColor);
        public void Draw(SpriteBatch spriteBatch);
        public void AfterDraw(SpriteBatch spriteBatch);

        public void UnloadContent();
        
    }
}