using System;

namespace DStack.Common
{
    public interface ITimeProvider
    {
        DateTime GetUtcTime();
    }
}
