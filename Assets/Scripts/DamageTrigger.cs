using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public int maxHealth;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            if (maxHealth <= 0) {
                Destroy(gameObject);
                Debug.Log("Died");
            } else {
                maxHealth--;
                Debug.Log("Health: " + maxHealth);
            }
        }
    }
}
