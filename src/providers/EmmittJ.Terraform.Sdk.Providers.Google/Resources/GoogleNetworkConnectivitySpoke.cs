using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for linked_interconnect_attachments in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock() : TerraformBlock("linked_interconnect_attachments")
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformProperty("include_import_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformProperty("site_to_site_data_transfer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

    /// <summary>
    /// The URIs of linked interconnect attachment resources
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformProperty("uris")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Uris { get; set; }

}

/// <summary>
/// Block type for linked_producer_vpc_network in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock() : TerraformBlock("linked_producer_vpc_network")
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    [TerraformProperty("exclude_export_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludeExportRanges { get; set; }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    [TerraformProperty("include_export_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeExportRanges { get; set; }

    /// <summary>
    /// The URI of the Service Consumer VPC that the Producer VPC is peered with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The name of the VPC peering between the Service Consumer VPC and the Producer VPC (defined in the Tenant project) which is added to the NCC hub. This peering must be in ACTIVE state.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    [TerraformProperty("peering")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Peering { get; set; }


}

/// <summary>
/// Block type for linked_router_appliance_instances in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock() : TerraformBlock("linked_router_appliance_instances")
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformProperty("include_import_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformProperty("site_to_site_data_transfer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

}

/// <summary>
/// Block type for linked_vpc_network in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock() : TerraformBlock("linked_vpc_network")
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    [TerraformProperty("exclude_export_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludeExportRanges { get; set; }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    [TerraformProperty("include_export_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeExportRanges { get; set; }

    /// <summary>
    /// The URI of the VPC network resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for linked_vpn_tunnels in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock() : TerraformBlock("linked_vpn_tunnels")
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    [TerraformProperty("include_import_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeImportRanges { get; set; }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    [TerraformProperty("site_to_site_data_transfer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SiteToSiteDataTransfer { get; set; }

    /// <summary>
    /// The URIs of linked VPN tunnel resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    [TerraformProperty("uris")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Uris { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkConnectivitySpokeTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_spoke resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkConnectivitySpoke : TerraformResource
{
    public GoogleNetworkConnectivitySpoke(string name) : base("google_network_connectivity_spoke", name)
    {
    }

    /// <summary>
    /// An optional description of the spoke.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of the group that this spoke is associated with.
    /// </summary>
    [TerraformProperty("group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Group { get; set; }

    /// <summary>
    /// Immutable. The URI of the hub that this spoke is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hub is required")]
    [TerraformProperty("hub")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hub { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The name of the spoke. Spoke names must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for linked_interconnect_attachments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedInterconnectAttachments block(s) allowed")]
    [TerraformProperty("linked_interconnect_attachments")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock> LinkedInterconnectAttachments { get; set; } = new();

    /// <summary>
    /// Block for linked_producer_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedProducerVpcNetwork block(s) allowed")]
    [TerraformProperty("linked_producer_vpc_network")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock> LinkedProducerVpcNetwork { get; set; } = new();

    /// <summary>
    /// Block for linked_router_appliance_instances.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedRouterApplianceInstances block(s) allowed")]
    [TerraformProperty("linked_router_appliance_instances")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock> LinkedRouterApplianceInstances { get; set; } = new();

    /// <summary>
    /// Block for linked_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpcNetwork block(s) allowed")]
    [TerraformProperty("linked_vpc_network")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock> LinkedVpcNetwork { get; set; } = new();

    /// <summary>
    /// Block for linked_vpn_tunnels.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpnTunnels block(s) allowed")]
    [TerraformProperty("linked_vpn_tunnels")]
    public TerraformList<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock> LinkedVpnTunnels { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkConnectivitySpokeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time the spoke was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The reasons for the current state in the lifecycle
    /// </summary>
    [TerraformProperty("reasons")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Reasons { get; }

    /// <summary>
    /// Output only. The current lifecycle state of this spoke.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The Google-generated UUID for the spoke. This value is unique across all spoke resources. If a spoke is deleted and another with the same name is created, the new spoke is assigned a different unique_id.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueId { get; }

    /// <summary>
    /// Output only. The time the spoke was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
