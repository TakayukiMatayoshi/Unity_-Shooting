using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_main : MonoBehaviour
{
    public GameObject[] shot;
    public int[] Firerate;
    float shottime;

    public GameObject player;
    float moveX;
    float moveY;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        shottime += Time.deltaTime;

        if (Input.GetButton("Fire1") && shottime >= 1 / (float)Firerate[0])
        {
            PlayershotMain();
            shottime = 0;
        }

        //if (Input.GetButtonDown("x")) PlayershotSub();

        moveX = Input.GetAxisRaw("Horizontal") / 10;
        moveY = Input.GetAxisRaw("Vertical") / 10;
        if (moveX != 0 || moveY != 0) PlayerMove();
    }

    void PlayerMove()
    {
        player.transform.Translate(moveX, moveY, 0);
    }

    void PlayershotMain()
    {
        Instantiate(
            shot[0],
            player.transform.position,
            Quaternion.identity
            );
    }

    void PlayershotSub()
    {

    }
}
