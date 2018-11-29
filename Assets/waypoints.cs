using UnityEngine;

public class waypoints : MonoBehaviour {

    public static Transform[] points;

    void awake ()
    {
        points = new Transform[transform.childCDount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
	
}
