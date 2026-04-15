using UnityEngine;

public class MyBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)  //유니티에서 지원해주는 충돌 체크 함수
    {
        Debug.Log(collision.gameObject.name + "와 충돌함");

        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("땅과 충돌");
        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("트리어 안으로 들어옴");
        }

        //void OnTriggerE
    }
}
