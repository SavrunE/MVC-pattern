using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Vector3[] positions;
    [SerializeField] private Model model;
    [SerializeField] private View view;

    private void OnEnable()
    {
        model.OnCubesCountChange += ChangeViewCubeCount;
        model.OnSpheresCountChange += ChangeViewSphereCount;
    }
    private void OnDisable()
    {
        model.OnCubesCountChange -= ChangeViewCubeCount;
        model.OnSpheresCountChange -= ChangeViewSphereCount;
    }
    public void CreateCube()
    {
        model.CreateCube(positions[Random.Range(0, positions.Length)]);
    }

    public void CreateSphere()
    {
        model.CreateSphere(positions[Random.Range(0, positions.Length)]);
    }

    public void ChangeViewCubeCount(int count)
    {
        view.ChangeCubeView(count);
    }

    public void ChangeViewSphereCount(int count)
    {
        view.ChangeSphereView(count);
    }

    public void DestroyCube()
    {

    }

    public void DestroySphere()
    {

    }
}
