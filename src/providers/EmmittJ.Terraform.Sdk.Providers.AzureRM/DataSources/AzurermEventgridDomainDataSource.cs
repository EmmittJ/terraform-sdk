using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridDomainDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_domain.
/// </summary>
public class AzurermEventgridDomainDataSource : TerraformDataSource
{
    public AzurermEventgridDomainDataSource(string name) : base("azurerm_eventgrid_domain", name)
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
    public TerraformBlock<AzurermEventgridDomainDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformPropertyName("inbound_ip_rule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InboundIpRule => new TerraformReference(this, "inbound_ip_rule");

    /// <summary>
    /// The input_mapping_default_values attribute.
    /// </summary>
    [TerraformPropertyName("input_mapping_default_values")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InputMappingDefaultValues => new TerraformReference(this, "input_mapping_default_values");

    /// <summary>
    /// The input_mapping_fields attribute.
    /// </summary>
    [TerraformPropertyName("input_mapping_fields")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InputMappingFields => new TerraformReference(this, "input_mapping_fields");

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    [TerraformPropertyName("input_schema")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InputSchema => new TerraformReference(this, "input_schema");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
