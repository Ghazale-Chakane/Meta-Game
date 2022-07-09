using UnityEngine;

public class TwoTimesDestroy : MonoBehaviour
{
    private bool breaker = false;
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.name == "Ball")
        {
            if (!breaker)
            {
                breaker = true;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
