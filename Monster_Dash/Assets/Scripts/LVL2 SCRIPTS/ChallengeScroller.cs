using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScroller : MonoBehaviour
{
    public float scrollSpeed = 5.0f;

    void Update()
    {
        GameObject currentChild;

        for (int i = 0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            ScrollChallenge(currentChild);
            if (currentChild.transform.position.x <= -15.0f)
            {
                Destroy(currentChild);
            }
        }
    }

    void ScrollChallenge(GameObject currentChallenge)
    {
        currentChallenge.transform.position -= Vector3.right * (scrollSpeed*Time.deltaTime);
    }
}
