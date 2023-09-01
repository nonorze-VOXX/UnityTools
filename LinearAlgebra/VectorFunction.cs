using UnityEngine;
using UnityTools.Vector2.Metrix;

namespace UnityTools.Vector2
{
    public class VectorFunction
    {
        public static UnityEngine.Vector2 RotateVector(UnityEngine.Vector2 v, float theta)
        {
            var rotationMatrix2x2 = new Metrix2x2(
                new UnityEngine.Vector2(Mathf.Cos(theta / 180 * Mathf.PI), Mathf.Sin(theta / 180 * Mathf.PI)),
                new UnityEngine.Vector2(-Mathf.Sin(theta / 180 * Mathf.PI), Mathf.Cos(theta / 180 * Mathf.PI)));
            return v * rotationMatrix2x2;
        }

        public static Vector3 ElementWiseMultiply(Vector3 v1, Vector3 v2)
        {
            return new Vector3(
                v1.x * v2.x,
                v1.y * v2.y,
                v1.z * v2.z
            );
        }
    }
}