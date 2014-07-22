﻿namespace AngleSharp.DOM.Mathml
{
    using System;

    sealed class MathStringElement : MathElement, IScopeElement
    {
        internal MathStringElement()
	    {
            _name = Tags.Ms;
	    }

        /// <summary>
        /// Gets the status if the node is a MathML text integration point.
        /// </summary>
        protected internal override Boolean IsMathMLTIP
        {
            get { return true; }
        }

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }
    }
}
