namespace OpenDispatchHub.Users;
/// <summary>
/// The license class
/// </summary>
[Flags]
public enum LicenseClass : byte
{
    /// <summary>
    /// No license
    /// </summary>
    None = 0x00,

    /// <summary>
    /// Regular drivers license
    /// </summary>
    C = 0x01,

    /// <summary>
    /// Straight truck, busses, box trucks
    /// </summary>
    B = 0x02,

    /// <summary>
    /// Combination vehicles 
    /// </summary>
    A = 0x04
}
