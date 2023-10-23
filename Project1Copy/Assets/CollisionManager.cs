using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour
{
    public GameObject sphere; // ссылка на шар
    public GameObject cube; // ссылка на куб
    public Text collisionCountText; // ссылка на элемент пользовательского интерфейса текста

    private Rigidbody sphereRigidbody;
    private Rigidbody cubeRigidbody;
    private Vector3 sphereStartPosition;
    private Vector3 cubeStartPosition;
    private int collisionCount;

    private void Start()
    {
        sphereRigidbody = sphere.GetComponent<Rigidbody>();
        cubeRigidbody = cube.GetComponent<Rigidbody>();
        sphereStartPosition = sphere.transform.position;
        cubeStartPosition = cube.transform.position;
        collisionCount = 0;
    }

    public void OnButtonClick()
    {
        // Сбрасываем параметры
        sphereRigidbody.velocity = Vector3.zero;
        cubeRigidbody.velocity = Vector3.zero;
        sphere.transform.position = sphereStartPosition;
        cube.transform.position = cubeStartPosition;
        collisionCount++;
        
        // Обновляем текст
        UpdateCollisionCountText();

        // Запускаем движение объектов
        sphereRigidbody.AddForce(Vector3.right * 5f, ForceMode.Impulse);
        cubeRigidbody.AddForce(Vector3.left * 5f, ForceMode.Impulse);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    // Увеличиваем счетчик столкновений
        

    //    // Обновляем текст
        
    //}

    private void UpdateCollisionCountText()
    {
        collisionCountText.text = "Количество: " + collisionCount.ToString();
    }
}
