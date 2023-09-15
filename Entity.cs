using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace platformer;

public class Entity
{
    public Entity sprite;
    public Vector2f size;
    public const float Diameter = 20.0f;
    public const float Radius = Diameter * 0.5f;
    
    public Entity()
    {
        sprite = new Sprite();
        sprite.Texture = new Texture("assets\\entity.png");
        
    }

    public void Update()
    {
        
    }

    public void Draw(RenderTarget target)
    {
        target.Draw(sprite);
        Vector2f entityTextureSize = (Vector2f) sprite.Texture.Size;
        sprite.Origin = 1.0f * entityTextureSize;
        sprite.Scale = new Vector2f(
            Diameter / entityTextureSize.Y,
            Diameter / entityTextureSize.Y);
            
        size = new Vector2f(
            sprite.GetGlobalBounds().Width,
            sprite.GetGlobalBounds().Height
    }
}