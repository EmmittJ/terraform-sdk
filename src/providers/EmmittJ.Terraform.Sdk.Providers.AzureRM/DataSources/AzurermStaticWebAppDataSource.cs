using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStaticWebAppDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiKey => new TerraformReference(this, "api_key");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppSettings => new TerraformReference(this, "app_settings");

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    [TerraformPropertyName("basic_auth")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BasicAuth => new TerraformReference(this, "basic_auth");

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    [TerraformPropertyName("configuration_file_changes_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConfigurationFileChangesEnabled => new TerraformReference(this, "configuration_file_changes_enabled");

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    [TerraformPropertyName("default_host_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultHostName => new TerraformReference(this, "default_host_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    [TerraformPropertyName("preview_environments_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PreviewEnvironmentsEnabled => new TerraformReference(this, "preview_environments_enabled");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    [TerraformPropertyName("repository_branch")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RepositoryBranch => new TerraformReference(this, "repository_branch");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformPropertyName("repository_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RepositoryUrl => new TerraformReference(this, "repository_url");

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    [TerraformPropertyName("sku_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuSize => new TerraformReference(this, "sku_size");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuTier => new TerraformReference(this, "sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
