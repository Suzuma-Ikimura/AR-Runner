using System.Collections;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cubes;
    [SerializeField] private int minC = 1, maxC = 3;

    private void Start()
    {
        StartCoroutine(spawn());

    }

    IEnumerator spawn()
    {
        while (true) {
            GameObject spawnCube = null;
            Vector3 pos = transform.position;
            int howManyCubes = Random.Range(minC, maxC);
                for (int i = 0; i < howManyCubes; i++) {
                    if(i > 0) { 
                        pos = new Vector3 (
                            spawnCube.transform.position.x,
                            spawnCube.transform.position.y,
                            spawnCube.transform.position.z + 0.9f
                            );
                    }
                    spawnCube = Instantiate(cubes, pos, Quaternion.identity);
                }
            float wait = 2.2f;
            switch (howManyCubes) {
                case 1: wait = 1.5f; break;
                case 2: wait = 1.8f; break;
            }
            yield return new WaitForSeconds(wait);
        }
    }

}
