using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateCardPrefab  {

    const string menuTitle = "Cards/Create Card From Selected";
    const string menuTitle2 = "Cards/Update Cards";

    [MenuItem(menuTitle)]
    static void CreatePrefab(GameObject o = null)
    {
        GameObject obj;
        if (o == null) {
             obj = Selection.activeGameObject;
        }
        else
        {
            obj = o;
        }

        string name = obj.name;

        Object preFab = PrefabUtility.CreateEmptyPrefab("Assets/Prefabs/cards/Monsters/" + name + ".prefab");
        PrefabUtility.ReplacePrefab(obj, preFab);
        AssetDatabase.Refresh();
    }

    [MenuItem(menuTitle, true)]
    static bool ValidateCreatePrefab()
    {
        return Selection.activeGameObject != null;
    }

    [MenuItem(menuTitle2)]
    static void UpdatePrefav()
    {
        GameObject[] objs = Selection.gameObjects;

        foreach (GameObject o in objs)
        {
            CreatePrefab(o);
        }

        
    }

    [MenuItem(menuTitle2, true)]
    static bool ValidateUpdatesPrefab()
    {
        return Selection.activeGameObject != null;
    }
}
