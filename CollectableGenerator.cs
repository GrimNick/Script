
using UnityEngine;

public class CollectableGenerator : MonoBehaviour
{
    public GameObject toSpawn;
    public GameObject toSpawnRare;
    GameObject newspawn;
    GameObject willSpawn;
    public float maxtime = 2f;
    float timer = 0;
    float imptimer = 0;
    float changer = 10f;          //Changer used to manipulate the speed of decreasing of maxtime to spawn
    int spawned = 0;
    public float speed = 20;
    int randomRarity;
    // Start is called before the first frame update




    // Update is called once per frame
    void Update()
    {
        
        if (spawned > 5)
        {
            if (randomRarity > 8)
            {
                willSpawn = toSpawnRare;
            }
            else
            {
                willSpawn = toSpawn;
            }
            
        }


        Vector2 random = new Vector2(transform.position.x, Random.Range(-2f, 0.5f));
        timer += Time.deltaTime;

        //To decrease maxtime
        imptimer += Time.deltaTime;
        if (imptimer > changer && maxtime > 2f)
        {
            maxtime = maxtime - 0.1f;
            imptimer = 0f;
            changer = changer + 3f;
        }


        if (timer > maxtime)
        {
            randomRarity = (int)Random.Range(0f, 10f);
            Debug.Log("Random number is" + randomRarity);
            if (spawned == 0) willSpawn = toSpawn;
            GameObject newspawn = Instantiate(willSpawn, random, transform.rotation);
            timer = 0;
            spawned++;
            //Destroy(newspawn, 5f);
        }
        //Destroy(newspawn, 4f);
    }

}
