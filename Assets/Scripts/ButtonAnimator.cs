using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ButtonAnimator : MonoBehaviour
{
    private const string IsHighlighted = nameof(IsHighlighted);

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseOver()
    {
        _animator.SetBool(IsHighlighted, true);
    }

    private void OnMouseExit()
    {
        _animator.SetBool(IsHighlighted, false);
    }
}
