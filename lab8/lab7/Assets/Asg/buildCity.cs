using UnityEngine;
using System.Collections;

public class buildCity : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
	int buildingFootprint = 2;
    void Start()
    {
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                Vector3 pos = new Vector3(w * buildingFootprint,0,h * buildingFootprint);
                int n = Random.Range(0, buildings.Length);
				Quaternion rotation = Quaternion.Euler(-180, 0, 0);
				Instantiate(buildings[n], pos, rotation);
				//Instantiate(buildings[n], pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
