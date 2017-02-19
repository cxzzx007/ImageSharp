﻿// <copyright file="GifDecoderOptions.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Formats
{
    using System.Text;

    /// <summary>
    /// Encapsulates the gif decoder options.
    /// </summary>
    public sealed class GifDecoderOptions : DecoderOptions, IGifDecoderOptions
    {
        private static readonly Encoding DefaultEncoding = Encoding.GetEncoding("ASCII");

        /// <summary>
        /// Initializes a new instance of the <see cref="GifDecoderOptions"/> class.
        /// </summary>
        public GifDecoderOptions()
        {
            this.InitializeWithDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GifDecoderOptions"/> class.
        /// </summary>
        /// <param name="options">The options for the decoder.</param>
        private GifDecoderOptions(IDecoderOptions options)
            : base(options)
        {
            this.InitializeWithDefaults();
        }

        /// <summary>
        /// Gets or sets the encoding that should be used when reading comments.
        /// </summary>
        public Encoding TextEncoding { get; set; }

        /// <summary>
        /// Converts the options to a <see cref="GifDecoderOptions"/> instance with a cast
        /// or by creating a new instance with the specfied options.
        /// </summary>
        /// <param name="options">The options for the decoder.</param>
        /// <returns>The options for the png decoder.</returns>
        internal static IGifDecoderOptions Create(IDecoderOptions options)
        {
            IGifDecoderOptions gifOptions = options as IGifDecoderOptions;
            if (gifOptions != null)
            {
                return gifOptions;
            }

            return new GifDecoderOptions(options);
        }

        private void InitializeWithDefaults()
        {
            this.TextEncoding = DefaultEncoding;
        }
    }
}