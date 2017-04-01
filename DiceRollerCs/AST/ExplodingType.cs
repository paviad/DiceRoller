﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.AST
{
    /// <summary>
    /// The type of exploding dice
    /// </summary>
    public enum ExplodingType
    {
        /// <summary>
        /// A new die is rolled each time the maximum is rolled (or the comparison succeeds).
        /// </summary>
        Explode,
        /// <summary>
        /// A new die is rolled each time the maximum is rolled (or the comparison succeeds),
        /// and 1 is subtracted from each subsequent die roll. As a special case, d100p penetrates
        /// to d20p, and d20p penetrates to d6p.
        /// </summary>
        Penetrate
    }
}
