using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : Singleton<Core>
{
    public static UiSystem UI => Instance.ui;
    public static Data Data => Instance.data;
    public static InputHandler Controller => Instance.controller;

    [SerializeField] private UiSystem ui;
    [SerializeField] private Data data;
    [SerializeField] private InputHandler controller;

}
