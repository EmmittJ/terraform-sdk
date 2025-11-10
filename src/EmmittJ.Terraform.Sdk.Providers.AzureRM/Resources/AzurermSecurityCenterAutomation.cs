using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationActionBlock : TerraformBlock
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => WithProperty("connection_string", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// The trigger_url attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerUrl
    {
        get => GetProperty<TerraformProperty<string>>("trigger_url");
        set => WithProperty("trigger_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationSourceBlock : TerraformBlock
{
    /// <summary>
    /// The event_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSource is required")]
    public required TerraformProperty<string> EventSource
    {
        get => GetProperty<TerraformProperty<string>>("event_source");
        set => WithProperty("event_source", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAutomationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_security_center_automation resource.
/// </summary>
public class AzurermSecurityCenterAutomation : TerraformResource
{
    public AzurermSecurityCenterAutomation(string name) : base("azurerm_security_center_automation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public List<AzurermSecurityCenterAutomationActionBlock>? Action
    {
        get => GetProperty<List<AzurermSecurityCenterAutomationActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    public List<AzurermSecurityCenterAutomationSourceBlock>? Source
    {
        get => GetProperty<List<AzurermSecurityCenterAutomationSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterAutomationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSecurityCenterAutomationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
