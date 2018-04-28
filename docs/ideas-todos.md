# UNC && Uri


https://blogs.msdn.microsoft.com/ie/2006/12/06/file-uris-in-windows/

|-------------------------------------------------|---------------------------------------------------|
| UNC path                                        | Uri                                               |
|-------------------------------------------------|---------------------------------------------------|
| \\laptop\My Documents\FileSchemeURIs.doc        | file://laptop/My%20Documents/FileSchemeURIs.doc   |
| \\Mac\Home\My Documents\FileSchemeURIs.doc      | file://Mac/Home/My%20Documents/FileSchemeURIs.doc |
|-------------------------------------------------|---------------------------------------------------|



            rootfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathfile = System.IO.Path.Combine(rootfolder, "Microsoft.Caboodle.Browser.History.TextFile.txt");

            System.IO.File.WriteAllText(pathfile, "# Microsoft.Caboodle.Browser launcher for text files");
            var content = System.IO.File.ReadAllText(pathfile);

            // UNC path $@"\\Mac\Home\Documents\Microsoft.Caboodle.Browser.TextFile.txt"
            // URI      $@"file://Mac/Home/Documents/Microsoft.Caboodle.Browser.History.TextFile.txt"
            uris.Add($@"file://Mac/Home/Documents/Microsoft.Caboodle.Browser.History.TextFile.txt");




optimizaton peparations reformatting for parameters


todo: 

IEnumerableExtensions.MedianWeighted