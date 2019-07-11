using UnityEngine;
using UnityEngine.Events;

namespace Otutama.Timer
{
    public class FixedTimer : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent events = new UnityEvent();
        [SerializeField]
        private float interval = default;
        [SerializeField]
        private bool callAtStart = false;

        private float time;

        private void Start()
        {
            Reset();
            if (callAtStart == true)
            {
                events.Invoke();
            }
        }

        private void Update()
        {
            time += Time.deltaTime;
            if (time >= interval)
            {
                events.Invoke();
                Reset();
            }
        }

        private void Reset()
        {
            time = 0f;
        }
    }
}
