using UnityEngine;
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        prbivate Vector2 moveInput;
    public void OnMove(InoutValue value)
    {
        moveInput = value.Get<Vector2>();
    }
        // Update is called once per frame
        void Update()
    {
        if(moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if(moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(Vector3.right * moveInput x * Time.deltaTime);
    }
}
