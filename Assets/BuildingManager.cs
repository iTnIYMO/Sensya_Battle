using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private int currentBuilding = 1;  // �j�󂷂�r���̏��Ԃ��Ǘ�����ϐ�

    private void OnTriggerEnter(Collider other)
    {
        // �r���̃^�O�� "Building1"�A"Building2"�A"Building3" �̏��ԂŔj�󂷂�悤�Ƀ`�F�b�N
        string expectedTag = "MikataBiru" + currentBuilding;

        // �Փ˂����I�u�W�F�N�g�����݂̏��Ԃ̃r�����m�F
        if (other.CompareTag(expectedTag))
        {
            Destroy(other.gameObject);  // �r����j��
            currentBuilding++;  // ���̃r���ɐi��

            // �S�Ẵr�����j�󂳂ꂽ�烁�b�Z�[�W��\��
            if (currentBuilding > 3)
            {
                Debug.Log("���ׂẴr�����j�󂳂�܂����I");
            }
        }
    }
}
