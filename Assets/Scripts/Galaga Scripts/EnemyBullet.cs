using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 6;
    void Update()
    {

        transform.Translate(-transform.up * speed * Time.deltaTime);

    }

}
