using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


namespace SgLib
{
    public class AdsManager : MonoBehaviour, IUnityAdsListener
    {

        string placement = "rewardedVideo";


        void Start()
        {
            Advertisement.AddListener(this);
            Advertisement.Initialize("3888827", true);
        }

        public void ShowAd(string p)
        {
            Advertisement.Show(p);
        }

        public void OnUnityAdsDidError(string message)
        {

        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            if (showResult == ShowResult.Finished)
            {
                CoinManager.Instance.AddCoins(10);
            }
            else if(showResult == ShowResult.Failed)
            {
                //You little piece of *#@*
            }
        }

        public void OnUnityAdsDidStart(string placementId)
        {

        }

        public void OnUnityAdsReady(string placementId)
        {

        }


        void Update()
        {

        }
    }
}