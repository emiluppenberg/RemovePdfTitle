using Spire.Pdf;

if (args.Length == 0)
    throw new ArgumentException("Provide a PDF filepath");

var directory = Directory.GetCurrentDirectory();
var filePath = Path.GetFullPath($"{directory}/{args[0]}.pdf");
var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

if (fileStream is null)
    throw new ArgumentException("PDF filepath is invalid");

var pdf = new PdfDocument();

pdf.LoadFromStream(fileStream);

pdf.DocumentInformation.Title = "";

pdf.SaveToFile($"{args[0]}");