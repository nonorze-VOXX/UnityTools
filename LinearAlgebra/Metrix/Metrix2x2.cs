using System;
using System.Collections.Generic;
using General;

namespace UnityTools.Vector2.Metrix
{
    public class Metrix2x2
    {
        private readonly List<List<float>> _elements =
            ListFunction.Generate2DArrByVector2<float>(new UnityEngine.Vector2(2, 2));

        public Metrix2x2()
        {
        }

        public Metrix2x2(List<float> floats)
        {
            if (floats.Count > 4) throw new NotImplementedException();

            Queue<float> queue = new();
            foreach (var f in floats) queue.Enqueue(f);

            for (var i = 0; i < 4; i++)
                if (queue.Count != 0)
                    _elements[i / 2][i % 2] = queue.Dequeue();
                else
                    _elements[i / 2][i % 2] = 0;
        }

        public Metrix2x2(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
        {
            _elements[0][0] = a.x;
            _elements[1][0] = a.y;
            _elements[0][1] = b.x;
            _elements[1][1] = b.y;
        }

        public List<float> this[int index]
        {
            get => _elements[index];
            set => _elements[index] = value;
        }

        public float this[UnityEngine.Vector2 v]
        {
            get => _elements[(int)v.y][(int)v.x];
            set => _elements[(int)v.y][(int)v.x] = value;
        }

        public static UnityEngine.Vector2 operator *(Metrix2x2 b, UnityEngine.Vector2 a)
        {
            var tmp = new Metrix2x2(a, new UnityEngine.Vector2(0, 0));
            var mul = b * tmp;
            return new UnityEngine.Vector2(mul[0][0], mul[1][0]);
        }

        /// <summary>for typo, but user should know that is wrong </summary>
        public static UnityEngine.Vector2 operator *(UnityEngine.Vector2 a, Metrix2x2 b)
        {
            return b * a;
        }

        public static Metrix2x2 operator *(Metrix2x2 a, Metrix2x2 b)
        {
            List<float> n = new();
            var size = 2;
            for (var y = 0; y < size; y++)
            for (var x = 0; x < size; x++)
            {
                var sum = 0.0f;
                for (var i = 0; i < size; i++) sum += a[y][i] * b[i][x];
                n.Add(sum);
            }

            return new Metrix2x2(n);
        }

        public override string ToString()
        {
            return "[[" + _elements[0][0] + ", " + _elements[0][1] + "] " +
                   " [" + _elements[1][0] + ", " + _elements[1][1] + "]]";
        }
    }
}