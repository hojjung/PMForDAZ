﻿using DAZ_Installer.Core.Extraction;
using System.Diagnostics.CodeAnalysis;

namespace DAZ_Installer.Core
{
    public class DPArchiveExitArgs
    {
        /// <summary>
        /// Represents whether the file had been successfully processed by <see cref="DPProcessor"/> or not. <para/>
        /// Will be <see langword="false"/> if cancelled or an error occurred preventing main operations.
        /// </summary>
        public readonly bool Processed = false;

        /// <summary>
        /// The archive that has finished processing.
        /// </summary>
        public readonly DPArchive Archive;
        /// <summary>
        /// The extraction report generated by the archive. This will not be null if <see cref="Processed"/> is <see langword="true"/>.
        /// </summary>
        public readonly DPExtractionReport? Report;

        internal DPArchiveExitArgs(DPArchive archive, DPExtractionReport? report, bool processed = true)
        {
            Archive = archive;
            Report = report;
            Processed = processed;
        }
    }
}
