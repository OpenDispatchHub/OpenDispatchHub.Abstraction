namespace OpenDispatchHub.Users;

/// <summary>
/// Create, Modify, Delete Drivers
/// </summary>
public interface IDriverManager : IUserManager<IDriver>
{
    /// <summary>
    /// Update the drivers license info
    /// </summary>
    /// <param name="driver">The driver</param>
    /// <param name="id">The License ID</param>
    /// <param name="country">License Issued Country</param>
    /// <param name="state">License Issued State</param>
    /// <param name="issued">License Issued Date</param>
    /// <param name="expire">License Expired Date</param>
    /// <returns></returns>
    Task<IDriver> UpdateLicenseInfo(IDriver driver, string? id, string? country, string? state, DateOnly? issued, DateOnly? expire);

    /// <summary>
    /// Update the drivers endorsements
    /// </summary>
    /// <param name="driver">The driver</param>
    /// <param name="endorsements">Endorsements</param>
    /// <returns></returns>
    Task<IDriver> UpdateEndorsements(IDriver driver, LicenseEndorsements endorsements);

    /// <summary>
    /// Update the drivers class
    /// </summary>
    /// <param name="driver">The driver</param>
    /// <param name="licenseClass">The Class</param>
    /// <returns></returns>
    Task<IDriver> UpdateClass(IDriver driver, LicenseClass licenseClass);

    /// <summary>
    /// Update the drivers restrictions
    /// </summary>
    /// <param name="driver">The driver</param>
    /// <param name="restrictions">Restrictions</param>
    /// <returns></returns>
    Task<IDriver> UpdateRestrictions(IDriver driver, LicenseRestrictions restrictions);
}
