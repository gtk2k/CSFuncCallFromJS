using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestLib : MonoBehaviour
{

    public delegate void dlgOnHtmlButtonClick(int arg);
    public static event dlgOnHtmlButtonClick OnHtmlButtonClick;

    [DllImport("__Internal")]
    private static extern void init(Action<int> btnClickCallback);

    [MonoPInvokeCallback(typeof(Action<int>))]
    private static void htmlButtonClick(int arg)
    {
        OnHtmlButtonClick?.Invoke(arg);
    }

    void Start()
    {
        init(htmlButtonClick);
    }
}
