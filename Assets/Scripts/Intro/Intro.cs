using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject background;
    public GameObject Press;
    public GameObject Title;
    public GameObject nextSceneBtn;
    public GameObject blackImage;
    public GameObject prologueTxt;
    //public GameObject prefabBackground;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject test = Instantiate(prefabBackground);
        //DontDestroyOnLoad(test);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(background.GetComponent<Transform>().localPosition.x > -1000)
        {
            background.transform.localPosition += new Vector3(-1f, 0, 0);
        }     
    }

    public void PrologueStart()
    {
        Press.SetActive(false);
        background.SetActive(false);
        Title.SetActive(false);
        blackImage.SetActive(true);
        nextSceneBtn.SetActive(true);
        prologueTxt.SetActive(true);
    }

    public void NextScene()
    { 
        SceneManager.LoadScene("MainScene");
    }
}
