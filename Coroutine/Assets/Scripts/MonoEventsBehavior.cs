
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{

public UnityEvent startEvent, awakeEvent, disableEvent;

    public void Awake()
    {
        awakeEvent.Invoke();
    }

    public void Start()
    {
        startEvent.Invoke();
    }

    public void OnDisable()
    {
        disableEvent.Invoke();
    }
}
