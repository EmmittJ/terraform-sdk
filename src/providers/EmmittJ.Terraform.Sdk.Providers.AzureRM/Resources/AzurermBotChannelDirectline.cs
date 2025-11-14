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
/// Block type for site in .
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
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    [TerraformArgument("endpoint_parameters_enabled")]
    public TerraformValue<bool>? EndpointParametersEnabled
    {
        get => new TerraformReference<bool>(this, "endpoint_parameters_enabled");
        set => SetArgument("endpoint_parameters_enabled", value);
    }

    /// <summary>
    /// The enhanced_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("enhanced_authentication_enabled")]
    public TerraformValue<bool>? EnhancedAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "enhanced_authentication_enabled");
        set => SetArgument("enhanced_authentication_enabled", value);
    }




    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    [TerraformArgument("storage_enabled")]
    public TerraformValue<bool>? StorageEnabled
    {
        get => new TerraformReference<bool>(this, "storage_enabled");
        set => SetArgument("storage_enabled", value);
    }

    /// <summary>
    /// The trusted_origins attribute.
    /// </summary>
    [TerraformArgument("trusted_origins")]
    public TerraformSet<string>? TrustedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "trusted_origins").ResolveNodes(ctx));
        set => SetArgument("trusted_origins", value);
    }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    [TerraformArgument("user_upload_enabled")]
    public TerraformValue<bool>? UserUploadEnabled
    {
        get => new TerraformReference<bool>(this, "user_upload_enabled");
        set => SetArgument("user_upload_enabled", value);
    }

    /// <summary>
    /// The v1_allowed attribute.
    /// </summary>
    [TerraformArgument("v1_allowed")]
    public TerraformValue<bool>? V1Allowed
    {
        get => new TerraformReference<bool>(this, "v1_allowed");
        set => SetArgument("v1_allowed", value);
    }

    /// <summary>
    /// The v3_allowed attribute.
    /// </summary>
    [TerraformArgument("v3_allowed")]
    public TerraformValue<bool>? V3Allowed
    {
        get => new TerraformReference<bool>(this, "v3_allowed");
        set => SetArgument("v3_allowed", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_bot_channel_directline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBotChannelDirectline : TerraformResource
{
    public AzurermBotChannelDirectline(string name) : base("azurerm_bot_channel_directline", name)
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
    /// Block for site.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [TerraformArgument("site")]
    public required TerraformSet<AzurermBotChannelDirectlineSiteBlock> Site { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBotChannelDirectlineTimeoutsBlock Timeouts { get; set; } = new();

}
