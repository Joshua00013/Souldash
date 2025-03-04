using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float _timeUntilDespawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilDespawn -= Time.deltaTime;

        if (_timeUntilDespawn <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Hit");
        }
    }
}
