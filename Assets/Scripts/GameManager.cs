using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ChangeToOpening()
    {
        SceneManager.LoadScene("Opening");
    }
}