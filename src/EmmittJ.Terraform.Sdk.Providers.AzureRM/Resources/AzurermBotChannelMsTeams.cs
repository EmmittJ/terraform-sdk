using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelMsTeamsTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bot_channel_ms_teams resource.
/// </summary>
public class AzurermBotChannelMsTeams : TerraformResource
{
    public AzurermBotChannelMsTeams(string name) : base("azurerm_bot_channel_ms_teams", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetProperty<TerraformProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CallingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("calling_enabled");
        set => this.WithProperty("calling_enabled", value);
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    public TerraformProperty<string>? CallingWebHook
    {
        get => GetProperty<TerraformProperty<string>>("calling_web_hook");
        set => this.WithProperty("calling_web_hook", value);
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("deployment_environment");
        set => this.WithProperty("deployment_environment", value);
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableCalling
    {
        get => GetProperty<TerraformProperty<bool>>("enable_calling");
        set => this.WithProperty("enable_calling", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelMsTeamsTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBotChannelMsTeamsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
