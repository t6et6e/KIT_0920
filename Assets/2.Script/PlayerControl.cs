using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()    //플레이 버튼 눌렀을때 한 번만, 클래스의 생성자와 같음
    {

    }
    // Update is called once per frame
    void Update()   //초당60번 반복
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
