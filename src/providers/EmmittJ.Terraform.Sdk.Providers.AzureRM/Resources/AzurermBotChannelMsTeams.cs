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
        SetOutput("bot_name");
        SetOutput("calling_enabled");
        SetOutput("calling_web_hook");
        SetOutput("deployment_environment");
        SetOutput("enable_calling");
        SetOutput("id");
        SetOutput("location");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bot_name");
        set => SetProperty("bot_name", value);
    }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CallingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("calling_enabled");
        set => SetProperty("calling_enabled", value);
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    public TerraformProperty<string> CallingWebHook
    {
        get => GetRequiredOutput<TerraformProperty<string>>("calling_web_hook");
        set => SetProperty("calling_web_hook", value);
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentEnvironment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_environment");
        set => SetProperty("deployment_environment", value);
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> EnableCalling
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_calling");
        set => SetProperty("enable_calling", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelMsTeamsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
