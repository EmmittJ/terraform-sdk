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
        set => SetProperty("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEnabled
    {
        set => SetProperty("storage_enabled", value);
    }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserUploadEnabled
    {
        set => SetProperty("user_upload_enabled", value);
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
        SetOutput("bot_name");
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
    /// Block for site.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermBotChannelWebChatSiteBlock>? Site
    {
        set => SetProperty("site", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelWebChatTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
