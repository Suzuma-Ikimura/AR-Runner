using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawnCubes;

    public void startGame() {
        spawnCubes.GetComponent<SpawnCubes>().enabled = true;
        IsInGame.isinGame = true;
        gameObject.SetActive(false);
    }

}
