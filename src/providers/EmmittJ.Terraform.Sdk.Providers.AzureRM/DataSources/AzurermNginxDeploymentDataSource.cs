using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNginxDeploymentDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_deployment.
/// </summary>
public partial class AzurermNginxDeploymentDataSource : TerraformDataSource
{
    public AzurermNginxDeploymentDataSource(string name) : base("azurerm_nginx_deployment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNginxDeploymentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    [TerraformProperty("auto_scale_profile")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutoScaleProfile { get; }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_channel")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutomaticUpgradeChannel { get; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Capacity { get; }

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformProperty("dataplane_api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataplaneApiEndpoint { get; }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformProperty("diagnose_support_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DiagnoseSupportEnabled { get; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Email { get; }

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    [TerraformProperty("frontend_private")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FrontendPrivate { get; }

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    [TerraformProperty("frontend_public")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FrontendPublic { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [TerraformProperty("logging_storage_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LoggingStorageAccount { get; }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedResourceGroup { get; }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkInterface { get; }

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformProperty("nginx_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NginxVersion { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    [TerraformProperty("web_application_firewall")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WebApplicationFirewall { get; }

}
