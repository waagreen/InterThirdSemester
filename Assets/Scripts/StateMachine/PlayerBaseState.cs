public abstract class PlayerBaseState
{
    public int _stateNum = 0;
    protected bool isRootState = false;
    protected PlayerStateMachine _contex;
    protected PlayerStateFactory _fact;
    protected PlayerBaseState _currentSuperState;
    protected PlayerBaseState _currentSubState;

    public PlayerBaseState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory, int stateNum)
    {
        _contex = currentContext;
        _fact = playerStateFactory;
        _stateNum = stateNum;
    }

    
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    public abstract void CheckSwitchStates();
    public abstract void InitializeSubState();

    public void UpdateStates() 
    {
        UpdateState();
        if (_currentSubState != null) _currentSubState.UpdateStates();
    }
    protected void ChangeState(PlayerBaseState newState) 
    {
        ExitState();
        newState.EnterState();

        if (isRootState) _contex.CurrentContext = newState;
        else if (_currentSuperState != null) _currentSuperState.SetSubState(newState);
    }
    protected void SetSuperState(PlayerBaseState newSuperState) 
    {
        _currentSuperState = newSuperState;
    }
    protected void SetSubState(PlayerBaseState newSubState) 
    {
        _currentSubState = newSubState;
        newSubState.SetSuperState(this);
    }
}
