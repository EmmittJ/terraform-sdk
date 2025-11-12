using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleEdgecontainerVpnConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for vpc_project in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerVpnConnectionVpcProjectBlock() : TerraformBlock("vpc_project")
{
    /// <summary>
    /// The project of the VPC to connect to. If not specified, it is the same as the cluster project.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectId { get; set; }

}

/// <summary>
/// Manages a google_edgecontainer_vpn_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleEdgecontainerVpnConnection : TerraformResource
{
    public GoogleEdgecontainerVpnConnection(string name) : base("google_edgecontainer_vpn_connection", name)
    {
    }

    /// <summary>
    /// The canonical Cluster name to connect to. It is in the form of projects/{project}/locations/{location}/clusters/{cluster}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// Whether this VPN connection has HA enabled on cluster side. If enabled, when creating VPN connection we will attempt to use 2 ANG floating IPs.
    /// </summary>
    [TerraformProperty("enable_high_availability")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableHighAvailability { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Google Cloud Platform location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of VPN connection
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// NAT gateway IP, or WAN IP address. If a customer has multiple NAT IPs, the customer needs to configure NAT such that only one external IP maps to the GMEC Anthos cluster.
    /// This is empty if NAT is not used.
    /// </summary>
    [TerraformProperty("nat_gateway_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NatGatewayIp { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The VPN connection Cloud Router name.
    /// </summary>
    [TerraformProperty("router")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Router { get; set; }

    /// <summary>
    /// The network ID of VPC to connect to.
    /// </summary>
    [TerraformProperty("vpc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vpc { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleEdgecontainerVpnConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_project.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcProject block(s) allowed")]
    [TerraformProperty("vpc_project")]
    public TerraformList<GoogleEdgecontainerVpnConnectionVpcProjectBlock> VpcProject { get; set; } = new();

    /// <summary>
    /// The time when the VPN connection was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    [TerraformProperty("details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Details { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the VPN connection was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
