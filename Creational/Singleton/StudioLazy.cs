﻿using System;

namespace Creational.Singleton
{
    public sealed class StudioLazy
    {
        private static readonly Lazy<StudioLazy> lazy = new Lazy<StudioLazy>(() => new StudioLazy());

        public static StudioLazy Instance { get { return lazy.Value; } }

        private StudioLazy()
        {
        }

        public bool IsStudioAvailable(int persons)
        {
            // Insert your logic
            return true;
        }
    }
}
