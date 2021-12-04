using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Varwin;
using Varwin.Public;

namespace Varwin.Types.Cylinder1_44c1121da694410abc0eeab82bf544f8
{
    [VarwinComponent(English: "Cylinder")]
    public class Cylinder1 : VarwinObject
    {
        private float AngleFall = 0.6f;
        

        public delegate void FallEventHandler();
        [Event(English: "sample event")]
        public event FallEventHandler sampleEvent;

        [Checker(English: "check if zero")]
        public bool ZeroChecker()
        {
            return transform.up.y < AngleFall; ;
        }
        IEnumerator Start()
        {

            while (!ZeroChecker())
            {
                yield return null;
                ZeroChecker();
            }
            sampleEvent?.Invoke();
        }
    }
}
