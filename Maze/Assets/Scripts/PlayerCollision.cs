using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public int theScore;
    public Text scoreValue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Token")
        {
            theScore += 1;
            scoreValue.GetComponent<Text>().text = theScore.ToString();
        }
    }


}

