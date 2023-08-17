using System;
using System.IO;
using System.Xml;

class AutoUpdateXmlElements
{
    static void Main(string[] args)
    {
        bool DebugMode = true;
        // Specify the paths to the source and target XML files
        string sourceXmlFile = "UpdateElements.xml";
        string targetDirectory = "Data";
        if (DebugMode)
        {
            PrintOut(sourceXmlFile);
            PrintOut(targetDirectory);
        }

        //Load the source XML documents
        XmlDocument sourceDoc = new XmlDocument();
        sourceDoc.Load(sourceXmlFile);

        //Set-up target Document. These will load as we iterate through the folders
        XmlDocument targetDoc = new XmlDocument();

        // Get a list of XML files in the target directory
        string[] targetXmlFiles = Directory.GetFiles(targetDirectory, "*.xml");

        //Iterate through the target XML files and update matching lines
        foreach (string targetFile in targetXmlFiles)
        {

            // Load the target XML document
            targetDoc.Load(targetFile);

            // Iterate through the elements in the source XML
            foreach (XmlNode sourceNode in sourceDoc.DocumentElement.ChildNodes)
            {
            if (DebugMode) { PrintOut($"Current Source Node: {sourceNode.Name}"); }
                // Skip comment nodes
                if (sourceNode.NodeType == XmlNodeType.Comment)
                {
                    if (DebugMode){PrintOut("Skipping due to comment");}
                    continue;
                }


                XmlElement sourceElem = (XmlElement)sourceNode;
                if (DebugMode){PrintOut($"Current source element: {sourceElem.Name}");}

                // Find the corresponding element in the target XML
                XmlNode targetNode = SearchForNode(targetDoc.DocumentElement, sourceElem.Name);

                if (targetNode != null)
                {
                    if (DebugMode){PrintOut($"Current Target Node: {targetNode.Name}");}
                    // Update the text content of the matching element in the target XML
                    targetNode.InnerXml = sourceElem.InnerXml;
                }
            }

            // Save the updated target XML back to the file
            targetDoc.Save(targetFile);
        }

        PrintOut("Finished");
    }
    static void PrintOut(string STR)
    {
        Console.WriteLine(STR);
        Console.ReadKey();

        //Console.WriteLine($"Checking Child Node {sourceElem.Name}");
        //Console.ReadKey();
    }

    static XmlNode SearchForNode(XmlNode node, string nodeName)
    {
        if (node.Name == nodeName)
        {
            return node;
        }

        foreach (XmlNode childNode in node.ChildNodes)
        {
            XmlNode foundNode = SearchForNode(childNode, nodeName);
            if (foundNode != null)
            {
                return foundNode;
            }
        }

        return null;
    }

}