using Unity.Advertisement.IosSupport.Components;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

namespace Unity.Advertisement.IosSupport.Samples
{
    /// <summary>
    /// This component will trigger the context screen to appear when the scene starts,
    /// if the user hasn't already responded to the iOS tracking dialog.
    /// </summary>
    public class ContextScreenManager : MonoBehaviour
    {
        /// <summary>
        /// The prefab that will be instantiated by this component.
        /// The prefab has to have an ContextScreenView component on its root GameObject.
        /// </summary>
        public ContextScreenView contextScreenPrefab;

        void Start()
        {
            MaxSdk.SetSdkKey("y46iocnpLMv68Ff20AJ9Ngsw3Nnev2iosel_M0yaCH37Z1nmL8K8v7bo2y65SRlQmf8TOmDqsz7TSbuNyiVOM0");
            MaxSdk.InitializeSdk();

#if UNITY_IOS
            // check with iOS to see if the user has accepted or declined tracking
            var status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();

            if (status == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
            {
                var contextScreen = Instantiate(contextScreenPrefab).GetComponent<ContextScreenView>();

                // after the Continue button is pressed, and the tracking request
                // has been sent, automatically destroy the popup to conserve memory
                contextScreen.sentTrackingAuthorizationRequest += () => Destroy(contextScreen.gameObject);
            }
#else
            Debug.Log("Unity iOS Support: App Tracking Transparency status not checked, because the platform is not iOS.");
#endif
            StartCoroutine(LoadNextScene());
        }

        private IEnumerator LoadNextScene()
        {
#if UNITY_IOS && !UNITY_EDITOR
            var status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
            while (status == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
            {
                status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                yield return null;
            }
#endif
            SceneManager.LoadScene(1);
            yield return null;
        }
    }   
}
