﻿// ---------------------------------------------------------------------------------------
//                                        ILGPU
//                        Copyright (c) 2016-2020 Marcel Koester
//                                    www.ilgpu.net
//
// File: CPUStream.cs
//
// This file is part of ILGPU and is distributed under the University of Illinois Open
// Source License. See LICENSE.txt for details
// ---------------------------------------------------------------------------------------

namespace ILGPU.Runtime.CPU
{
    /// <summary>
    /// Represents a CPU stream.
    /// </summary>
    sealed class CPUStream : AcceleratorStream
    {
        #region Static

        /// <summary>
        /// The default instance.
        /// </summary>
        internal static readonly CPUStream Default = new CPUStream();

        #endregion

        #region Instance

        /// <summary>
        /// Constructs a new CPU stream.
        /// </summary>
        private CPUStream() : base() { }

        /// <summary>
        /// Constructs a new CPU stream.
        /// </summary>
        /// <param name="accelerator">The associated accelerator.</param>
        internal CPUStream(Accelerator accelerator)
            : base(accelerator)
        { }

        #endregion

        #region Methods

        /// <summary>
        /// Does not perform any operation.
        /// </summary>
        public override void Synchronize() { }

        #endregion

        #region IDisposable

        /// <summary>
        /// Does not perform any operation.
        /// </summary>
        protected override void DisposeAcceleratorObject(bool disposing) { }

        #endregion
    }
}
