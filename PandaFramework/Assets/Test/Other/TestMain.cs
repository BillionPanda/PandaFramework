using SK.Framework;
using SK.Framework.Networking;
using SK.Framework.Resource;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMain : MonoBehaviour
{
    public class WebInterface
    {
        public static string BaiDu
        {
            get
            {
                return "https://www.baidu.com/";
            }
        }
    }

    void Start()
    {
        //Main.Resource.LoadAssetAsync<Sprite>("Assets/Test/Res/avatar.jpg", (result, res) => {
        //    if (result)
        //        Debug.Log(res.ToString());
        //});

        //Main.WebRequest.Send(WebInterface.BaiDu, WebRequestData.Allocate(WebRequestType.GET),
        //    onSuccess: handler => Debug.Log(handler.text),
        //    onFailure: error => Debug.Log(string.Format("∑¢∆Õ¯¬Á«Î«Û ß∞‹£∫{0}", error)));

        WallGenerator wg = new WallGenerator();
}

    void Update()
    {
        
    }
}



