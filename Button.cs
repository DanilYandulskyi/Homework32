using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private int _gameSceneIndex;
    [SerializeField] private Image _authors;

    public void Play()
    {
        SceneManager.LoadScene(_gameSceneIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowAuthors()
    {
        _authors.gameObject.SetActive(true);
    }
}
