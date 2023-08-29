using UnityEngine;

namespace UnityTools.Vector2
{
    public class Vector2Function
    {
        public static UnityEngine.Vector2 RotateVector(UnityEngine.Vector2 v, float theta)
    {
        float[,] rotationMatrix = {
            { Mathf.Cos(theta), -Mathf.Sin(theta) },
            { Mathf.Sin(theta), Mathf.Cos(theta) }
        };

        float newX = v.x * rotationMatrix[0, 0] + v.y * rotationMatrix[0, 1];
        float newY = v.x * rotationMatrix[1, 0] + v.y * rotationMatrix[1, 1];

        return new UnityEngine.Vector2(newX, newY);
    }
    }
}