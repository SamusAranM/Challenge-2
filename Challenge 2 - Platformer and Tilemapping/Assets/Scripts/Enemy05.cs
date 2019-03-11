using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy05 : MonoBehaviour {

    Vector2 startPosition = new Vector2(46.42f, 2.75f);
    Vector2 endPosition = new Vector2(46.42f, 8.9f);

    // Update is called once per frame
    void Update() {

        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time, 1));

    }

}
