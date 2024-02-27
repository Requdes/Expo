using UnityEngine;

public static class ExtensionVector3 {

    public static Vector3 ZeroX (this Vector3 vector) => new Vector3 (0, vector.y, vector.z);
    public static Vector3 ZeroY (this Vector3 vector) => new Vector3 (vector.x, 0, vector.z);
    public static Vector3 ZeroZ (this Vector3 vector) => new Vector3 (vector.x, vector.y, 0);
    
    public static Vector3 OnlyX (this Vector3 vector) => new Vector3 (vector.x, 0, 0);
    public static Vector3 OnlyY (this Vector3 vector) => new Vector3 (0, vector.y, 0);
    public static Vector3 OnlyZ (this Vector3 vector) => new Vector3 (0, 0, vector.z);

    public static Vector3 SwapXY (this Vector3 vector) => new Vector3 (vector.y, vector.x, vector.z);
    public static Vector3 SwapXZ (this Vector3 vector) => new Vector3 (vector.z, vector.y, vector.x);
    public static Vector3 SwapYZ (this Vector3 vector) => new Vector3 (vector.x, vector.z, vector.y);
}