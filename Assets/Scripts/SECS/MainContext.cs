using System.Collections;
using UnityEngine;

namespace RPG.SECS
{
    public class MainContext : MonoBehaviour // : UnityContext<MainCompositionRoot>
    {
        public GameObject player;
        public GameObject target;

        void Awake()
        {
            _applicationRoot = new MainCompositionRoot(player, target);

            _applicationRoot.OnContextCreated(this);
        }

        void OnDestroy()
        {
            _applicationRoot.OnContextDestroyed();
        }

        void Start()
        {
            if (Application.isPlaying == true)
                StartCoroutine(WaitForFrameworkInitialization());
        }

        IEnumerator WaitForFrameworkInitialization()
        {
            //let's wait until the end of the frame, so we are sure that all the awake and starts are called
            yield return new WaitForEndOfFrame();

            _applicationRoot.OnContextInitialized(this);
        }

        MainCompositionRoot _applicationRoot;
    }
}
