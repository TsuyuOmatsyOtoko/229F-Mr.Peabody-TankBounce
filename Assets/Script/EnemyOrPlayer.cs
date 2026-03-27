using UnityEngine;

public class EnemyOrPlayer : MonoBehaviour
{
    private void OnDestroy()
    {
        ObjectDestroyChecker checker = FindObjectOfType<ObjectDestroyChecker>();
        if (checker != null)
        {
            // ส่งชื่อ GameObject ที่ถูกทำลายไปให้ ObjectDestroyChecker
            checker.NotifyDestroyed(gameObject.name);
        }
    }
}

