using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosWithUV : MonoBehaviour {
    public Material mat;

    private Mesh mesh;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Start() {
        Vector3[] vertices =
        {
            //Base pyramid 1
            new Vector3 (0.0f, 0.0f, 0.0f), //3
            new Vector3 (4.0f, 0f, 0f), //4
            new Vector3 (2.0f, 0f, 4.0f), //1

            //Side 1 pyramid 1
            new Vector3 (2, 4, 1.3f), //0
            new Vector3 (2.0f, 0f, 4.0f), //1
            new Vector3 (0.0f, 0.0f, 0.0f), //3

            //Side 2 pyramid 1
            new Vector3 (2, 4, 1.3f), //2
            new Vector3 (4.0f, 0f, 0f), //4
            new Vector3 (2.0f, 0f, 4.0f), //1

            //Side 3 pyramid 1
            new Vector3 (2, 4, 1.3f), //5
            new Vector3 (0.0f, 0.0f, 0.0f), //3
            new Vector3 (4.0f, 0f, 0f), //4

            //Base pyramid 2
            new Vector3 (4.0f, 0.0f, 0.0f), //9
            new Vector3 (8.0f, 0.0f, 0.0f), //11
            new Vector3 (6.0f, 0.0f, 4.0f), //10

            //Side 1 pyramid 2
            new Vector3 (6.0f, 4.0f, 1.3f), //6
            new Vector3 (4.0f, 0.0f, 0.0f), //9
            new Vector3 (6.0f, 0.0f, 4.0f), //10

            //Side 2 pyramid 2
            new Vector3 (6.0f, 4.0f, 1.3f), //7
            new Vector3 (8.0f, 0.0f, 0.0f), //11
            new Vector3 (6.0f, 0.0f, 4.0f), //10

            //Side 3 pyramid 2
            new Vector3 (6.0f, 4.0f, 1.3f), //8
            new Vector3 (8.0f, 0.0f, 0.0f), //11
            new Vector3 (4.0f, 0.0f, 0.0f), //9

            //Base pyramid 3
            new Vector3 (2.0f, 0f, 4.0f), //16
            new Vector3 (6.0f, 0.0f, 4.0f), //17
            new Vector3 (4.0f, 0.0f, 8.0f), //15

            //Side 1 pyramid 3
            new Vector3 (4, 4, 5.3f), //12
            new Vector3 (4.0f, 0.0f, 8.0f), //15
            new Vector3 (2.0f, 0f, 4.0f), //16

            //Side 2 pyramid 3
            new Vector3 (4, 4, 5.3f), //13
            new Vector3 (6.0f, 0.0f, 4.0f), //17
            new Vector3 (4.0f, 0.0f, 8.0f), //15

            //Side 3 pyramid 3
            new Vector3 (4, 4, 5.3f), //13
            new Vector3 (2.0f, 0f, 4.0f), //16
            new Vector3 (6.0f, 0.0f, 4.0f), //17

            //Base pyramid 4
            new Vector3 (6, 4, 1.3f), //21
            new Vector3 (2, 4, 1.3f), //23
            new Vector3 (4, 4, 5.3f), //22

            //Side 1 pyramid 4
            new Vector3 (4, 8, 2.6f), //18
            new Vector3 (6, 4, 1.3f), //21
            new Vector3 (4, 4, 5.3f), //22

            //Side 2 pyramid 4
            new Vector3 (4, 8, 2.6f), //19
            new Vector3 (2, 4, 1.3f), //23
            new Vector3 (4, 4, 5.3f), //22

            //Side 3 pyramid 4
            new Vector3 (4, 8, 2.6f), //20
            new Vector3 (6, 4, 1.3f), //21
            new Vector3 (2, 4, 1.3f), //23
        };

        int[] triangles =
        {
            0, 1, 2, //Base pyramid 1
            3, 4, 5, //Side 1 pyramid 1
            6, 7, 8, //Side 2 pyramid 1
            9, 10, 11, //Side 3 pyramid 1
            12, 13, 14, //Base pyramid 2
            15, 16, 17, //Side 1 pyramid 2
            18, 19, 20, //Side 2 pyramid 2
            21, 22, 23, //Side 3 pyramid 2
            24, 25, 26, //Base pyramid 3
            27, 28, 29, //Side 1 pyramid 3
            30, 31, 32, //Side 2 pyramid 3
            33, 34, 35, //Side 3 pyramid 3
            36, 37, 38, //Base pyramid 4
            39, 40, 41, //Side 1 pyramid 4
            42, 43, 44, //Side 2 pyramid 4
            45, 46, 47, //Side 3 pyramid 4
        };

        Vector2[] uvs = {
            //Base pyramid 1
            new Vector2 (0.410f, 0.955f), //1
            new Vector2 (0.294f, 0.790f), //3
            new Vector2 (0.530f, 0.790f), //4

            //Side 1 pyramid 1
            new Vector2 (0.162f, 0.955f), //0
            new Vector2 (0.410f, 0.955f), //1
            new Vector2 (0.294f, 0.790f), //3

            ////Side 2 pyramid 1
            new Vector2 (0.665f, 0.955f), //2
            new Vector2 (0.530f, 0.790f), //4
            new Vector2 (0.410f, 0.955f), //1

            ////Side 3 pyramid 1
            new Vector2 (0.408f, 0.617f), //5
            new Vector2 (0.294f, 0.790f), //3
            new Vector2 (0.530f, 0.790f), //4

            //Base pyramid 2
            new Vector2(0.145f, 0.596f), //9
            new Vector2(0.387f, 0.596f), //11
            new Vector2(0.262f, 0.432f), //10

            //Side 1 pyramid 2
            new Vector2(0.018f, 0.432f), //6
            new Vector2(0.145f, 0.596f), //9
            new Vector2(0.262f, 0.432f), //10

            //Side 2 pyramid 2
            new Vector2 (0.513f, 0.428f), //7
            new Vector2(0.262f, 0.432f), //10
            new Vector2(0.387f, 0.596f), //11

            //Side 3 pyramid 2
            new Vector2 (0.266f, 0.769f), //8
            new Vector2(0.145f, 0.596f), //9
            new Vector2(0.387f, 0.596f), //11

            //Base pyramid 3
            new Vector2 (0.178f, 0.219f), //16
            new Vector2 (0.421f, 0.219f), //17
            new Vector2 (0.298f, 0.388f), //15

            //Side 1 pyramid 3
            new Vector2 (0.051f, 0.392f), //12
            new Vector2 (0.298f, 0.388f), //15
            new Vector2 (0.178f, 0.219f), //16

            //Side 2 pyramid 3
            new Vector2 (0.549f, 0.390f), //13
            new Vector2 (0.421f, 0.219f), //17
            new Vector2 (0.298f, 0.388f), //15

            //Side 3 pyramid 3
            new Vector2 (0.299f, 0.047f), //14
            new Vector2 (0.178f, 0.219f), //16
            new Vector2 (0.421f, 0.219f), //17

            //Base pyramid 4
            new Vector2 (0.493f, 0.212f), //21
            new Vector2 (0.729f, 0.212f), //23
            new Vector2 (0.605f, 0.045f), //22

            //Side 1 pyramid 4
            new Vector2 (0.355f, 0.043f), //18
            new Vector2 (0.605f, 0.045f), //22
            new Vector2 (0.493f, 0.212f), //21

            //Side 2 pyramid 4
            new Vector2 (0.851f, 0.043f), //19
            new Vector2 (0.605f, 0.045f), //22
            new Vector2 (0.729f, 0.212f), //23

            //Side 3 pyramid 4
            new Vector2(0.606f, 0.383f), //20
            new Vector2 (0.493f, 0.212f), //21
            new Vector2 (0.729f, 0.212f), //23
        };

        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}