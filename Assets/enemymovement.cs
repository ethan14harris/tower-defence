using UnityEngine;

public class enemymovement : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void start()
    {
        points = new Transform[transform.childCDount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
    {
        target = Waypoint.points{0};
    }

    void update ()
    {
        vector3 dir = target.position - transform.position;
         transform.Translate(dir.normalized * speed * Time.deltaTime, space.wor);



    }   

}