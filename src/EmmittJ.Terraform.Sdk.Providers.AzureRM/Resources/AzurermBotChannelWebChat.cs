using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for site in .
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelWebChatSiteBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointParametersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("endpoint_parameters_enabled");
        set => WithProperty("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("storage_enabled");
        set => WithProperty("storage_enabled", value);
    }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserUploadEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("user_upload_enabled");
        set => WithProperty("user_upload_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelWebChatTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bot_channel_web_chat resource.
/// </summary>
public class AzurermBotChannelWebChat : TerraformResource
{
    public AzurermBotChannelWebChat(string name) : base("azurerm_bot_channel_web_chat", name)
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
    /// Block for site.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermBotChannelWebChatSiteBlock>? Site
    {
        get => GetProperty<HashSet<AzurermBotChannelWebChatSiteBlock>>("site");
        set => this.WithProperty("site", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelWebChatTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBotChannelWebChatTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
