using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private string sceneTransitionName;

    private float waitToloadTime = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<PlayerController>())
        {
            UIFade.Instance.FadeToBlack();
            StartCoroutine(LoadSceneRoutine());
            SceneManagement.Instance.SetTransitionName(sceneTransitionName);
        }
    }

    private IEnumerator LoadSceneRoutine()
    {
        yield return new WaitForSeconds(waitToloadTime);
        SceneManager.LoadScene(sceneToLoad);
    }
}
