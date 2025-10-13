# WPF.WindowsManager
A toolset for window management

## WindowsZOrderManager
Can set z-order of the windows in three levels: low,normal,top

1. register main window as owner

    ``` 
    WindowsZOrderManager.SetManagerOwner(this);
    ```
2. register z-order in sub windows

    use the 'SetZOrder' Attached Dependency Property

#### other api
- > __AddPopup__ -> show pop on the top
- > __AddWindow__ -> add windows to be controlled

## WindowsDockManager
Can set window position dock to owner's specified region


1. register element as dock region on the owner window

    ``` 
    windowsManager:WindowsDockManager.DockRegionName="Dock"
    ```
2. register dock behavior in sub windows

    ```xml
    <windowsManager:WindowsDockManager.DockBehavior>
        <windowsManager:DockBehavior RegionName="Dock" Dock="Right,Bottom" Offset="-10,-10" IsDockKeep="True"/>
    </windowsManager:WindowsDockManager.DockBehavior>
    ```