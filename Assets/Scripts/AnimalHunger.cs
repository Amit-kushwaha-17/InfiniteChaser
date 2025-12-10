using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnimalHunger : MonoBehaviour
{
    public Slider Sliderhunger;
    public int amountToBeFeed;
    private int CurrentFeedAmount = 0;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sliderhunger.maxValue = amountToBeFeed;
        Sliderhunger.value = 0;
        Sliderhunger.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FeedAnimal(int feedAmount)
    {
        CurrentFeedAmount += feedAmount;
        Sliderhunger.fillRect.gameObject.SetActive(true);
        Sliderhunger.value = CurrentFeedAmount;

        if (CurrentFeedAmount >= amountToBeFeed)
        {
            gameManager.AddScore(amountToBeFeed);
            Destroy(gameObject, 0.1f);
        }
    }
}
