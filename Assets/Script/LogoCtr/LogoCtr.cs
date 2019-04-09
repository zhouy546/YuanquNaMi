using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoCtr : MonoBehaviour
{
    public Image image;
    float RandomStart = 0;
    private float WaveIntensity = 1f;
    private float Y_StartLocalPos;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        RandomStart = Random.Range(-Mathf.PI, Mathf.PI);
        speed = Random.Range(0.1f, 0.5f);
        WaveIntensity = Random.Range(0.2f, 0.4f);
        Y_StartLocalPos = this.transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt((this.transform.position + Vector3.forward));
        UpdateMovement();
    }

    public void UpdateMovement()
    {
        //float y = 

        float y = Y_StartLocalPos + WaveIntensity * Mathf.Sin(Time.time * speed + RandomStart);

        Vector3 LocalPos = new Vector3(this.transform.localPosition.x, y, this.transform.localPosition.z);

        this.transform.localPosition = LocalPos;
    }

    public void Hide() {
        LeanTween.value(image.color.a, 0, 0.5f).setOnUpdate((float val) => {
            image.color = new Color(image.color.r, image.color.g, image.color.b, val);
        });
    }

    public void Show() {
        LeanTween.value(image.color.a, 255, 0.5f).setOnUpdate((float val) => {
            image.color = new Color(image.color.r, image.color.g, image.color.b, val);
        });
    }
}
