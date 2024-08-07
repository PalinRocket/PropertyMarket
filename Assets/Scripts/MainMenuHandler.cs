using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class MainMenuHandler : MonoBehaviour
{
    private Animator cameraAnimator;
    private Animator fadeoutAnimator;
    private float timeToWait = 2f;

    public void Awake()
    {
        fadeoutAnimator = GameObject.FindWithTag("Canvas").GetComponent<Animator>();
        cameraAnimator = GameObject.FindWithTag("MainCamera").GetComponent<Animator>();
    } 

    public void LoadGameScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int index)
    {
        fadeoutAnimator.SetTrigger("CanvasFadeout");
        cameraAnimator.SetTrigger("MoveCamera");
        
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(index);
    }
}
