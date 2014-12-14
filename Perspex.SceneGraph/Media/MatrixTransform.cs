﻿// -----------------------------------------------------------------------
// <copyright file="RotateTransform.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Media
{
    public class MatrixTransform : Transform
    {
        public static readonly PerspexProperty<Matrix> MatrixProperty =
            PerspexProperty.Register<MatrixTransform, Matrix>("Matrix", Matrix.Identity);

        public MatrixTransform()
        {
        }

        public MatrixTransform(Matrix matrix)
        {
            this.Matrix = matrix;
        }

        public Matrix Matrix
        {
            get { return this.GetValue(MatrixProperty); }
            set { this.SetValue(MatrixProperty, value); }
        }

        public override Matrix Value
        {
            get { return this.Matrix; }
        }
    }
}
