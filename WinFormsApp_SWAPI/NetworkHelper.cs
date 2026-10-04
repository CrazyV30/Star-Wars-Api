using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_SWAPI;

public enum RequestStatus
{
    Ok,
    Error
}

public class RequestResponse
{
    public RequestStatus Status { get; }
    public string data { get; } = string.Empty;

    public RequestResponse(string data, RequestStatus Status = RequestStatus.Error)
    {
        this.data = data ?? string.Empty;
        this.Status = Status;
    }
}
internal class NetworkHelper
{
    private readonly HttpClient httpClient = new();
    private readonly Dictionary<string, string> localCach = new();
    public NetworkHelper()
    {
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
    }
    public async Task<RequestResponse> GetFromCache(string url)
    {
        RequestStatus status = RequestStatus.Ok;
        string data = string.Empty;
        if (localCach.ContainsKey(url))
        {
            return new RequestResponse(localCach[url], status);
        }
        else
        {
            RequestResponse requestResponse = await SendRequest(url);
            status = requestResponse.Status;
            if (requestResponse.Status == RequestStatus.Ok)
            {
                localCach[url] = requestResponse.data;
                data = requestResponse.data;
            }
        }
        return await Task.FromResult(new RequestResponse(data, status));

    }
    public async Task<RequestResponse> SendRequest(string url)
    {
        string res = string.Empty;
        RequestResponse response;
        try
        {
            res = await httpClient.GetStringAsync(url);
            response = new RequestResponse(res, RequestStatus.Ok);
        }
        catch (HttpRequestException ex)
        {
            Debug.WriteLine($"HttpRequestException: {ex.Message}");
            response = new RequestResponse(ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
            response = new RequestResponse(ex.Message);
        }



        return response;

    }
}
