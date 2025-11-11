using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementApiDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public partial class AzurermApiManagementApiDataSource : TerraformDataSource
{
    public AzurermApiManagementApiDataSource(string name) : base("azurerm_api_management_api", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformProperty("revision")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Revision { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementApiDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformProperty("is_current")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsCurrent { get; }

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformProperty("is_online")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsOnline { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Path { get; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Protocols { get; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformProperty("service_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceUrl { get; }

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    [TerraformProperty("soap_pass_through")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SoapPassThrough { get; }

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    [TerraformProperty("subscription_key_parameter_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SubscriptionKeyParameterNames { get; }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformProperty("subscription_required")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SubscriptionRequired { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformProperty("version_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionSetId { get; }

}
