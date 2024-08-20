namespace OpenDispatchHub.Users;
/// <summary>
/// License endorsements
/// </summary>
[Flags]
public enum LicenseEndorsements : byte
{
    /// <summary>
    /// No endorsements
    /// </summary>
    None = 0x00,

    /// <summary>
    /// Hazmat
    /// </summary>
    H = 0x01,

    /// <summary>
    /// Passenger Vehicles
    /// </summary>
    P = 0x02,

    /// <summary>
    /// School Bus
    /// </summary>
    S = 0x04,

    /// <summary>
    /// Tanker
    /// </summary>
    N = 0x08,

    /// <summary>
    /// Doubles & Triples
    /// </summary>
    T = 0x16,

    /// <summary>
    /// Combination Hazmat
    /// </summary>
    X = N | H
}
