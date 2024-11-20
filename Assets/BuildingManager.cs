using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private int currentBuilding = 1;  // 破壊するビルの順番を管理する変数

    private void OnTriggerEnter(Collider other)
    {
        // ビルのタグが "Building1"、"Building2"、"Building3" の順番で破壊するようにチェック
        string expectedTag = "MikataBiru" + currentBuilding;

        // 衝突したオブジェクトが現在の順番のビルか確認
        if (other.CompareTag(expectedTag))
        {
            Destroy(other.gameObject);  // ビルを破壊
            currentBuilding++;  // 次のビルに進む

            // 全てのビルが破壊されたらメッセージを表示
            if (currentBuilding > 3)
            {
                Debug.Log("すべてのビルが破壊されました！");
            }
        }
    }
}
