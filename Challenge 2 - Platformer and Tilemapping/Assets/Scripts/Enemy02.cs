using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy02 : MonoBehaviour {

    Vector2 startPosition = new Vector2(17.56f, 2.75f);
    Vector2 endPosition = new Vector2(17.56f, 9.42f);

    // Update is called once per frame
    void Update() {

        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time, 1));

    }

}
