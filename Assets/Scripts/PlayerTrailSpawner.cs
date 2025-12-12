using UnityEngine;

public class PlayerTrailSpawner : MonoBehaviour
{
    public GameObject Prefab;
        //Set prefab to RainbowTrail
    private GameObject RainbowTrail
    {
        get { return Prefab; }
    }
    public float spawnRate = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        if (Prefab == null)
        {
            Debug.LogWarning("Prefab is not assigned in the inspector.");
            return;
        }
        Instantiate(RainbowTrail, transform.position, Quaternion.identity);
    }
}

