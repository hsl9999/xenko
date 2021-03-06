﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Images
{
    public static partial class RadiancePrefilteringGGXShaderKeys
    {
        public static readonly ValueParameterKey<int> RadianceMapSize = ParameterKeys.NewValue<int>();
        public static readonly ObjectParameterKey<Texture> RadianceMap = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> FilteredRadiance = ParameterKeys.NewObject<Texture>();
        public static readonly ValueParameterKey<float> MipmapCount = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> Roughness = ParameterKeys.NewValue<float>();
    }
}
