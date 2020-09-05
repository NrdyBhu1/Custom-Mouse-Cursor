using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    public Texture2D pointer;
    public Texture2D hand;
    #endregion

    void Start()
    {
        setPointer();
    }

    public void setHand(){
        Cursor.SetCursor(hand, new Vector2(0, 0), CursorMode.ForceSoftware);
    }

    public void setPointer(){
        Cursor.SetCursor(pointer, new Vector2(0, 0), CursorMode.ForceSoftware);
    }
}
