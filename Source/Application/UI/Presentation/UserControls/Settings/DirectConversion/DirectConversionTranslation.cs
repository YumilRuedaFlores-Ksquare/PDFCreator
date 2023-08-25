﻿using Translatable;

namespace pdfforge.PDFCreator.UI.Presentation.UserControls.Settings.DirectConversion
{
    public class DirectConversionTranslation : ITranslatable
    {
        public string DirectImageConversionSettings { get; private set; } = "Direct Image Conversion Settings";
        public string SelectPageSizeLabel { get; private set; } = "Select page size:";
        public string SelectPageOrientationLabel { get; private set; } = "Select page orientation:";
    }
}