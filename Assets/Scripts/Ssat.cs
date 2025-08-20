using UnityEngine;

public class BallDropping : MonoBehaviour
{
    public Material trailMaterial; // Ƹ���� �������� ��� �����
    public float trailWidth = 0.2f; // ������ �����
    public float trailTime = 1f; // ����� ����� �����

    private TrailRenderer trail;
    public GameObject trailPrefab; // ������ ����� (Quad)
    public float dropInterval = 0f;
    public float yOffset = 0.01f; // ����� �� ���� z-fighting � �����

    private float nextDropTime;
    private bool isDropping = false;

    void Start()
    {
        // ������� � ����������� TrailRenderer
        trail = gameObject.AddComponent<TrailRenderer>();
        trail.material = trailMaterial;
        trail.startWidth = trailWidth;
        trail.endWidth = 0f;
        trail.time = trailTime;
        trail.enabled = false; // ���������� ���� ��������
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
            // ������� 1: ������ ������� ����� (����������� ������� ����)
            Vector3 dropPosition = new Vector3(
            transform.position.x,
            yOffset + 0.5f,
            transform.position.z
            );
            Quaternion flatRotation = Quaternion.Euler(90, 0, 0); // ������������ Quad �� 90 �������� �� X
            Instantiate(trailPrefab, dropPosition, flatRotation);

            // ���� ������� 2: ���� ����� �������� (� Raycast)
            /*
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit))
            {
                Vector3 dropPosition = hit.point + Vector3.up * yOffset;
                // ������������ Quad ����������� �����������
                Instantiate(trailPrefab, dropPosition, Quaternion.LookRotation(hit.normal) * Quaternion.Euler(90, 0, 0));
            }
            */
        }
    }
}