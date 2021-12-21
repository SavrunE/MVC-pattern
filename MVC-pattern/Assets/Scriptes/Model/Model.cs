using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [SerializeField] private CubeFigure cube;
    [SerializeField] private SphereFigure sphere;

    private List<CubeFigure> cubes = new List<CubeFigure>();
    private List<SphereFigure> spheres = new List<SphereFigure>();

    public Action<int> OnCubesCountChange;
    public Action<int> OnSpheresCountChange;

    private void Start()
    {
        OnCubesCountChange?.Invoke(cubes.Count);
        OnSpheresCountChange?.Invoke(spheres.Count);
    }
    public void CreateCube(Vector3 position)
    {
        GameObject cubeInst = Instantiate(cube.gameObject);
        cubeInst.transform.position = position;
        CubeFigure cubeFigure = cubeInst.GetComponent<CubeFigure>();
        cubes.Add(cubeFigure);
        OnCubesCountChange?.Invoke(cubes.Count);
    }
    public void CreateSphere(Vector3 position)
    {
        GameObject sphereInst = Instantiate(sphere.gameObject);
        sphereInst.transform.position = position;
        SphereFigure sphereFigure = sphereInst.GetComponent<SphereFigure>();
        spheres.Add(sphereFigure);
        OnSpheresCountChange?.Invoke(spheres.Count);
    }
    public int CubesCount()
    {
        return cubes.Count;
    }
    public int SpheresCount()
    {
        return spheres.Count;
    }
    public void DestroyCube(CubeFigure cube)
    {
        if (cubes.IndexOf(cube) != 0)
        {
            cubes.Remove(cube);
            Destroy(cube.GetComponent<Rigidbody>());
        }
    }
    public void DestroyCube(SphereFigure sphere)
    {
        if (spheres.IndexOf(sphere) != 0)
        {
            spheres.Remove(sphere);
            Destroy(sphere.GetComponent<Rigidbody>());
        }
    }
}
