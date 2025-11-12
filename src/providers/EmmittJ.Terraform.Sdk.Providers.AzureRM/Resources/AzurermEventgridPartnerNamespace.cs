using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for inbound_ip_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermEventgridPartnerNamespaceInboundIpRuleBlock() : TerraformBlock("inbound_ip_rule")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    [TerraformProperty("ip_mask")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpMask { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermEventgridPartnerNamespaceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_eventgrid_partner_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermEventgridPartnerNamespace : TerraformResource
{
    public AzurermEventgridPartnerNamespace(string name) : base("azurerm_eventgrid_partner_namespace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
    [TerraformProperty("partner_registration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PartnerRegistrationId { get; set; }

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    [TerraformProperty("partner_topic_routing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartnerTopicRoutingMode { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicNetworkAccess { get; set; }

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
    /// Block for inbound_ip_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(16, ErrorMessage = "Maximum 16 InboundIpRule block(s) allowed")]
    [TerraformProperty("inbound_ip_rule")]
    public TerraformList<AzurermEventgridPartnerNamespaceInboundIpRuleBlock> InboundIpRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermEventgridPartnerNamespaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

}
