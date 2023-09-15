using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace platformer;

public class Hero
{
    public Hero sprite;
    public Vector2f size;
    public const float Diameter = 20.0f;
    public const float Radius = Diameter * 0.5f;
    
    public Hero()
    {
        sprite = new Sprite();
        sprite.Texture = new Texture("assets\\hero.png");
        
    }

    public void Update()
    {
        
    }

    public void Draw(RenderTarget target)
    {
        target.Draw(sprite);
        Vector2f heroTextureSize = (Vector2f) sprite.Texture.Size;
        sprite.Origin = 1.0f * heroTextureSize;
        sprite.Scale = new Vector2f(
            Diameter / heroTextureSize.Y,
            Diameter / heroTextureSize.Y);
            
        size = new Vector2f(
            sprite.GetGlobalBounds().Width,
            sprite.GetGlobalBounds().Height
    }
}