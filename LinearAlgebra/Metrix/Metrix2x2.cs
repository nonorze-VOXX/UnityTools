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
            if (floats.Count != 4)
            {
                throw new System.NotImplementedException();
            }
        }

        public override string ToString()
        {
            return "[[" + _elements[0][0] + ", " + _elements[0][1] + "] " +
                   " [" + _elements[1][0] + ", " + _elements[1][1] + "]]";
        }
    }
}