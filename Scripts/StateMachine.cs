using UnityEngine;

public class StateMachine<T>
{
    private readonly T _owner;
    private IState<T> _currentState;

    public StateMachine(T owner)
    {
        _owner = owner;
    }

    public void ChangeState(IState<T> newState)
    {
        _currentState?.Exit(_owner);
        _currentState = newState;
        _currentState?.Enter(_owner);
    }

    public void Update()
    {
        _currentState?.Update(_owner);
    }
}
