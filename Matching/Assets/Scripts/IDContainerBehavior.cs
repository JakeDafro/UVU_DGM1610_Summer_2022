
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public ID idObj;

    public UnityEvent startEvent;

    // Start is called before the first frame update
    void Start()
    {
       startEvent.Invoke();
    }

    
}
