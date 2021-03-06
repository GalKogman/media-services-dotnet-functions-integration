#r "System.Web"
#r "System.ServiceModel"

using System;
using System.ServiceModel;
using Microsoft.WindowsAzure.MediaServices.Client;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.Azure.WebJobs;
using Newtonsoft.Json;


public static Dictionary<string, string> ReturnStorageCredentials()
{
    // Store the attached storage account to a dictionary
    Dictionary<string, string> attachedstoragecredDict = new Dictionary<string, string>();
    if (!string.IsNullOrWhiteSpace(_attachedStorageCredentials))
    {
        var tab = _attachedStorageCredentials.TrimEnd(';').Split(';');
        for (int i = 0; i < tab.Count(); i += 2)
        {
            attachedstoragecredDict.Add(tab[i], tab[i + 1]);
        }
    }
    return attachedstoragecredDict;
}