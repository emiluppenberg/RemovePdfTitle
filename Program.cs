using Spire.Pdf;

if (args.Length == 0)
    throw new ArgumentException("Provide a PDF filepath");

var bytes = File.ReadAllBytes(args[0]);

if (bytes is null)
    throw new ArgumentException("PDF filepath is invalid");

var pdf = new PdfDocument();

pdf.LoadFromBytes(bytes);

pdf.DocumentInformation.Title = "";

var directory = Path.GetDirectoryName(args[0]);
var fileName = Path.GetFileName(args[0]);

pdf.SaveToFile($"{directory}\\{fileName}");