using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GoodCollectables : MonoBehaviour {

	public GameObject stardustPrefab;
	public List<GameObject> stardusts;
	public int maxStardusts = 10;

	public GameObject starleafPrefab;
	public List<GameObject> starleaves;
	public int maxStarleaves = 5;
    float currCountdownValue;

    public GameObject shipPrefab;
    public List<GameObject> shipParts;
    public int maxShipParts = 10;

    public GameObject shipPrefab1;
    public List<GameObject> shipParts1;
    public int maxShipPart1 = 10;

    public GameObject shipPrefab2;
    public List<GameObject> shipParts2;
    public int maxShipPart2 = 10;


    // initialization
    void Start () 
	{
        // start countdown to spawn objects
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown(float countdownValue = 5)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue >= 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;

            if (currCountdownValue < 0)
            {
                CreateStardust();
                CreateStarLeaves();
                CreateShipParts();
                CreateShipParts1();
                CreateShipParts2();
            }
        }
    }

    void CreateStardust()
	{
		stardusts = new List<GameObject> ();

		// Spawning stardusts randomly on the screen within the screen's boundaries
		// Quaternion.identity - no rotation
		for (int i = 0; i < maxStardusts; i++) 
		{
			Vector3 screenPosition = new Vector3 (Random.Range (-8.29f, 8.29f), 
				Random.Range (-4.1f, 3.8f), 1);
			GameObject myStardusts = stardustPrefab;
			Instantiate (myStardusts, screenPosition, Quaternion.identity);
			stardusts.Add (myStardusts);

		}
	}
		
	void CreateStarLeaves()
	{
		starleaves = new List<GameObject> ();

		// Spawning starleaves randomly on the screen within the screen's boundaries
		for (int j = 0; j < maxStarleaves; j++) 
		{
			Vector3 screenPosition = new Vector3 (Random.Range (-8.29f, 8.29f), 
				Random.Range (-4.1f, 3.8f), 1);
			GameObject myStarLeaves = starleafPrefab;
			Instantiate (myStarLeaves, screenPosition, Quaternion.identity);
			stardusts.Add (myStarLeaves);
		}
	}

    void CreateShipParts()
    {
        shipParts = new List<GameObject>();

        for(int i = 0; i < maxShipParts; i++)
        {
            Vector3 screenPosition = new Vector3(Random.Range(-8.29f, 8.29f),
                Random.Range(-4.1f, 3.8f), 1);
            GameObject myShipParts = shipPrefab;
            Instantiate(myShipParts, screenPosition, Quaternion.identity);
            shipParts.Add(myShipParts);
        }
    }

    void CreateShipParts1()
    {
        shipParts1 = new List<GameObject>();

        for (int i = 0; i < maxShipPart1; i++)
        {
            Vector3 screenPosition = new Vector3(Random.Range(-8.29f, 8.29f),
                Random.Range(-4.1f, 3.8f), 1);
            GameObject myShipParts1 = shipPrefab1;
            Instantiate(myShipParts1, screenPosition, Quaternion.identity);
            shipParts.Add(myShipParts1);
        }
    }

    void CreateShipParts2()
    {
        shipParts2 = new List<GameObject>();

        for (int i = 0; i < maxShipPart2; i++)
        {
            Vector3 screenPosition = new Vector3(Random.Range(-8.29f, 8.29f),
                Random.Range(-4.1f, 3.8f), 1);
            GameObject myShipParts2 = shipPrefab2;
            Instantiate(myShipParts2, screenPosition, Quaternion.identity);
            shipParts.Add(myShipParts2);
        }
    }
}
	
