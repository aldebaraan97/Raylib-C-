using Raylib_cs;
using System.Numerics;

namespace Characters;
public class Player {
    private Vector2 position;
    float speed;
    Texture2D texture;

    public Player() {}
    public Player(Vector2 position, Texture2D texture) {
        this.position = position;
        this.texture = texture;
    }

    public Vector2 getPosition() {
        return position;
    }

    public void setPosition(Vector2 position) {
        this.position = position;
    }

    public float getSpeed() {
        return speed;
    }

    public void setSpeed(float speed) {
        this.speed = speed;
    }

    public Texture2D getTexture() {
        return texture;
    }
    
    public void setTexture(Texture2D texture) {
        this.texture = texture;
    }
}