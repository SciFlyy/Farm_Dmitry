using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private SheepProperty sheepProperty;
    
    [SerializeField] private float startSpeed;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float force;
    [SerializeField] private GameObject heartParticlePrefab; //�������� ������
    [SerializeField] private Vector3 sheepOffset;

    [SerializeField] private float jumpForce;
    //������� ������ ����� ����, ������
    //���� ��� � ��������� ����
    private Rigidbody rb;
    private BoxCollider bc;
    private float moveSpeed;

    private MeshRenderer nb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
        nb = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        Debug.Log(sheepProperty.Name); // get
        sheepProperty.Name = "Baran"; //set
        Debug.Log(sheepProperty.Name); // get



        moveSpeed = sheepProperty.Speed;
        nb.material = sheepProperty.Material;
    }

    void Update()
    {
        //��������� ��������� � ���� ������ ���� ���� ����
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }


    public void SaveSheep()
    {
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * force);
        ///////////////////////// ��� ������
        moveSpeed = 0;      //1. ��������� �������� ���� �� 0 ��� ��� � ��������!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ������� ��������� ����
        bc.enabled = false; //2. ��������� ���� ��������� ����
        rb.useGravity = false; //3. ��������� ����������
        //4. �������� ������ �� ������� ��� ����� ��� �� �����
        //������� ������ � ������� ���� +
        GameObject particle = Instantiate(heartParticlePrefab, transform.position + sheepOffset, heartParticlePrefab.transform.rotation); // senoPrefab.transform.rotation
        Destroy(particle, 2f);
        Destroy(gameObject, 0.9f);
    }


    public void JumpThrowWater()
    {
        //��������� ���������� -��������� �������� - ������ ��� ���� 
        rb.isKinematic = false;
        moveSpeed = 0; //��������� ����
        rb.AddForce(new Vector3(0f, 1f, -1f) * jumpForce);
    }

    public void LandThrowWater()
    {
        //-�������� ���������� - ������������ ��������
        rb.isKinematic = true;
        moveSpeed = startSpeed; //��������� ����
    }



}