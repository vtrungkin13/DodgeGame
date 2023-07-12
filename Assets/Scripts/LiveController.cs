using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiveController : MonoBehaviour
{
    public GameObject canvasScreen;

    public GameObject liveSprite;

    private GameObject _instantiatedLive;

    [SerializeField]
    private int maxLives = 3;
    
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = maxLives;
        Invoke("LivesDisplay", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LivesDisplay()
    {
        for (int i = 0; i <= lives; i++)
        {
            GameObject liveObject = GameObject.Find("Live" + i);
            if (liveObject != null)
            {
                Destroy(liveObject);
            }
        }
            
        float posX1 = -4.7f;
        float posX2 = posX1 + 1.2f;
        float posX3 = posX2 + 1.2f;
        List<float> list = new List<float>()
        {
            posX1, posX2, posX3
        };
        float posY = 9f;

        for (int i = 0; i < lives; i++)
        {
            _instantiatedLive = Instantiate(liveSprite, new Vector3(list[i], posY, 0), this.transform.rotation);
            _instantiatedLive.name = "Live" + i;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {
            lives--;
           
        } else if (collision.gameObject.name.Contains("LiveSpawn"))
        {
            if (lives < maxLives)
            {
                lives++;
            }
        }
        Destroy(collision.gameObject);
        LivesDisplay();
        if (lives == 0)
        {
            Destroy(gameObject);
            canvasScreen.SetActive(true);

        }
    }

}
