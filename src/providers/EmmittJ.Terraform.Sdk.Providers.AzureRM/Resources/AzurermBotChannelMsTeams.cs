using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelMsTeamsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_bot_channel_ms_teams resource.
/// </summary>
public class AzurermBotChannelMsTeams : TerraformResource
{
    public AzurermBotChannelMsTeams(string name) : base("azurerm_bot_channel_ms_teams", name)
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    [TerraformArgument("bot_name")]
    public required TerraformValue<string> BotName
    {
        get => new TerraformReference<string>(this, "bot_name");
        set => SetArgument("bot_name", value);
    }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    [TerraformArgument("calling_enabled")]
    public TerraformValue<bool> CallingEnabled
    {
        get => new TerraformReference<bool>(this, "calling_enabled");
        set => SetArgument("calling_enabled", value);
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    [TerraformArgument("calling_web_hook")]
    public TerraformValue<string> CallingWebHook
    {
        get => new TerraformReference<string>(this, "calling_web_hook");
        set => SetArgument("calling_web_hook", value);
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    [TerraformArgument("deployment_environment")]
    public TerraformValue<string>? DeploymentEnvironment
    {
        get => new TerraformReference<string>(this, "deployment_environment");
        set => SetArgument("deployment_environment", value);
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("enable_calling")]
    public TerraformValue<bool> EnableCalling
    {
        get => new TerraformReference<bool>(this, "enable_calling");
        set => SetArgument("enable_calling", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBotChannelMsTeamsTimeoutsBlock Timeouts { get; set; } = new();

}
