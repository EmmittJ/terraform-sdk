using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for site in AzurermBotChannelDirectline.
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelDirectlineSiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EndpointParametersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("endpoint_parameters_enabled");
        set => SetArgument("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The enhanced_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("enhanced_authentication_enabled");
        set => SetArgument("enhanced_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
        => AsReference("key");

    /// <summary>
    /// The key2 attribute.
    /// </summary>
    public TerraformValue<string> Key2
        => AsReference("key2");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEnabled
    {
        get => GetArgument<TerraformValue<bool>>("storage_enabled");
        set => SetArgument("storage_enabled", value);
    }

    /// <summary>
    /// The trusted_origins attribute.
    /// </summary>
    public TerraformSet<string>? TrustedOrigins
    {
        get => GetArgument<TerraformSet<string>>("trusted_origins");
        set => SetArgument("trusted_origins", value);
    }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserUploadEnabled
    {
        get => GetArgument<TerraformValue<bool>>("user_upload_enabled");
        set => SetArgument("user_upload_enabled", value);
    }

    /// <summary>
    /// The v1_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? V1Allowed
    {
        get => GetArgument<TerraformValue<bool>>("v1_allowed");
        set => SetArgument("v1_allowed", value);
    }

    /// <summary>
    /// The v3_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? V3Allowed
    {
        get => GetArgument<TerraformValue<bool>>("v3_allowed");
        set => SetArgument("v3_allowed", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBotChannelDirectline.
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelDirectlineTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_bot_channel_directline Terraform resource.
/// Manages a azurerm_bot_channel_directline resource.
/// </summary>
public partial class AzurermBotChannelDirectline(string name) : TerraformResource("azurerm_bot_channel_directline", name)
{
    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformValue<string> BotName
    {
        get => GetArgument<TerraformValue<string>>("bot_name");
        set => SetArgument("bot_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Site block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    public required TerraformSet<AzurermBotChannelDirectlineSiteBlock> Site
    {
        get => GetRequiredArgument<TerraformSet<AzurermBotChannelDirectlineSiteBlock>>("site");
        set => SetArgument("site", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotChannelDirectlineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotChannelDirectlineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
