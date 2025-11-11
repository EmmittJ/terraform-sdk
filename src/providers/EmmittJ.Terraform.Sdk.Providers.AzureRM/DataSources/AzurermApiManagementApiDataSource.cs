using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public class AzurermApiManagementApiDataSource : TerraformDataSource
{
    public AzurermApiManagementApiDataSource(string name) : base("azurerm_api_management_api", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementName { get; set; }

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
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Revision { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementApiDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformPropertyName("is_current")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsCurrent => new TerraformReference(this, "is_current");

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformPropertyName("is_online")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsOnline => new TerraformReference(this, "is_online");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Path => new TerraformReference(this, "path");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Protocols => new TerraformReference(this, "protocols");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceUrl => new TerraformReference(this, "service_url");

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    [TerraformPropertyName("soap_pass_through")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SoapPassThrough => new TerraformReference(this, "soap_pass_through");

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    [TerraformPropertyName("subscription_key_parameter_names")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SubscriptionKeyParameterNames => new TerraformReference(this, "subscription_key_parameter_names");

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformPropertyName("subscription_required")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SubscriptionRequired => new TerraformReference(this, "subscription_required");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformPropertyName("version_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionSetId => new TerraformReference(this, "version_set_id");

}
