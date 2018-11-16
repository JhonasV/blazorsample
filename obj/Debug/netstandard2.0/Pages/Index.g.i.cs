#pragma checksum "C:\Users\jhonas\Desktop\blazorsample\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01683f73d2aaf8b1751f55e8f4bdcecd9a50e6af"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorsample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using blazorsample;
    using blazorsample.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 44 "C:\Users\jhonas\Desktop\blazorsample\Pages\Index.cshtml"
            
    List<Items> items = new List<Items>();
    List<Items> newPosition = new List<Items>();
 
    
    protected override void OnInit(){
        filler();
    }
    
    void filler()
    {
        items.Add(new Items{ Id = 1, Name = "Eggs", Position = 0});
        items.Add( new Items{Id = 2, Name = "Bread", Position = 0}); 
    }
    

    void onItemClickHandler(Items e) {
        var item = newPosition.Contains(e);
        if(item) { newPosition.Remove(e);} else { newPosition.Add(e);}  
    }

    void toRightClickHandler(){
        foreach (var move in newPosition)
        {
            foreach(var move2 in items){
                if(move.Id == move2.Id && move.Position == 0){
                    move.Position = 1;
                }
            }
        }
    }
     void toLeftClickHandler(){
        foreach (var move in newPosition)
        {
            foreach(var move2 in items){
                if(move.Id == move2.Id && move.Position == 1){
                    move.Position = 0;
                }
            }
        }
    }
    class Items
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Position { get; set; }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
