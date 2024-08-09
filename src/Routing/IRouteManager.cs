namespace OpenDispatchHub.Routing;
/// <summary>
/// A interface used for creating and managing routes
/// </summary>
public interface IRouteManager
{
    /// <summary>
    /// Retrieve a route by ID
    /// </summary>
    /// <param name="id">The ID of the route</param>
    /// <returns>The route or null if not found</returns>
    Task<IRoute?> Get(Guid id);

    /// <summary>
    /// Search and return a list of routes based on search query
    /// </summary>
    /// <param name="query">The query, use anonymous object to run property search</param>
    /// <returns>Enumeration of routes</returns>
    IAsyncEnumerable<IRoute> Search(object? query);

    /// <summary>
    /// Creates a new blank route
    /// </summary>
    /// <returns>A empty route</returns>
    Task<IRoute> Create();

    /// <summary>
    /// Creates a new stop for a route
    /// </summary>
    /// <param name="route">The route to append the stop to</param>
    /// <returns>The stop to edit</returns>
    Task<IRouteStop> CreateStop(IRoute route);

    /// <summary>
    /// Get all stops assigned to a route
    /// </summary>
    /// <param name="id">The route ID</param>
    /// <returns>A enumerable of stops assigned to a route</returns>
    IAsyncEnumerable<IRouteStop> GetStops(Guid id);

    /// <summary>
    /// Deletes a route
    /// </summary>
    /// <param name="id">The ID of the route</param>
    /// <returns>True on success</returns>
    Task<bool> Delete(Guid id);

    Task Update(IRoute route);

    Task Update(IRouteStop stop);
}
