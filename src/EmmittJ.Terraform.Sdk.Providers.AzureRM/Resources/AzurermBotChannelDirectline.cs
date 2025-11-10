using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for site in .
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelDirectlineSiteBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointParametersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("endpoint_parameters_enabled");
        set => WithProperty("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The enhanced_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("enhanced_authentication_enabled");
        set => WithProperty("enhanced_authentication_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The key2 attribute.
    /// </summary>
    public TerraformProperty<string>? Key2
    {
        get => GetProperty<TerraformProperty<string>>("key2");
        set => WithProperty("key2", value);
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
    /// The trusted_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TrustedOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("trusted_origins");
        set => WithProperty("trusted_origins", value);
    }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UserUploadEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("user_upload_enabled");
        set => WithProperty("user_upload_enabled", value);
    }

    /// <summary>
    /// The v1_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? V1Allowed
    {
        get => GetProperty<TerraformProperty<bool>>("v1_allowed");
        set => WithProperty("v1_allowed", value);
    }

    /// <summary>
    /// The v3_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? V3Allowed
    {
        get => GetProperty<TerraformProperty<bool>>("v3_allowed");
        set => WithProperty("v3_allowed", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelDirectlineTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bot_channel_directline resource.
/// </summary>
public class AzurermBotChannelDirectline : TerraformResource
{
    public AzurermBotChannelDirectline(string name) : base("azurerm_bot_channel_directline", name)
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
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    public HashSet<AzurermBotChannelDirectlineSiteBlock>? Site
    {
        get => GetProperty<HashSet<AzurermBotChannelDirectlineSiteBlock>>("site");
        set => this.WithProperty("site", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelDirectlineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBotChannelDirectlineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
