using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Pulsation : MonoBehaviour
{
    [SerializeField] private InactivityTimer _timer;

    private Animator _animator;

    private void OnEnable()
    {
        _timer.OnTimerExceeded += ActivatePulsation;
    }

    private void OnDisable()
    {
        _timer.OnTimerExceeded -= ActivatePulsation;
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void ActivatePulsation()
    {
        _animator.SetTrigger("IsPulsate");
    }
}