using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerInputHandler))]
public class InactivityTimer : MonoBehaviour
{
    [SerializeField] private float _timeIdle;

    private float _timer = 0f;
    private PlayerInputHandler _player;

    public UnityAction OnTimerExceeded;

    private void OnEnable()
    {
        _player.PlayerInput += ResetTimer;
    }

    private void OnDisable()
    {
        _player.PlayerInput -= ResetTimer;
    }

    private void Awake()
    {
        _player = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        if (_timer < _timeIdle)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            _timer = 0f;
            OnTimerExceeded.Invoke();
        }
    }

    public void ResetTimer()
    {
        _timer = 0f;
    }
}
