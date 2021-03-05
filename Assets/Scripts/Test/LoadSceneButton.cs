using UnityEngine.SceneManagement;
using Utils;

namespace Test
{
    public class LoadSceneButton : ButtonHandler
    {
        public int sceneId;
        protected override void OnClick() => SceneManager.LoadScene(sceneId);
    }
}