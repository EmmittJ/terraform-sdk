using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_partner_namespace.
/// </summary>
public class AzurermEventgridPartnerNamespaceDataSource : TerraformDataSource
{
    public AzurermEventgridPartnerNamespaceDataSource(string name) : base("azurerm_eventgrid_partner_namespace", name)
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
    public TerraformBlock<AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformPropertyName("inbound_ip_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InboundIpRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "inbound_ip_rule");

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalAuthenticationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_authentication_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [TerraformPropertyName("partner_registration_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PartnerRegistrationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partner_registration_id");

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    [TerraformPropertyName("partner_topic_routing_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PartnerTopicRoutingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partner_topic_routing_mode");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicNetworkAccess => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_network_access");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
