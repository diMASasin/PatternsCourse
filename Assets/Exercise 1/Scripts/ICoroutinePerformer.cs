using System.Collections;
using UnityEngine;

namespace Exercise_1.Scripts
{
    public interface ICoroutinePerformer
    {
        Coroutine StartRoutine(IEnumerator coroutine);
        void StopRoutine(IEnumerator coroutine);
    }
}