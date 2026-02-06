using JetBrains.Annotations;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dogPrefeb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float x = Random.Range(-10, 10);
            int index = Random.Range(0, dogPrefeb.Length);
            if (dogPrefeb[index] != null)
            {

                Instantiate(dogPrefeb[index], new Vector3(x, 0, 20), Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Debug.LogWarning($"dog prefeb{index}is null");
            }
        } 
    }
}
