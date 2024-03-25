using System.Collections;
using UnityEngine;

namespace Exercise_1.Scripts
{
    public class CoroutinePerformer : MonoBehaviour, ICoroutinePerformer
    {
        public Coroutine StartRoutine(IEnumerator coroutine)
        {
            return StartCoroutine(coroutine);
        }

        public void StopRoutine(IEnumerator coroutine)
        {
            StopCoroutine(coroutine);
        }
    }
}