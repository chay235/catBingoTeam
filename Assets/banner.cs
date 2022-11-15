using System;
using UnityEngine;
using GoogleMobileAds.Api;

public class banner : MonoBehaviour
{
    private BannerView bannerView;


    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-5598518304408848/7273206627";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-5598518304408848/7273206627";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);

    }
}
