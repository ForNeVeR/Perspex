﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Perspex.Media
{
    /// <summary>
    /// Translates (moves) an <see cref="IVisual"/>.
    /// </summary>
    public class TranslateTransform : Transform
    {
        /// <summary>
        /// Defines the <see cref="X"/> property.
        /// </summary>
        public static readonly PerspexProperty<double> XProperty =
            PerspexProperty.Register<TranslateTransform, double>("X");

        /// <summary>
        /// Defines the <see cref="Y"/> property.
        /// </summary>
        public static readonly PerspexProperty<double> YProperty =
            PerspexProperty.Register<TranslateTransform, double>("Y");

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTransform"/> class.
        /// </summary>
        public TranslateTransform()
        {
            GetObservable(XProperty).Subscribe(_ => RaiseChanged());
            GetObservable(YProperty).Subscribe(_ => RaiseChanged());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTransform"/> class.
        /// </summary>
        /// <param name="x">Gets the horizontal offset of the translate.</param>
        /// <param name="y">Gets the vertical offset of the translate.</param>
        public TranslateTransform(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets the horizontal offset of the translate.
        /// </summary>
        public double X
        {
            get { return GetValue(XProperty); }
            set { SetValue(XProperty, value); }
        }

        /// <summary>
        /// Gets the vertical offset of the translate.
        /// </summary>
        public double Y
        {
            get { return GetValue(YProperty); }
            set { SetValue(YProperty, value); }
        }

        /// <summary>
        /// Gets the tranform's <see cref="Matrix"/>.
        /// </summary>
        public override Matrix Value => Matrix.CreateTranslation(X, Y);
    }
}
