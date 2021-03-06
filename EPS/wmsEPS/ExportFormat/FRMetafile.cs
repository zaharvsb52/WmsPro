﻿#pragma warning disable 1587
/// --------------------------------------------------------------------------------------
/// <Copyright File="FRMetafile.cs" Company="ЗАО Логистическая компания МОЛКОМ">
///   Copyright (c) ЗАО Логистическая компания МОЛКОМ. All rights reserved.
/// </Copyright>
/// <Author>Olga Marysheva</Author>
/// <Date>10.10.2012 13:47:53</Date>
/// <Summary>Экпорт отчетов в формате файла изображений</Summary>
/// --------------------------------------------------------------------------------------
#pragma warning restore 1587

using System;
using System.Text;
using FastReport;

namespace wmsMLC.EPS.wmsEPS.ExportFormat
{
    /// <summary>
    /// Экпорт отчета в формате изображения metafile
    /// </summary>
    public class FRMetafile : IExportFormat
    {
        private readonly FastReport.Export.Image.ImageExport _exp = new FastReport.Export.Image.ImageExport();
        public FRMetafile()
        {
            _exp.ImageFormat = FastReport.Export.Image.ImageExportFormat.Metafile;
            _exp.SeparateFiles = false;
        }

        public void Export(Report report, System.IO.Stream stream)
        {
            _exp.Export(report, stream);
        }
        public void Dispose()
        {
            _exp.Clear();
            _exp.Dispose();
        }

        public string FileExtension { get { return "emf"; } }

        public bool SupportsEncoding { get { return false; } }
        public void SetEncoding(Encoding encoding)
        {
            throw new NotSupportedException();
        }
        public bool SupportsSpacelife { get { return false; } }
        public void SetSpacelife(bool val)
        {
            throw new NotSupportedException();
        }
    }
}