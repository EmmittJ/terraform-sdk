using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_function_app.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class AzurermFunctionAppDataSource : TerraformDataSource
{
    public AzurermFunctionAppDataSource(string name) : base("azurerm_function_app", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFunctionAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformProperty("app_service_plan_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AppServicePlanId { get; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> AppSettings { get; }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    [TerraformProperty("client_cert_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientCertMode { get; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConnectionString { get; }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsType { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PossibleOutboundIpAddresses { get; }

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformProperty("site_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteConfig { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteCredential { get; }

    /// <summary>
    /// The source_control attribute.
    /// </summary>
    [TerraformProperty("source_control")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SourceControl { get; }

}
