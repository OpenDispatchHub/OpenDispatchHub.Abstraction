namespace OpenDispatchHub.Users;
/// <summary>
/// Interface for controlling a specific user
/// </summary>
public interface IUser
{
    /// <summary>
    /// The users ID
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// The first name of the user
    /// </summary>
    string? FirstName { get; set; }

    /// <summary>
    /// The last name of the user
    /// </summary>
    string? LastName { get; set; }

    /// <summary>
    /// The email of the user
    /// </summary>
    string Email { get; }
}
