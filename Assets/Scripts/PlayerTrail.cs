using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
//making the Rainbow trail behind the player
    public float lifeTime = 1f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    //making the trail go to the left
    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 5f;
    }
}
