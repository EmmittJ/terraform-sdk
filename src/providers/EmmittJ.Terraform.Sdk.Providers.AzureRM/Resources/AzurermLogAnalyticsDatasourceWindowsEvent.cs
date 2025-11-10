using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsEventTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_datasource_windows_event resource.
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsEvent : TerraformResource
{
    public AzurermLogAnalyticsDatasourceWindowsEvent(string name) : base("azurerm_log_analytics_datasource_windows_event", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("event_log_name");
        SetOutput("event_types");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("workspace_name");
    }

    /// <summary>
    /// The event_log_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventLogName is required")]
    public required TerraformProperty<string> EventLogName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_log_name");
        set => SetProperty("event_log_name", value);
    }

    /// <summary>
    /// The event_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTypes is required")]
    public HashSet<TerraformProperty<string>> EventTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("event_types");
        set => SetProperty("event_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceName is required")]
    public required TerraformProperty<string> WorkspaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_name");
        set => SetProperty("workspace_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsDatasourceWindowsEventTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
