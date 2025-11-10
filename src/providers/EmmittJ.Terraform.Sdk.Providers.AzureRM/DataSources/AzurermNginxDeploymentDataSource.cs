using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermNginxDeploymentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    [TerraformPropertyName("auto_scale_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoScaleProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auto_scale_profile");

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_channel")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutomaticUpgradeChannel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "automatic_upgrade_channel");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Capacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "capacity");

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("dataplane_api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataplaneApiEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dataplane_api_endpoint");

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformPropertyName("diagnose_support_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DiagnoseSupportEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "diagnose_support_enabled");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    [TerraformPropertyName("frontend_private")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FrontendPrivate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "frontend_private");

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    [TerraformPropertyName("frontend_public")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FrontendPublic => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "frontend_public");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [TerraformPropertyName("logging_storage_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LoggingStorageAccount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging_storage_account");

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagedResourceGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_resource_group");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkInterface => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_interface");

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformPropertyName("nginx_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NginxVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nginx_version");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    [TerraformPropertyName("web_application_firewall")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WebApplicationFirewall => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "web_application_firewall");

}
