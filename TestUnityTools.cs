using UnityEngine;
using UnityTools.Vector2.Metrix;

namespace UnityTools
{
    public class TestUnityTools : MonoBehaviour
    {
        private Metrix2x2 _metrix2X2;

        private void Start()
        {
            _metrix2X2 = new Metrix2x2();
            print(_metrix2X2.ToString());
        }
    }
}