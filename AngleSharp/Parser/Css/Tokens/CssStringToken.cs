﻿namespace AngleSharp.Parser.Css
{
    using AngleSharp.Extensions;
    using System;

    /// <summary>
    /// Represents a CSS string token.
    /// </summary>
    sealed class CssStringToken : CssToken
    {
        #region Fields

        readonly Boolean _bad;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new CSS string token.
        /// </summary>
        /// <param name="data">The string data.</param>
        /// <param name="bad">If the string was bad (optional).</param>
        /// <param name="position">The token's position.</param>
        public CssStringToken(String data, Boolean bad, TextPosition position)
            : base(CssTokenType.String, data, position)
        {
            _bad = bad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets if the data is bad.
        /// </summary>
        public Boolean IsBad
        {
            get { return _bad; }
        }

        #endregion

        #region String representation

        public override String ToValue()
        {
            return Data.CssString();
        }

        #endregion
    }
}
