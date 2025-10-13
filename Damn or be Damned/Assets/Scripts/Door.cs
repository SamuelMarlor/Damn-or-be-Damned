using UnityEngine;

//public class Door : MonoBehaviour
//{
//    public bool isOpen = false;
//    [SerializeField]
//    private bool isRotating = true;
//    [SerializeField]
//    private float speed = 1f;
//    [Header("Roatation Configs")]
//    [SerializeField]
//    private float rotationAmount = 90f;
//    [SerializeField]
//    private float forwardDirection = 0f;

//    private Vector3 startRotation;
//    private Vector3 Forward;

//    private Coroutine animationCoroutine;

//    private void Awake()
//    {
//        startRotation = transform.rotation.eulerAngles;
//        Forward = transform.right;
//    }

//    public void Open (Vector3 UserPosition)
//    {
//        if (!isOpen) return;
//        {
//            if (animationCoroutine != null)
//                StopCoroutine(animationCoroutine);
//        }
        
//        if (isRotatingDoor)
//        {
//            float dot = Vector3.Dot(Forward, (UserPosition - transform.position).normalized);
//            Debug.log($"Dot: {dot.ToString("N3")}");
//            animationCoroutine = StartCoroutine(DoRotationOpen(dot));
//        }
//    }

//    private IEnumerator DoRotationOpen(float ForwardAmount)
//    {
//        Quaternion startRotation = transform.rotation;
//        Quaternion endRotation;

//        if (ForwardAmount >= forwardDirection)
//        {
//            endRotation = Quaternion.Euler(new Vector3(0, startRotationRotation.y - rotationAmount,0));
//        }
//        else
//        {
//            endRotation = Quaternion.Euler(new Vector3(0, startRotationRotation.y + rotationAmount, 0));
//        }

//        isOpen = true;

//        float time = 0;
//        while (time < 1)
//        {
//            transform.rotation = Quaternion.Slerp(startRotation, endRotation, time);
//            yield return null;
//            time += Time.deltaTime * speed;
//        }
//    }
//}
