using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class YolSpawner : MonoBehaviour
{ 
    public List<GameObject> roads;
    public float eklemeHizi = 20f;
    
        void Start()
    {
        if(roads != null && roads.Count>0)
        {
            roads=roads.OrderBy(r=>r.transform.position.x).ToList();
            InvokeRepeating("moveRoad", 0f, eklemeHizi*4);
        }
    }

        public void moveRoad()
    {
       if (roads != null && roads.Count > 0)
        {
            GameObject firstRoad = roads[0];
            float roadWidth = firstRoad.transform.GetChild(0).GetComponent<Renderer>().bounds.size.x;

            GameObject newRoad = Instantiate(firstRoad, new Vector3(firstRoad.transform.position.x - roadWidth, 0.5f, 0f), Quaternion.identity);
            roads.Insert(0, newRoad);
        }
    }
}
