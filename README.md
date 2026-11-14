This tool removes PDF title metadata.

If you open your PDF in a browser tab and the tab says "SomeTitle - your-filename.pdf", this tool fixes that.

### Requirements
.NET 11

### How to run
`dotnet run "your-filepath"`

Or even better publish as an .exe and right click the PDF -> select "Open with" -> select the .exe file in ./bin/Release/net11.0/RemovePdfTitle.exe  
Windows should offer the .exe as an option from now on when you right click a PDF and select "Open with".  
Quick and easy.  

To publish the .exe run `dotnet publish -c release`