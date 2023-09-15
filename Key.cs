using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace platformer;

public class Key
{
    public Key sprite;
    public Vector2f size;
    public const float Diameter = 20.0f;
    public const float Radius = Diameter * 0.5f;
    
    public Key()
    {
        sprite = new Sprite();
        sprite.Texture = new Texture("assets\\key.png");
        
    }

    public void Update()
    {
        
    }

    public void Draw(RenderTarget target)
    {
        target.Draw(sprite);
        Vector2f keyTextureSize = (Vector2f) sprite.Texture.Size;
        sprite.Origin = 1.0f * keyTextureSize;
        sprite.Scale = new Vector2f(
            Diameter / keyTextureSize.Y,
            Diameter / keyTextureSize.Y);
            
        size = new Vector2f(
            sprite.GetGlobalBounds().Width,
            sprite.GetGlobalBounds().Height
    }
}