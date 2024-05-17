using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DominionSharp;

public interface IGameEntity
{
    public void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    public void Update(GameTime gameTime);
}
