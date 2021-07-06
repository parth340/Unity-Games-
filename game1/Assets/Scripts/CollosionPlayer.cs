using UnityEngine;

public class CollosionPlayer : MonoBehaviour
{
    public Player movement;
    

    void OnCollisionEnter(Collision collisionInfo )
    {
      //  Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Collision object")
        {
            Debug.Log("We hit an object");
            movement.enabled = false;
            FindObjectOfType<gal>().EndGame();
        }
    }

}
