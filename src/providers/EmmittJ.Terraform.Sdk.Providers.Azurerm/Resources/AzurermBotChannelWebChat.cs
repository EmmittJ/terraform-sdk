using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for site in AzurermBotChannelWebChat.
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelWebChatSiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site";

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EndpointParametersEnabled
    {
        get => GetArgument<TerraformValue<bool>>("endpoint_parameters_enabled");
        set => SetArgument("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
    /// The user_upload_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? UserUploadEnabled
    {
        get => GetArgument<TerraformValue<bool>>("user_upload_enabled");
        set => SetArgument("user_upload_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBotChannelWebChat.
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelWebChatTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_bot_channel_web_chat Terraform resource.
/// Manages a azurerm_bot_channel_web_chat resource.
/// </summary>
public partial class AzurermBotChannelWebChat(string name) : TerraformResource("azurerm_bot_channel_web_chat", name)
{
    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformValue<string> BotName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bot_name");
        set => SetArgument("bot_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Site block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermBotChannelWebChatSiteBlock>? Site
    {
        get => GetArgument<TerraformSet<AzurermBotChannelWebChatSiteBlock>>("site");
        set => SetArgument("site", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotChannelWebChatTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotChannelWebChatTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
