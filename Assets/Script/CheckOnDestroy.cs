using UnityEngine;

public class CheckOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        ObjectDestroyChecker checker = FindObjectOfType<ObjectDestroyChecker>();
        if (checker != null)
        {
            checker.NotifyDestroyed(gameObject.name);
        }
    }
}
