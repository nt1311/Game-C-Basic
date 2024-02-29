using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionScript : MonoBehaviour
{
    private int minionIndex;

    // Đặt vị trí hoặc bất kỳ thuộc tính nào khác bạn cần
    public void SetPosition(int index)
    {
        this.minionIndex = index;
        // Bạn có thể đặt bất kỳ thuộc tính nào khác hoặc thực hiện khởi tạo bổ sung ở đây
    }
}
