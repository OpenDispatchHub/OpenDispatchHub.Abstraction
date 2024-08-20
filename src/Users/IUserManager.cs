namespace OpenDispatchHub.Users;

/// <summary>
/// A generic interface for managing users
/// </summary>
/// <typeparam name="TUser"></typeparam>
public interface IUserManager<TUser> where TUser : IUser
{
    /// <summary>
    /// Create a user
    /// </summary>
    /// <param name="email">The email address</param>
    /// <param name="firstName">The first name of the user</param>
    /// <param name="lastName">The last name of the user</param>
    /// <returns>The created user object</returns>
    Task<TUser> Create(string email, string? firstName, string? lastName);

    /// <summary>
    /// Updates a users email address
    /// </summary>
    /// <param name="user">The user to update</param>
    /// <param name="email">The new email of the user</param>
    /// <returns>The updated user object</returns>
    Task<TUser> UpdateEmail(TUser user, string email);

    /// <summary>
    /// Updates a users name
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<TUser> Update(TUser user);

    /// <summary>
    /// Gets a user by ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TUser?> Get(Guid id);

    /// <summary>
    /// Deletes a user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<bool> Delete(TUser user);
}

/// <summary>
/// Create, modify, delete users
/// </summary>
public interface IUserManager : IUserManager<IUser>
{
}