using System;
using Object = UnityEngine.Object;

namespace PandaFramework.Resource 
{
    public interface IResouceComponent
    {
        /// <summary>
        /// �첽�����ʲ�
        /// </summary>
        /// <typeparam name="T">�ʲ�����</typeparam>
        /// <param name="assetPath">�ʲ�·��</param>
        /// <param name="onCompleted">������ɻص��¼�</param>
        /// <param name="onLoading">���ؽ��Ȼص��¼�</param>
        void LoadAssetAsync<T>(string assetPath, Action<bool, T> onCompleted, Action<float> onLoading) where T : Object;

        /// <summary>
        /// �첽���س���
        /// </summary>
        /// <param name="sceneAssetPath">�����ʲ�·��</param>
        /// <param name="onCompleted">������ɻص��¼�</param>
        /// <param name="onLoading">���ع��̻ص��¼�</param>
        void LoadSceneAsync(string sceneAssetPath, Action<bool> onCompleted, Action<float> onLoading);

        /// <summary>
        /// ж���ʲ�
        /// </summary>
        /// <param name="assetPath">�ʲ�·��</param>
        /// <param name="unloadAllLoadedObjects">�Ƿ�ж�����ʵ��������</param>
        void UnloadAsset(string assetPath, bool unloadAllLoadedObjects);

        /// <summary>
        /// ж�������ʲ�
        /// </summary>
        /// <param name="unloadAllLoadedObjects">�Ƿ�ж�����ʵ��������</param>
        void UnloadAllAsset(bool unloadAllLoadedObjects);

        /// <summary>
        /// ж�س���
        /// </summary>
        /// <param name="sceneAssetPath">�����ʲ�·��</param>
        /// <returns>true��ж�سɹ�  false��ж��ʧ��</returns>
        bool UnloadScene(string sceneAssetPath);

        /// <summary>
        /// �첽ʵ����
        /// </summary>
        /// <typeparam name="T">�ʲ�����</typeparam>
        /// <param name="assetPath">�ʲ�·��</param>
        /// <param name="onCompleted">����ص��¼�</param>
        /// <param name="onProgress">���Ȼص��¼�</param>
        void InstantiateAsync<T>(string assetPath, Action<bool, T> onCompleted, Action<float> onProgress) where T : Object;
    }
}

