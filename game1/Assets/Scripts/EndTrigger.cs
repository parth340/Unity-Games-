using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gal gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
