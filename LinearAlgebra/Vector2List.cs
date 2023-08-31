using System.Collections.Generic;

namespace UnityTools.Vector2
{
    public class Vector2List
    {
        private static readonly List<UnityEngine.Vector2> _fourDirection;

        static Vector2List()
        {
            _fourDirection = new List<UnityEngine.Vector2>
            {
                UnityEngine.Vector2.right,
                UnityEngine.Vector2.up,
                UnityEngine.Vector2.left,
                UnityEngine.Vector2.down
            };
        }

        public static List<UnityEngine.Vector2> FourDirection()
        {
            return _fourDirection;
        }
    }
}