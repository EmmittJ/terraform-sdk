using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for site in .
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelDirectlineSiteBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_parameters_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EndpointParametersEnabled { get; set; }

    /// <summary>
    /// The enhanced_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnhancedAuthenticationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Key => new TerraformReferenceProperty<TerraformProperty<string>>("", "key");

    /// <summary>
    /// The key2 attribute.
    /// </summary>
    [TerraformPropertyName("key2")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Key2 => new TerraformReferenceProperty<TerraformProperty<string>>("", "key2");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    [TerraformPropertyName("storage_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StorageEnabled { get; set; }

    /// <summary>
    /// The trusted_origins attribute.
    /// </summary>
    [TerraformPropertyName("trusted_origins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TrustedOrigins { get; set; }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    [TerraformPropertyName("user_upload_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UserUploadEnabled { get; set; }

    /// <summary>
    /// The v1_allowed attribute.
    /// </summary>
    [TerraformPropertyName("v1_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? V1Allowed { get; set; }

    /// <summary>
    /// The v3_allowed attribute.
    /// </summary>
    [TerraformPropertyName("v3_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? V3Allowed { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelDirectlineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("bot_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for site.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [TerraformPropertyName("site")]
    public TerraformSet<TerraformBlock<AzurermBotChannelDirectlineSiteBlock>>? Site { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBotChannelDirectlineTimeoutsBlock>? Timeouts { get; set; } = new();

}
