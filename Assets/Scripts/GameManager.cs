using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject _dynamic;
    public GameObject playerPrefab;

    public void StartGame(GameObject playerBtn) {
        Instantiate(playerPrefab, Vector3.zero, Quaternion.identity, _dynamic.transform);
        Destroy(playerBtn);
    }
}