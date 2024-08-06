namespace OpenDispatchHub.Routing;
/// <summary>
/// A interface used to identify a single stop
/// </summary>
public interface IRouteStop
{
    /// <summary>
    /// The unique ID of the stop
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// The position of this stop on route
    /// </summary>
    int Position { get; set; }

    /// <summary>
    /// The address of this stop
    /// </summary>
    string Address { get; set; }

    /// <summary>
    /// Comments about the stop
    /// </summary>
    string Notes { get; set; }

    /// <summary>
    /// The route containing this stop
    /// </summary>
    IRoute GetRoute();
}
