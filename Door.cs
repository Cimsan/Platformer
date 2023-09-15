using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace platformer;

public class Door
{
    public Door sprite;
    public Vector2f size;
    public const float Diameter = 20.0f;
    public const float Radius = Diameter * 0.5f;
    
    public Door()
    {
        sprite = new Sprite();
        sprite.Texture = new Texture("assets\\door.png");
        
    }

    public void Update()
    {
        
    }

    public void Draw(RenderTarget target)
    {
        target.Draw(sprite);
        Vector2f doorTextureSize = (Vector2f) sprite.Texture.Size;
        sprite.Origin = 1.0f * doorTextureSize;
        sprite.Scale = new Vector2f(
            Diameter / doorTextureSize.Y,
            Diameter / doorTextureSize.Y);
            
        size = new Vector2f(
            sprite.GetGlobalBounds().Width,
            sprite.GetGlobalBounds().Height
    }
}