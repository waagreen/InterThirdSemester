using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : Singleton<Core>
{
    public static UiSystem UI => Instance.ui;
    public static Data Data => Instance.data;

    [SerializeField] private UiSystem ui;
    [SerializeField] private Data data;
}
