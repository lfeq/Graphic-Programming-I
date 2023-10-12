using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosInteriorWithUV : MonoBehaviour {
    public Material mat;

    private Mesh mesh;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Start() {
        Vector3[] vertices = {
            //Base
            new Vector3 (4, 0, 0), //3
            new Vector3 (6, 0, 4), //6
            new Vector3 (2, 0, 4), //7
            //Side 1
            new Vector3 (4, 0, 0), //3
            new Vector3 (2, 4, 1.3f), //1
            new Vector3 (6, 4, 1.3f), //2
            //Side 2
            new Vector3 (2, 4, 1.3f), //7
            new Vector3 (2, 0, 4f), //8
            new Vector3 (4, 4, 5.3f), //9
            //Side 3
            new Vector3 (6, 0, 4), //6
            new Vector3 (4, 4, 5.3f), //4
            new Vector3 (6, 4, 1.3f), //5
        };

        int[] triangles = {
            //Base
            0, 1, 2,
            3, 4, 5,
            6, 7, 8,
            9, 10, 11,
        };

        Vector2[] uvs = {
            //Base
            new Vector2 (0.6f, 0.436f), //3
            new Vector2 (0.840f, 0.436f), //6
            new Vector2 (0.724f, 0.602f), //7
            //Side 1
            new Vector2 (0.597f, 0.438f), //3
            new Vector2 (0.845f, 0.438f), //1
            new Vector2 (0.719f, 0.262f), //2
            //Side 2
            new Vector2 (0.727f, 0.605f), //7
            new Vector2 (0.971f, 0.605f), //8
            new Vector2 (0.847f, 0.440f), //9
            //Side 3
            new Vector2 (0.597f, 0.778f), //6
            new Vector2 (0.844f, 0.778f), //4
            new Vector2 (0.722f, 0.607f), //5
        };

        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}