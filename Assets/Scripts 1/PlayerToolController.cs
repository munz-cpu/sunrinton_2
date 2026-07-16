using UnityEngine;

public class PlayerToolController : MonoBehaviour

{

    public float useRange = 2f;

    private Camera mainCam;

    private void Start()

    {

        mainCam = Camera.main;

    }

    private void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {

            TryUseTool();

        }

    }

    void TryUseTool()

    {

        Vector2 mousePos =

            mainCam.ScreenToWorldPoint(

                Input.mousePosition

            );

        RaycastHit2D hit =

            Physics2D.Raycast(

                mousePos,

                Vector2.zero

            );

        if (hit.collider == null)

            return;

        PixelBlock block =

            hit.collider.GetComponent<PixelBlock>();

        if (block == null)

            return;

        float distance =

            Vector2.Distance(

                transform.position,

                block.transform.position

            );

        Debug.Log("거리 : " + distance);

        if (distance <= useRange)

        {

            UseCurrentTool(block);

        }

        else

        {

            Debug.Log("너무 멀다");

        }

    }

    void UseCurrentTool(PixelBlock block)

    {

        ToolType currentTool =

            ToolSelector.Instance.currentTool;

        switch (currentTool)

        {

            case ToolType.Hammer:

                Debug.Log("망치 사용");

                block.BreakBlock();

                break;

            case ToolType.Tape:

                Debug.Log("테이프 사용");

                block.TapeBlock();

                break;

            case ToolType.Lens:

                Debug.Log("렌즈 사용");

                break;

            case ToolType.None:

                Debug.Log("도구를 선택하세요");

                break;

        }

    }

}