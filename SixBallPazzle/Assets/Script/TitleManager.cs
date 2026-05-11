using UnityEngine;

public class TitleManager : SingletonMonoBehaviour<TitleManager>
{
   public void StartGame()
   {
       SceneInstance.Instance.LoadSceneTitle();
    }
}
