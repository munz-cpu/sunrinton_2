using UnityEngine;

public class ToolSelector : MonoBehaviour

{

    public static ToolSelector Instance;

    public ToolType currentTool =

        ToolType.None;

    private void Awake()

    {

        Instance = this;

    }

    public void SelectHammer()

    {

        currentTool =

            ToolType.Hammer;

        Debug.Log("망치 선택");

    }

    public void SelectTape()

    {

        currentTool =

            ToolType.Tape;

        Debug.Log("테이프 선택");

    }

    public void SelectLens()

    {

        currentTool =

            ToolType.Lens;

        Debug.Log("렌즈 선택");

    }

}