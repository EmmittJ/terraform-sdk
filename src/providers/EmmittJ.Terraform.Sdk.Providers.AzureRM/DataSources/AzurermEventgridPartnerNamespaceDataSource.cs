using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_partner_namespace.
/// </summary>
public partial class AzurermEventgridPartnerNamespaceDataSource : TerraformDataSource
{
    public AzurermEventgridPartnerNamespaceDataSource(string name) : base("azurerm_eventgrid_partner_namespace", name)
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
    public AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformProperty("inbound_ip_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InboundIpRule { get; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LocalAuthenticationEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [TerraformProperty("partner_registration_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PartnerRegistrationId { get; }

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    [TerraformProperty("partner_topic_routing_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PartnerTopicRoutingMode { get; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicNetworkAccess { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
