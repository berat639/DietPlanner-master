﻿using Microsoft.AspNetCore.Components;

namespace DietPlanner.Client.ComponentBases
{
    public class PageDirector : ComponentBase
    {
        [Parameter]
        public string Url { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override void OnAfterRender(bool firstRender)
        {
            NavigationManager.NavigateTo(Url);
        }

    }
}
