using System;

namespace PlayerPowers
{
    [Flags]
    enum Powers
    {
        Fly = 1 << 0,
        XRayVision = 1 << 1,
        SuperStrength = 1 << 2
    }
}