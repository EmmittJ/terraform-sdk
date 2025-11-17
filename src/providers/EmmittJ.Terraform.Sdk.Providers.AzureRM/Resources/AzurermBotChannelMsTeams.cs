using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBotChannelMsTeams.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_bot_channel_ms_teams Terraform resource.
/// Manages a azurerm_bot_channel_ms_teams resource.
/// </summary>
public partial class AzurermBotChannelMsTeams(string name) : TerraformResource("azurerm_bot_channel_ms_teams", name)
{
    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformValue<string> BotName
    {
        get => new TerraformReference<string>(this, "bot_name");
        set => SetArgument("bot_name", value);
    }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CallingEnabled
    {
        get => new TerraformReference<bool>(this, "calling_enabled");
        set => SetArgument("calling_enabled", value);
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    public TerraformValue<string> CallingWebHook
    {
        get => new TerraformReference<string>(this, "calling_web_hook");
        set => SetArgument("calling_web_hook", value);
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentEnvironment
    {
        get => new TerraformReference<string>(this, "deployment_environment");
        set => SetArgument("deployment_environment", value);
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableCalling
    {
        get => new TerraformReference<bool>(this, "enable_calling");
        set => SetArgument("enable_calling", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotChannelMsTeamsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotChannelMsTeamsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
