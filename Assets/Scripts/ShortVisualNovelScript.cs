using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortVisualNovelScript : MonoBehaviour
{
    // ed = ending | s = scene
    // each variable is named after their position in the story.
    GameObject main_menu, neutral_scene, ed1_s1, ed1_s2, ed2_s1, ed2_s2, ed3_s1, ending_1, ending_2, ending_3;
    // array of all scenes
    public GameObject[] Scenes;
    // determines which scene is currently active
    public int activeScene = 0;

    // Start is called before the first frame update
    void Start()
    {
        Scenes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeScene();
    }

    public void ChangeScene()

    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == activeScene);
        }
    }

    public void StartButton()
    {
        activeScene = 1;
    }

    public void ToEnding1()
    {
        activeScene = 2;
    }

    public void ContinueEnding1() 
    {
        activeScene = 3;
    }

    public void Ending1()
    {
        activeScene = 4;
    }

    public void ToEnding2()
    {
        activeScene = 5;
    }

    public void ContinueEnding2()
    {
        activeScene = 6;
    }

    public void Ending2()
    {
        activeScene = 7;
    }

    public void ToEnding3()
    {
        activeScene = 8;
    }

    public void Ending3()
    {
        activeScene = 9;
    }

    public void MainMenu()
    {
        activeScene = 0;
    }
}
