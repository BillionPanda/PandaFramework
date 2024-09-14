using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace PandaFramework.Resource 
{
    [DisallowMultipleComponent]
    [AddComponentMenu("PandaFramework/Resource")]
    public class ResourceComponent : MonoBehaviour, IResouceComponent
    {
        public enum MODE 
        {
            EDITOR,
            SIMULATIVE,
            REALITY,
        }

        [SerializeField] private MODE mode = MODE.EDITOR;

        [SerializeField] private string assetBundleUrl = Application.streamingAssetsPath;

        [SerializeField] private string assetBundleManifestName = "AssetBundles";

        private AssetBundleManifest assetBundleManifest;
        private bool isAssetBundleManifestLoading;

        //private Dictionary<string, AssetInfo> map = new Dictionary<string, AssetInfo>();
        private bool isMapLoading = true;

        private readonly Dictionary<string, AssetBundle> assetBundlesDic = new Dictionary<string, AssetBundle>();

        //private readonly Dictionary<string, Scene> sceneDic = new Dictionary<string, Scene>();

        private readonly Dictionary<string, UnityWebRequest> loadingDic = new Dictionary<string, UnityWebRequest>();


        void Start()
        {

        }

        public void InstantiateAsync<T>(string assetPath, Action<bool, T> onCompleted, Action<float> onProgress) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public void LoadAssetAsync<T>(string assetPath, Action<bool, T> onCompleted, Action<float> onLoading) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public void LoadSceneAsync(string sceneAssetPath, Action<bool> onCompleted, Action<float> onLoading)
        {
            throw new NotImplementedException();
        }

        public void UnloadAllAsset(bool unloadAllLoadedObjects)
        {
            throw new NotImplementedException();
        }

        public void UnloadAsset(string assetPath, bool unloadAllLoadedObjects)
        {
            throw new NotImplementedException();
        }

        public bool UnloadScene(string sceneAssetPath)
        {
            throw new NotImplementedException();
        }
    }
}


