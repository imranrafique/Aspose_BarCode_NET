using System;
using System.Collections.Generic;
using System.Text;
using Aspose.BarCode;
using System.IO;

namespace SaveBarcodeImagestodifferentFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            Aspose.BarCode.License license = new Aspose.BarCode.License();
            license.SetLicense(@"c:\ab\Aspose.Total.Product.Family.lic");

            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../Data/");

            //Instantiate barcode object
            BarCodeBuilder builder = new BarCodeBuilder();

            //Set the Code text for the barcode
            builder.CodeText = "1234567";

            //Set the symbology type to Code128
            builder.SymbologyType = Symbology.Code128;

            //Save the image to your system and set its image format to Jpeg
            builder.Save(dataDir + "barcode.jpg", BarCodeImageFormat.Jpeg);
        }
    }
}
