using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy03 : MonoBehaviour {

    Vector2 startPosition = new Vector2(27.46f, 5.67f);
    Vector2 endPosition = new Vector2(22.79f, 5.67f);

    // Update is called once per frame
    void Update() {

        transform.position = Vector2.Lerp(startPosition, endPosition, Mathf.PingPong(Time.time, 1));

    }

}
