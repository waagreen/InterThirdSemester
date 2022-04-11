public class PlayerStateFactory
{
    PlayerStateMachine _context;

    public PlayerStateFactory(PlayerStateMachine currentContext) => _context = currentContext;

    public PlayerBaseState Idle() => new PlayerIdleState(_context, this);
    public PlayerBaseState Moving() => new PlayerMovingState(_context, this);
    public PlayerBaseState OnMouseDown() => new PlayerPickUpState(_context, this);
}
