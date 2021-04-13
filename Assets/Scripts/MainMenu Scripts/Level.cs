using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private Button levelBtn;

    public int levelReq;

    void Start()
    {
        levelBtn = GetComponent<Button>();

        if (PlayerPrefs.GetInt("Level", 1) >= levelReq)
        {
            levelBtn.onClick.AddListener(() => LoadLevel());
            GetComponent<CanvasGroup>().alpha = 1f;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = .5f;
        }

        transform.GetChild(0).GetComponent<Text>().text = levelReq.ToString();

    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(gameObject.name);
    }
}
