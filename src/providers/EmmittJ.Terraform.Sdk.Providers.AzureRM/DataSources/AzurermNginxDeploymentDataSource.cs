using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_deployment.
/// </summary>
public class AzurermNginxDeploymentDataSource : TerraformDataSource
{
    public AzurermNginxDeploymentDataSource(string name) : base("azurerm_nginx_deployment", name)
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
    public TerraformBlock<AzurermNginxDeploymentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    [TerraformPropertyName("auto_scale_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoScaleProfile => new TerraformReference(this, "auto_scale_profile");

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_channel")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutomaticUpgradeChannel => new TerraformReference(this, "automatic_upgrade_channel");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Capacity => new TerraformReference(this, "capacity");

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("dataplane_api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataplaneApiEndpoint => new TerraformReference(this, "dataplane_api_endpoint");

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformPropertyName("diagnose_support_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DiagnoseSupportEnabled => new TerraformReference(this, "diagnose_support_enabled");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    [TerraformPropertyName("frontend_private")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FrontendPrivate => new TerraformReference(this, "frontend_private");

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    [TerraformPropertyName("frontend_public")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FrontendPublic => new TerraformReference(this, "frontend_public");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [TerraformPropertyName("logging_storage_account")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LoggingStorageAccount => new TerraformReference(this, "logging_storage_account");

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedResourceGroup => new TerraformReference(this, "managed_resource_group");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkInterface => new TerraformReference(this, "network_interface");

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformPropertyName("nginx_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NginxVersion => new TerraformReference(this, "nginx_version");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    [TerraformPropertyName("web_application_firewall")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WebApplicationFirewall => new TerraformReference(this, "web_application_firewall");

}
