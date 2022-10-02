
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(-3f * Time.deltaTime, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("FinishCollect"))
        {
            Destroy(this.gameObject);
        }

        
    }



}
