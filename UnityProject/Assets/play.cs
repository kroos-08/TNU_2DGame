
using UnityEngine;
public class play : MonoBehaviour
{
    // 定義蘭位 Field 
    // 闌位類型名稱（指定植）結尾/浮點數
    //預設 private 私人 （在屬性面板上隱藏）
    // public 公開 （在屬性面板上顯示）
    [Header("速度")][Range（0f,100f)]
    float speed = 3.5f;                   //浮點數結尾要有 f
    int jump = 300;                       //整數
    bool isGround = false;                //佈林志 - true `false
    string name = "DANG";                  //字串需要用雙引號
}
