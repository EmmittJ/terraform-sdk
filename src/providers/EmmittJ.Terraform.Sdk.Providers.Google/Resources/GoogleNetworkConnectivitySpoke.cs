using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for linked_interconnect_attachments in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeImportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_import_ranges");
        set => WithProperty("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformProperty<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("site_to_site_data_transfer");
        set => WithProperty("site_to_site_data_transfer", value);
    }

    /// <summary>
    /// The URIs of linked interconnect attachment resources
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public List<TerraformProperty<string>>? Uris
    {
        get => GetProperty<List<TerraformProperty<string>>>("uris");
        set => WithProperty("uris", value);
    }

}

/// <summary>
/// Block type for linked_producer_vpc_network in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludeExportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclude_export_ranges");
        set => WithProperty("exclude_export_ranges", value);
    }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeExportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_export_ranges");
        set => WithProperty("include_export_ranges", value);
    }

    /// <summary>
    /// The URI of the Service Consumer VPC that the Producer VPC is peered with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// The name of the VPC peering between the Service Consumer VPC and the Producer VPC (defined in the Tenant project) which is added to the NCC hub. This peering must be in ACTIVE state.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformProperty<string> Peering
    {
        get => GetRequiredProperty<TerraformProperty<string>>("peering");
        set => WithProperty("peering", value);
    }

    /// <summary>
    /// The URI of the Producer VPC.
    /// </summary>
    public TerraformProperty<string>? ProducerNetwork
    {
        get => GetProperty<TerraformProperty<string>>("producer_network");
        set => WithProperty("producer_network", value);
    }

}

/// <summary>
/// Block type for linked_router_appliance_instances in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock : TerraformBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeImportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_import_ranges");
        set => WithProperty("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformProperty<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("site_to_site_data_transfer");
        set => WithProperty("site_to_site_data_transfer", value);
    }

}

/// <summary>
/// Block type for linked_vpc_network in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// IP ranges encompassing the subnets to be excluded from peering.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludeExportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclude_export_ranges");
        set => WithProperty("exclude_export_ranges", value);
    }

    /// <summary>
    /// IP ranges allowed to be included from peering.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeExportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_export_ranges");
        set => WithProperty("include_export_ranges", value);
    }

    /// <summary>
    /// The URI of the VPC network resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for linked_vpn_tunnels in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock : TerraformBlock
{
    /// <summary>
    /// IP ranges allowed to be included during import from hub (does not control transit connectivity).
    /// The only allowed value for now is &amp;quot;ALL_IPV4_RANGES&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeImportRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_import_ranges");
        set => WithProperty("include_import_ranges", value);
    }

    /// <summary>
    /// A value that controls whether site-to-site data transfer is enabled for these resources. Note that data transfer is available only in supported locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteToSiteDataTransfer is required")]
    public required TerraformProperty<bool> SiteToSiteDataTransfer
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("site_to_site_data_transfer");
        set => WithProperty("site_to_site_data_transfer", value);
    }

    /// <summary>
    /// The URIs of linked VPN tunnel resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uris is required")]
    public List<TerraformProperty<string>>? Uris
    {
        get => GetProperty<List<TerraformProperty<string>>>("uris");
        set => WithProperty("uris", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivitySpokeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_connectivity_spoke resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivitySpoke : TerraformResource
{
    public GoogleNetworkConnectivitySpoke(string name) : base("google_network_connectivity_spoke", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("reasons");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("unique_id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// An optional description of the spoke.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name of the group that this spoke is associated with.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// Immutable. The URI of the hub that this spoke is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hub is required")]
    public required TerraformProperty<string> Hub
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hub");
        set => this.WithProperty("hub", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Immutable. The name of the spoke. Spoke names must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for linked_interconnect_attachments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedInterconnectAttachments block(s) allowed")]
    public List<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock>? LinkedInterconnectAttachments
    {
        get => GetProperty<List<GoogleNetworkConnectivitySpokeLinkedInterconnectAttachmentsBlock>>("linked_interconnect_attachments");
        set => this.WithProperty("linked_interconnect_attachments", value);
    }

    /// <summary>
    /// Block for linked_producer_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedProducerVpcNetwork block(s) allowed")]
    public List<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock>? LinkedProducerVpcNetwork
    {
        get => GetProperty<List<GoogleNetworkConnectivitySpokeLinkedProducerVpcNetworkBlock>>("linked_producer_vpc_network");
        set => this.WithProperty("linked_producer_vpc_network", value);
    }

    /// <summary>
    /// Block for linked_router_appliance_instances.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedRouterApplianceInstances block(s) allowed")]
    public List<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock>? LinkedRouterApplianceInstances
    {
        get => GetProperty<List<GoogleNetworkConnectivitySpokeLinkedRouterApplianceInstancesBlock>>("linked_router_appliance_instances");
        set => this.WithProperty("linked_router_appliance_instances", value);
    }

    /// <summary>
    /// Block for linked_vpc_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpcNetwork block(s) allowed")]
    public List<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock>? LinkedVpcNetwork
    {
        get => GetProperty<List<GoogleNetworkConnectivitySpokeLinkedVpcNetworkBlock>>("linked_vpc_network");
        set => this.WithProperty("linked_vpc_network", value);
    }

    /// <summary>
    /// Block for linked_vpn_tunnels.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedVpnTunnels block(s) allowed")]
    public List<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock>? LinkedVpnTunnels
    {
        get => GetProperty<List<GoogleNetworkConnectivitySpokeLinkedVpnTunnelsBlock>>("linked_vpn_tunnels");
        set => this.WithProperty("linked_vpn_tunnels", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivitySpokeTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkConnectivitySpokeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time the spoke was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The reasons for the current state in the lifecycle
    /// </summary>
    public TerraformExpression Reasons => this["reasons"];

    /// <summary>
    /// Output only. The current lifecycle state of this spoke.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The Google-generated UUID for the spoke. This value is unique across all spoke resources. If a spoke is deleted and another with the same name is created, the new spoke is assigned a different unique_id.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

    /// <summary>
    /// Output only. The time the spoke was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
