using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKnockBack : MonoBehaviour
{

    public float Force = 30f;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public IEnumerator KnockBack()
    {

        Vector2 lastPosition = new Vector2(transform.position.x, transform.position.y);
        
        yield return new WaitForSeconds (.06f);

        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 _direction = new Vector2(currentPosition.x - lastPosition.x, 0);

        rb.AddForce( -_direction * Force, ForceMode2D.Impulse);

    }

}
