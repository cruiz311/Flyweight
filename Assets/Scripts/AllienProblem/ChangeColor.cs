using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer rend;
    public MaterialPropertyBlock propblock;
    public float intervaloTiempo = 0.5f;
    private float tiempoPasado = 0f;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        propblock = new MaterialPropertyBlock();
    }
    public void Update()
    {
        rend.GetPropertyBlock(propblock);
        propblock.SetColor(name = "_Color", value: ChageColorAzar());
        rend.SetPropertyBlock(propblock);

        tiempoPasado += Time.deltaTime;
        if (tiempoPasado >= intervaloTiempo)
        {
            
        }
    }
    private Color ChageColorAzar()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }
}
