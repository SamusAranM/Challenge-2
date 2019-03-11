using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy08 : MonoBehaviour {

    Vector2 startPosition = new Vector2(52.12f, 9.06f);
    Vector2 endPosition = new Vector2(59.28f, 9.06f);

    // Update is called once per frame
    void Update() {

        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time, 1));

    }

}
