using UnityEngine;
public class ShootRaycast : MonoBehaviour
{
    [SerializeField] Transform ShootPoint;
    [SerializeField] GameObject ShootPointPrefab;
    [SerializeField] GameObject HitPointPrefab;

public float torquePower = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;

        Debug.DrawRay(ShootPoint.position, transform.forward * 30f, Color.green);

        if (Physics.Raycast(ShootPoint.position, transform.forward, out hit, 50f))
        {
            Debug.DrawRay(ShootPoint.position, transform.forward * hit.distance, Color.red);
            Debug.Log("Ray hits " + hit.collider.name);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ShootPointPrefab, ShootPoint.position, Quaternion.identity);
            Instantiate(HitPointPrefab, hit.point, Quaternion.identity);

            if (hit.collider.name == "Enemy")
            {
                Enemy enemy = hit.collider.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage();
                }
            }
        }
    }
}
