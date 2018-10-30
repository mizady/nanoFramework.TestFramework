//
// Copyright (c) 2018 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.TestPlatform.MSTest.TestAdapter.PlatformServices
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mstest settings in runsettings look like this
    ///  <MSTestV2>
    ///     <AssemblyResolution>
    ///         <Directory path= "% HOMEDRIVE %\direvtory " includeSubDirectories = "true" />
    ///         <Directory path= "C:\windows" includeSubDirectories = "false" />
    ///         <Directory path= ".\DirectoryName" />  ...// by default includeSubDirectories is false
    ///     </AssemblyResolution>
    /// </MSTestV2>
    ///
    /// For each directory we need to have two info 1) path 2) includeSubDirectories
    /// </summary>
    [Serializable]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1603:DocumentationMustContainValidXml", Justification = "Reviewed. Suppression is OK here.")]
    public class RecursiveDirectoryPath : MarshalByRefObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecursiveDirectoryPath"/> class.
        /// </summary>
        /// <param name="dirPath">The directory path.</param>
        /// <param name="includeSubDirectories">
        /// True if to include subdirectory else false
        /// </param>
        public RecursiveDirectoryPath(string dirPath, bool includeSubDirectories)
        {
            this.DirectoryPath = dirPath;
            this.IncludeSubDirectories = includeSubDirectories;
        }

        /// <summary>
        /// Gets the directory path.
        /// </summary>
        public string DirectoryPath { get; private set; }

        /// <summary>
        /// Gets a value indicating whether to include sub directories.
        /// </summary>
        public bool IncludeSubDirectories { get; private set; }
    }
}
