using UnityEngine;

public class Star : MonoBehaviour
{

    public AudioClip starClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(starClip, transform.position);
            Destroy(gameObject);
            GameManager.score += 1;
            
        }
    }
    
}
