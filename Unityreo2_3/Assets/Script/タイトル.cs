using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class タイトル : MonoBehaviour
{
    public bool canMoveNext; // falseにしておく
    public float startDelaytimes;
    // 画面繊維可能メッセージ
    GameObject nextText;
    public bool waitflag; // 普通はfalseにしておく

    // 主人公のライフ
    public int life;

    // 敵のライフ
    public int enemyLife;

    // Use this for initialization
    public void Start()
    {
        nextText = GameObject.Find("nextText");
        nextText.SetActive(false);
        Invoke("startDelay", startDelaytimes);
    }

    // Update is called once per frame
    public void Update()
    {
        gameMain();
        if (Input.GetKeyUp(KeyCode.Space) && waitflag == true && canMoveNext == true)
        {
            SceneManager.LoadScene("じゃんけん_1");
        }
    }
    void startDelay()
    {
        waitflag = true;
    }
    public void actJanken()
    {

    }
    public void gameMain()
    {
        actJanken();
        // ゲームオーバー
        if (life <= 0)
        {
            // ゲームオーバー処理
            SceneManager.LoadScene("ゲームオーバー");
        }

        // 勝利！
        if (enemyLife <= 0)
        {
            // 画面遷移可能処理
            nextText.SetActive(true);
            canMoveNext = true;
        }
    }
}