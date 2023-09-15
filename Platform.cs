using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace platformer;

public class Platform
{
    public Platform sprite;
    public Vector2f size;
    public const float Diameter = 20.0f;
    public const float Radius = Diameter * 0.5f;
    
    public Platform()
    {
        sprite = new Sprite();
        sprite.Texture = new Texture("assets\\platform.png");
        
    }

    public void Update()
    {
        
    }

    public void Draw(RenderTarget target)
    {
        target.Draw(sprite);
        Vector2f platformTextureSize = (Vector2f) sprite.Texture.Size;
        sprite.Origin = 1.0f * platformTextureSize;
        sprite.Scale = new Vector2f(
            Diameter / platformTextureSize.Y,
            Diameter / platformTextureSize.Y);
            
        size = new Vector2f(
            sprite.GetGlobalBounds().Width,
            sprite.GetGlobalBounds().Height
    }
}