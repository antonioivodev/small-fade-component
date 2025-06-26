using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class SmallFadeImageComponent : MonoBehaviour
{
    [SerializeField] private Image _imageComponent;
    [SerializeField] private float _fadeDurationDefaultTime = 1.0f;

    private Color _colorBuffer;

    private bool _fading;

    private void Awake()
    {
        if (_imageComponent == null)
        {
            _imageComponent = GetComponent<Image>();
        }
    }

    public void FadeIn()
    {
        Fade(_fadeDurationDefaultTime);
    }

    public void FadeOut()
    {
        Fade(_fadeDurationDefaultTime, false);
    }

    private void Fade(float waitTime, bool isFadeIn = true)
    {
        if (!_fading)
        {
            StartCoroutine(FadeCoroutine(waitTime, isFadeIn));
        }
    }

    private IEnumerator FadeCoroutine(float durationWaitTime, bool isFadeIn = true)
    {
        _fading = true;

        float time = 0;
        float value;
        _colorBuffer = _imageComponent.color;

        while (time < durationWaitTime)
        {
            value = isFadeIn ? time / durationWaitTime : 1 - time / durationWaitTime;
            time += Time.deltaTime;

            UpdateImageAlphaColor(value);

            yield return new WaitForEndOfFrame();
        }

        value = isFadeIn ? 1 : 0;

        UpdateImageAlphaColor(value);

        _fading = false;
        yield return new WaitForEndOfFrame();
    }

    private void UpdateImageAlphaColor(float alpha)
    {
        _colorBuffer.a = alpha;
        _imageComponent.color = _colorBuffer;
    }
}
