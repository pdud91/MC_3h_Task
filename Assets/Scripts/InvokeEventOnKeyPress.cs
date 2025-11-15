using UnityEngine;
using UnityEngine.Events;

public class InvokeEventOnKeyPress : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] UnityEvent onKeyPress;

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            onKeyPress?.Invoke();
        }
    }
}
