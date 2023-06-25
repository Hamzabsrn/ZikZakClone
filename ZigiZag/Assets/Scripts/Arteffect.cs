using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arteffect : MonoBehaviour
{
    public int minscore, maxscore;
    public ParticleSystem collectEffect;
    private GameManager gameManager;
    void Start()
    {
        gameManager= FindObjectOfType<GameManager>();

    }
    private void Update()
    {
        transform.Rotate(180f * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.Instance.Play("Coin");
            gameManager.AddScore(Random.Range(minscore,maxscore));
            collectEffect.Play();
            Destroy(this.gameObject,0.5f);
        }
    }
}
