using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Vector3[] positions;
    [SerializeField] private Model model;
    [SerializeField] private View view;

    private void Start()
    {
        ChangeViewCubeCount();
        ChangeViewSphereCount();
    }
    public void CreateCube()
    {
        model.CreateCube(positions[Random.Range(0, positions.Length)]);
        ChangeViewCubeCount();
    }
    public void CreateSphere()
    {
        model.CreateSphere(positions[Random.Range(0, positions.Length)]);
        ChangeViewSphereCount();
    }
    public void ChangeViewCubeCount()
    {
        view.ChangeCubeView(model.CubesCount());
    }
    public void ChangeViewSphereCount()
    {
        view.ChangeSphereView(model.SpheresCount());
    }
    public void DestroyCube()
    {

    }
    public void DestroySphere()
    {

    }
}
