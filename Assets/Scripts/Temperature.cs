using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    [SerializeField]
    Scrollbar bar;
    [SerializeField]
    TextMeshProUGUI treeCount;
    [SerializeField]
    TextMeshProUGUI temperatureTxt;
    [SerializeField]
    Transform Backtrees;
    [SerializeField]
    Transform Midtrees;
    [SerializeField]
    Transform Foretrees;
    SpriteRenderer sprite;
    [SerializeField]
    Color color0;
    [SerializeField]
    Color color1;
    [SerializeField]
    Color color2;
    [SerializeField]
    Color color3;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        treeCount.text = "Count : " + Mathf.RoundToInt(1000 - 1000 * bar.value); 
        if (bar.value <= 0.17) 
        {
            temperatureTxt.text = "+ " + 0.1 +" C";
            sprite.color = color0;
            Backtrees.gameObject.SetActive(true);
            Midtrees.gameObject.SetActive(true);
            Foretrees.gameObject.SetActive(true);
        }
        else if (bar.value <= 0.5)
        {
            temperatureTxt.text = "+ " + 1 + " C";
            sprite.color = color1;
            Backtrees.gameObject.SetActive(false);
            Midtrees.gameObject.SetActive(true);
            Foretrees.gameObject.SetActive(true);
        }
        else if (bar.value <= 0.84)
        {
            temperatureTxt.text = "+ " + 2 + " C";
            sprite.color = color2;
            Backtrees.gameObject.SetActive(false);
            Midtrees.gameObject.SetActive(false);
            Foretrees.gameObject.SetActive(true);
        }
        else if (bar.value <= 1)
        {
            temperatureTxt.text = "+ " + 3 + " C";
            sprite.color = color3;
            Backtrees.gameObject.SetActive(false);
            Midtrees.gameObject.SetActive(false);
            Foretrees.gameObject.SetActive(false);
        }
    }
}
