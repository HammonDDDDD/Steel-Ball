using UnityEngine;

public class BallDropping : MonoBehaviour
{
    public Material trailMaterial; // Жёлтый материал для следа
    public float trailWidth = 0.2f; // Ширина следа
    public float trailTime = 1f; // Время жизни следа

    private TrailRenderer trail;
    public GameObject trailPrefab; // Префаб следа (Quad)
    public float dropInterval = 0f;
    public float yOffset = 0.01f; // Чтобы не было z-fighting с землёй

    private float nextDropTime;
    private bool isDropping = false;

    void Start()
    {
        // Создаем и настраиваем TrailRenderer
        trail = gameObject.AddComponent<TrailRenderer>();
        trail.material = trailMaterial;
        trail.startWidth = trailWidth;
        trail.endWidth = 0f;
        trail.time = trailTime;
        trail.enabled = false; // Изначально след выключен
    }
    void Update()
    {
        if (Settings.Sanya)
            if (Input.GetKeyDown(KeyCode.X))
            {
                isDropping = true;
                trail.enabled = true;
            }

            if (Input.GetKeyUp(KeyCode.X))
            {
                isDropping = false;
                trail.enabled = false;
            }

            if (isDropping && Time.time > nextDropTime)
            {
                DropTrail();
                nextDropTime = Time.time + dropInterval;
            }
    }

    void DropTrail()
    {
        if (Settings.Sanya)
        {
            // Вариант 1: Просто плоские следы (параллельно мировым осям)
            Vector3 dropPosition = new Vector3(
            transform.position.x,
            yOffset + 0.5f,
            transform.position.z
            );
            Quaternion flatRotation = Quaternion.Euler(90, 0, 0); // Поворачиваем Quad на 90 градусов по X
            Instantiate(trailPrefab, dropPosition, flatRotation);

            // Либо Вариант 2: Если земля неровная (с Raycast)
            /*
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit))
            {
                Vector3 dropPosition = hit.point + Vector3.up * yOffset;
                // Поворачиваем Quad параллельно поверхности
                Instantiate(trailPrefab, dropPosition, Quaternion.LookRotation(hit.normal) * Quaternion.Euler(90, 0, 0));
            }
            */
        }
    }
}