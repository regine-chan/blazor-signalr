#pragma checksum "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d9b78bb7d629d07a4af3131c033a31842e070b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace signalr.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using signalr.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\theo_\source\repos\signalr\signalr\Client\_Imports.razor"
using signalr.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
       
    string url = "https://localhost:44308/notificationshub";

    HubConnection _connection = null;
    bool isConnected = false;
    string connectionStatus = "Closed";

    List<string> notifications = new List<string>();

    private async Task ConnectToServer()
    {
        _connection = new HubConnectionBuilder().WithUrl(url).Build();



        await _connection.StartAsync();
        connectionStatus = "Connected";
        isConnected = true;


        _connection.Closed += async s =>
        {
            isConnected = false;
            connectionStatus = "Disconnected";
            await _connection.StartAsync();
            isConnected = true;
            connectionStatus = "Connected";
        };

        _connection.On<string>("notification", m =>
        {
            notifications.Add(m);
            StateHasChanged();
        });

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
