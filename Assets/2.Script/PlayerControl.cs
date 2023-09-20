using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()    //�÷��� ��ư �������� �� ����, Ŭ������ �����ڿ� ����
    {

    }
    // Update is called once per frame
    void Update()   //�ʴ�60�� �ݺ�
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.GetComponentInChildren<Animator>().SetTrigger("action_z");
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print(hit.gameObject.name);
        if (hit.collider.CompareTag("END"))
        {
            //Destroy(hit.collider.gameObject);
            SceneManager.LoadScene("END");
        }
    }
}
