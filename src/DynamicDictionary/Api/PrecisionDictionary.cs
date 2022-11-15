﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDictionary.Api
{
    public class PrecisionDictionary<TValue> : FastStringDictionary<TValue>
    {
        public PrecisionDictionary(bool useDefault) : base(useDefault)
        {
            this.SaveFastCache = () => { this._fast_cache = this._dict_cache.PrecisioTree(use_default); };
        }
    }
}
