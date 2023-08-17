//using System;
//using System.IO;
//using System.Linq;
//using System.Xml;

////class Program
////{
////	static void Main(string[] args)
////	{
////		

////        // Iterate through the target XML files and update matching lines
////        foreach (string targetFile in targetXmlFiles)
////		{

////			// Load the target XML document
////			targetDoc.Load(targetFile);

////            // Iterate through the elements in the source XML
////            foreach (XmlNode sourceNode in sourceDoc.DocumentElement.ChildNodes)
////            {

////                // Skip comment nodes
////                if (sourceNode.NodeType == XmlNodeType.Comment)
////                {
////                    continue;
////                }

////                XmlElement sourceElem = (XmlElement)sourceNode;

////                PrintOut($"{sourceElem.Name} Found");

////                // Find the corresponding element in the target XML
////                XmlNode targetNode = targetDoc.SelectSingleNode(sourceElem.Name);
////                if (targetNode != null)
////                {
////                    // Update the text content of the matching element in the target XML
////                    targetNode.InnerText = sourceElem.InnerText;
////                }
////                if (sourceElem.Name == "Music")
////                    PrintOut("Music Found");
////            }

////			// Save the updated target XML back to the file
////			targetDoc.Save(targetFile);
////		}
////	}

////    static void PrintOut(string STR)
////    {
////        Console.WriteLine(STR);
////        Console.ReadKey();

////        //Console.WriteLine($"Checking Child Node {sourceElem.Name}");
////        //Console.ReadKey();
////    }
////}

//class Program
////{
////    static void Main(string[] args)
////    {
////        // Specify the paths to the source and target XML files
////        string sourceXmlFile = "UpdateElements.xml";  // XML file A
////        string targetXmlFile = "Data\\World\\Factions\\Eldar.xml";  // XML file B

////        // Load the source XML document
////        XmlDocument sourceDoc = new XmlDocument();
////        sourceDoc.Load(sourceXmlFile);

////        foreach (XmlNode node in sourceDoc.DocumentElement.ChildNodes)
////        {
////            Console.WriteLine("Node Name: " + node.Name);
////        }


////        // Load the target XML document
////        XmlDocument targetDoc = new XmlDocument();
////        targetDoc.Load(targetXmlFile);

////        // Find the first child element in the source XML
////        XmlElement sourceFirstElement = sourceDoc.DocumentElement.ChildNodes.OfType<XmlElement>() as XmlElement;
////        if (sourceFirstElement != null)
////        {
////            PrintOut($"{sourceFirstElement.Name}");
////        }

////        // Iterate through the elements in the source XML
////        foreach (XmlElement sourceElem in sourceDoc.DocumentElement.ChildNodes.OfType<XmlElement>())
////        {
////            PrintOut($"{sourceElem.Name}");

////            // Find the corresponding element in the target XML
////            XmlNode targetNode = targetDoc.SelectSingleNode(sourceElem.Name);
////            if (targetNode != null)
////            {
////                // Replace the content of the matching element in the target XML
////                targetNode.InnerXml = sourceElem.InnerXml;
////            }
////        }

////        // Save the updated target XML back to the file
////        targetDoc.Save(targetXmlFile);

////        Console.WriteLine("Element content replaced successfully.");
////    }
//    static void PrintOut(string STR)
//    {
//        Console.WriteLine(STR);
//        Console.ReadKey();

//    //Console.WriteLine($"Checking Child Node {sourceElem.Name}");
//    //Console.ReadKey();
//}
//}

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
        string targetXmlFile = "Eldar.xml";
        if (DebugMode)
        {
            PrintOut(sourceXmlFile);
            PrintOut(targetXmlFile);
        }

        //Load the source XML documents
        XmlDocument sourceDoc = new XmlDocument();
        sourceDoc.Load(sourceXmlFile);
        XmlDocument targetDoc = new XmlDocument();
        targetDoc.Load(targetXmlFile);

        if (DebugMode)
        {
            PrintOut(sourceDoc.InnerXml);
            PrintOut(targetDoc.InnerXml);
        }

        //Iterate through the target XML files and update matching lines
      //  foreach (string targetFile in targetXmlFiles)
        //{

            // Load the target XML document
            //targetDoc.Load(targetFile);

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
                    targetNode.InnerText = sourceElem.InnerText;
                }
            }

            // Save the updated target XML back to the file
            targetDoc.Save(targetXmlFile);
     //   }

        PrintOut("End");
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