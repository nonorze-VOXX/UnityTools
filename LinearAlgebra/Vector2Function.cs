using UnityEngine;
using UnityTools.Vector2.Metrix;

namespace UnityTools.Vector2
{
    public class Vector2Function
    {
        public static UnityEngine.Vector2 RotateVector(UnityEngine.Vector2 v, float theta)
        {
            var rotationMatrix2x2 = new Metrix2x2(
                new UnityEngine.Vector2(Mathf.Cos(theta / 180 * Mathf.PI), Mathf.Sin(theta / 180 * Mathf.PI)),
                new UnityEngine.Vector2(-Mathf.Sin(theta / 180 * Mathf.PI), Mathf.Cos(theta / 180 * Mathf.PI)));
            return v * rotationMatrix2x2;
        }
    }
}