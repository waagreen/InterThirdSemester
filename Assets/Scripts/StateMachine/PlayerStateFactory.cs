using System.Collections.Generic;

enum PlayerState
{
    idle,
    moving,
    passive,
    interacting,
    holding,
}

public class PlayerStateFactory
{
    PlayerStateMachine _context;
    Dictionary<PlayerState, PlayerBaseState> _states = new Dictionary<PlayerState, PlayerBaseState>();

    public PlayerStateFactory(PlayerStateMachine currentContext)
    {
        _context = currentContext;
        _states[PlayerState.idle] = new PlayerIdleState(_context, this);
        _states[PlayerState.moving] = new PlayerMovingState(_context, this);
        _states[PlayerState.interacting] = new PlayerInteractingSubState(_context, this);
        _states[PlayerState.passive] = new PlayerPassiveSubState(_context, this);
        _states[PlayerState.holding] = new PlayerHoldingSubState(_context, this);
    }

    public PlayerBaseState Idle() => _states[PlayerState.idle];
    public PlayerBaseState Moving() => _states[PlayerState.moving];
    public PlayerBaseState Passive() => _states[PlayerState.passive];
    public PlayerBaseState Interacting() => _states[PlayerState.interacting];
    public PlayerBaseState Holding() => _states[PlayerState.holding];
}
