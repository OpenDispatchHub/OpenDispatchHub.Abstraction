namespace OpenDispatchHub.Users;
/// <summary>
/// License Restrictions
/// </summary>
[Flags]
public enum LicenseRestrictions : byte
{
    None = 0x00,

    /// <summary>
    /// Manual
    /// </summary>
    E = 0x01,

    /// <summary>
    /// No Airbrakes
    /// </summary>
    L = 0x02,

    /// <summary>
    /// Class A Passenger Vehicle Restriction
    /// </summary>
    M = 0x04,

    /// <summary>
    /// CMV Only, no fifth-wheel attachment
    /// </summary>
    O = 0x08,

    /// <summary>
    /// Hydraulic Brakes Only
    /// </summary>
    Z = 0x16,

    /// <summary>
    /// Intrastate Only
    /// </summary>
    K = 0x32,

    /// <summary>
    /// Medical Waiver
    /// </summary>
    V = 0x64
}
