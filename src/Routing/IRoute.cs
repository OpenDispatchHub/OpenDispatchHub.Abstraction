using OpenDispatchHub.Users;

namespace OpenDispatchHub.Routing;
/// <summary>
/// A collection of stops making up a drivable route
/// </summary>
public interface IRoute
{
    /// <summary>
    /// The unique ID of the route
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// The name of the route, usually the route identifier
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The time this route is scheduled to start
    /// </summary>
    DateTimeOffset StartTime { get; set; }

    /// <summary>
    /// The amount of stops on this route
    /// </summary>
    int TotalStops { get; }

    /// <summary>
    /// The total calculated drivable miles
    /// </summary>
    float TotalMiles { get; }

    /// <summary>
    /// Collection of stops on route
    /// </summary>
    IEnumerable<IRouteStop> GetStops();

    /// <summary>
    /// Returns the driver assigned to this route
    /// </summary>
    /// <returns></returns>
    IDriver? GetDriver();
}
