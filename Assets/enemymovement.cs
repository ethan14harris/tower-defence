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
    {
        target = Waypoint.points{0};
    }

    void update()
{
    vector3 dir = target.position - transform.position;
    transform.Translate(dir.normalized * speed * Time.deltaTime, space.wor);

    if (vector3.distance(transform.position, target.position) <= 0.2f)
    {
        GetNextWaypoint();
    }
    }

        void GetNextWaypoint()
    {
            if (waypointIndex >= waypoints.points.Length - 1)
            {
                Destroy(gameObject);
            }

            wavepointIndex++;
        target = waypoints.points{wavepointIndex};
    }



    }   

}