namespace OpenDispatchHub.Users;
/// <summary>
/// A interface for managing a driver
/// </summary>
public interface IDriver : IUser
{
    /// <summary>
    /// The ID of the drivers license
    /// </summary>
    string LicenseId { get; }
    
    /// <summary>
    /// The Country the license was issued in
    /// </summary>
    string LicenseCountry { get; }

    /// <summary>
    /// The State the license was issued in
    /// </summary>
    string LicenseState { get; }

    /// <summary>
    /// The date the license was issued
    /// </summary>
    DateOnly LicenseIssued { get; }

    /// <summary>
    /// The date the license will expire
    /// </summary>
    DateOnly LicenseExpires { get; }

    /// <summary>
    /// Vehicle class this driver is allowed to operate
    /// </summary>
    LicenseClass Class { get; }

    /// <summary>
    /// The endorsements this driver has
    /// </summary>
    LicenseEndorsements Endorsements { get; }

    /// <summary>
    /// The restrictions this driver has
    /// </summary>
    LicenseRestrictions Restrictions { get; }
}
