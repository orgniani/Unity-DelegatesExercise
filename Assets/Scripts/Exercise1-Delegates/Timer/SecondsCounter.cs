using System;
using System.Collections;
using UnityEngine;

namespace Exercise1_Delegates.Timer
{
    public class SecondsCounter : MonoBehaviour
    {
        public event Action<int> onSecondPassed = delegate { };

        #region Internal logic, can be ignored

        private IEnumerator Start()
        {
            var waitForSeconds = new WaitForSeconds(1);
            var seconds = 0;
            while (enabled)
            {
                onSecondPassed(seconds);
                yield return waitForSeconds;
                seconds++;
            }
        }

        #endregion
    }
}
