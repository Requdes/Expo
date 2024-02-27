using UnityEngine;

public static class ExtensionVector2 {

    public static Vector2 ZeroX (this Vector2 vector) => new Vector2 (0, vector.y);
    public static Vector2 ZeroY (this Vector2 vector) => new Vector2 (vector.x, 0);
    
    public static Vector2 OnlyX (this Vector2 vector) => new Vector2 (vector.x, 0);
    public static Vector2 OnlyY (this Vector2 vector) => new Vector2 (0, vector.y);

    public static Vector2 Swap (this Vector2 vector) => new Vector2 (vector.y, vector.x);
}