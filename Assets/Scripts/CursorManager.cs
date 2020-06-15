using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {
    private Vector3 cursorPos = Vector3.zero;
    private bool isCursonVisible = true;

    private void Update() {
        IsCursorMoving();
    }

    private bool IsCursorMoving() {
        Vector3 currentMousePos = Input.mousePosition;
        if (cursorPos != currentMousePos) {
            cursorPos = currentMousePos;
            return true;
        }
        return false;
    }

    public void ShowCursor(bool show) {
        Cursor.visible = show;
        isCursonVisible = show;
    }
}