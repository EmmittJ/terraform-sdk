using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_static_web_app.
/// </summary>
public class AzurermStaticWebAppDataSource : TerraformDataSource
{
    public AzurermStaticWebAppDataSource(string name) : base("azurerm_static_web_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStaticWebAppDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppSettings => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_settings");

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BasicAuth => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "basic_auth");

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("configuration_file_changes_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConfigurationFileChangesEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "configuration_file_changes_enabled");

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    [TerraformPropertyName("default_host_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultHostName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_host_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    [TerraformPropertyName("preview_environments_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PreviewEnvironmentsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "preview_environments_enabled");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_network_access_enabled");

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    [TerraformPropertyName("repository_branch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryBranch => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_branch");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformPropertyName("repository_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_url");

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    [TerraformPropertyName("sku_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuSize => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_size");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
