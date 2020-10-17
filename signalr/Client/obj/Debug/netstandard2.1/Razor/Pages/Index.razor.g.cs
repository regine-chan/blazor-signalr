#pragma checksum "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d9b78bb7d629d07a4af3131c033a31842e070b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Welcome to SignalR with blazor</h1>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
                                          async () => await ConnectToServer()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "disabled", 
#nullable restore
#line 5 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
                                                                                          isConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Connect");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, "Connection Status: ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
                        connectionStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-4");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 10 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
         foreach(var item in notifications)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "h4");
            __builder.AddContent(22, 
#nullable restore
#line 13 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
                     item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 15 "C:\Users\theo_\source\repos\signalr\signalr\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
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