using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01 : MonoBehaviour {

    Vector2 startPosition = new Vector2(2.43f, 2.75f);
    Vector2 endPosition = new Vector2(10.6f, 2.75f);

    // Update is called once per frame
    void Update() {

        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time, 1));

    }

}
