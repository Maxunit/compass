﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using Dalamud.Configuration;
using Newtonsoft.Json;

namespace Compass
{
    public class Configuration : IPluginConfiguration
    {
        [JsonIgnore] public Vector2 AddonCompassOffset = new(0,0);
        [JsonIgnore] public float AddonCompassScale = 1f;
        [JsonIgnore] public int AddonCompassWidth = 550;
        // NOTE (Chiv) ImGuiCompass Offset/Position are saved as the window coords/size.
        [JsonIgnore] public int AddonCompassBackgroundPartId = 1;
        [JsonIgnore] public bool AddonCompassDisableBackground;
        [JsonIgnore] public bool AddonCompassEnable;

        public bool UseAreaMapAsSource;
        
        public float ImGuiCompassScale = 1f;
        public bool ImGuiCompassEnableBackground = true;
        public bool ImGuiCompassDrawBorder = true;
        public bool ImGuiCompassFillBackground = false;
        public Vector4 ImGuiBackgroundColour = new(0.2f,0.2f,0.2f,0.2f);
        [JsonIgnore] public uint ImGuiBackgroundColourUInt32;
        public Vector4 ImGuiBackgroundBorderColour = new(0.4f,0.4f,0.4f,1f);
        [JsonIgnore] public uint ImGuiBackgroundBorderColourUInt32;
        public float ImGuiCompassBackgroundRounding = 10f;
        public float ImGuiBackgroundBorderThickness = 1f;

        public Vector2 ImGuiCompassPosition = new(835, 515);
        public float ImGuiCompassWidth = 250;
        
        public bool ImGuiCompassEnableCenterMarker = true;
        public bool ImGuiCompassFlipCentreMarker;
        public int ImGuiCompassCentreMarkerOffset = 20;
        public bool ImGuiCompassEnable = true;
        
        public bool[] ShouldHideOnUiObjectSerializer = new bool[0];
        [JsonIgnore] public (string[] getUiObjectIdentifier,bool disable, string userFacingIdentifier)[] ShouldHideOnUiObject = null!;
        public bool HideInCombat;
        [JsonIgnore] public bool FreshInstall;
        public bool HideInPvPMaps;
        public bool HideInInstances;

        public int Version { get; set; } = 0;
    }

}