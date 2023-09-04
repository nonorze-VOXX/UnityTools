using System.Collections.Generic;

namespace UnityTools.Vector2
{
    public class Vector2List
    {
        private static readonly List<UnityEngine.Vector2> _fourDirection;
        private static readonly List<List<UnityEngine.Vector2>> sixDirectionIn2DArray;

        static Vector2List()
        {
            _fourDirection = new List<UnityEngine.Vector2>
            {
                UnityEngine.Vector2.right,
                UnityEngine.Vector2.up,
                UnityEngine.Vector2.left,
                UnityEngine.Vector2.down
            };
            sixDirectionIn2DArray = new List<List<UnityEngine.Vector2>>
            {
                new()
                {
                    UnityEngine.Vector2.right,
                    new UnityEngine.Vector2(1, 1),
                    UnityEngine.Vector2.up,
                    UnityEngine.Vector2.left,
                    UnityEngine.Vector2.down,
                    new UnityEngine.Vector2(1, -1)
                },
                new()
                {
                    UnityEngine.Vector2.right,
                    UnityEngine.Vector2.up,
                    new UnityEngine.Vector2(-1, 1),
                    UnityEngine.Vector2.left,
                    new UnityEngine.Vector2(-1, -1),
                    UnityEngine.Vector2.down
                }
            };
        }

        public static List<UnityEngine.Vector2> FourDirection()
        {
            return _fourDirection;
        }

        public static List<List<UnityEngine.Vector2>> SixDirectionIn2DArray()
        {
            return sixDirectionIn2DArray;
        }
    }
}