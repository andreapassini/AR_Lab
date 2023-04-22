using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class ChangeColorClickHandler : MonoBehaviour, IPointerClickHandler
{
    public AudioClip audioClip;
    private Animator _animator;
    private static readonly int _Touch = Animator.StringToHash("touch");
    private bool _playingAnim = false;

    private void Awake()
    {
        _animator ??= transform.GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if(_playingAnim)
            return;
        
        _playingAnim = true;
        // Start Animation
        _animator.SetTrigger(_Touch);
    }

    public void PlayShootingSfx()
    {
        // Play sound
        AudioManager.Instance.PlayClip(audioClip);
    }

    public void EndAnimation()
    {
        _playingAnim = false;
    }
}
