using UnityEngine; // MonoBehaviour, GameObject, Transform, Instantiate,
                   // Quaternion

public class GameManager : MonoBehaviour
{
    const float spawnBlockInvokeTimeS = 0.5f;
    const float spawnBlockRateS = 1.0f;

    public GameObject block;
    public Transform spawnPoint;
    public float spawnMaxX;

    bool gameStarted = false;

    void Update()
    {
        // Wait player touch for game starting
        if (Input.GetMouseButtonDown(0) && !this.gameStarted)
        {
            this.GameStart();
            this.gameStarted = true;
        }
    }

    void GameStart() {
        this.InvokeRepeating(
            "SpawnBlock",
            GameManager.spawnBlockInvokeTimeS,
            GameManager.spawnBlockRateS
        );
    }

    void SpawnBlock()
    {
        Vector3 spawnPos = this.spawnPoint.position;
        spawnPos.x = Random.Range(-this.spawnMaxX, this.spawnMaxX);
        Instantiate(this.block, spawnPos, Quaternion.identity);
    }
}
