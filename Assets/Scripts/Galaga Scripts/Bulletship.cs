using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 1;
    public GameObject bullet;

    public float bulletTimer = 0, bulletWait = 2;
    void Update()
    {

        transform.Translate(-transform.up * speed * Time.deltaTime);

        bulletTimer += Time.deltaTime;
        if (bulletTimer >= bulletWait)
        {

            bulletTimer = 0;
            Instantiate(bullet, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);

        }

    }
}
