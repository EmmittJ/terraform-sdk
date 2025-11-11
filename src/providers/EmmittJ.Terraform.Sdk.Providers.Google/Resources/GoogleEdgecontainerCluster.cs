using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterAuthorizationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterControlPlaneBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for control_plane_encryption in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterControlPlaneEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The Cloud KMS CryptoKey e.g.
    /// projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// to use for protecting control plane disks. If not specified, a
    /// Google-managed key will be used instead.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKey { get; set; }




}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterFleetBlock : TerraformBlockBase
{

    /// <summary>
    /// The name of the Fleet host project where this cluster will be registered.
    /// Project names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Project { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterMaintenancePolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for networking in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterNetworkingBlock : TerraformBlockBase
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIpv4CidrBlocks is required")]
    [TerraformProperty("cluster_ipv4_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ClusterIpv4CidrBlocks { get; set; }

    /// <summary>
    /// If specified, dual stack mode is enabled and all pods in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [TerraformProperty("cluster_ipv6_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ClusterIpv6CidrBlocks { get; set; }


    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicesIpv4CidrBlocks is required")]
    [TerraformProperty("services_ipv4_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ServicesIpv4CidrBlocks { get; set; }

    /// <summary>
    /// If specified, dual stack mode is enabled and all services in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [TerraformProperty("services_ipv6_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ServicesIpv6CidrBlocks { get; set; }

}

/// <summary>
/// Block type for system_addons_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEdgecontainerClusterSystemAddonsConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleEdgecontainerClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_edgecontainer_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleEdgecontainerCluster : TerraformResource
{
    public GoogleEdgecontainerCluster(string name) : base("google_edgecontainer_cluster", name)
    {
    }

    /// <summary>
    /// The default maximum number of pods per node used if a maximum value is not
    /// specified explicitly for a node pool in this cluster. If unspecified, the
    /// Kubernetes default value will be used.
    /// </summary>
    [TerraformProperty("default_max_pods_per_node")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DefaultMaxPodsPerNode { get; set; }

    /// <summary>
    /// Address pools for cluster data plane external load balancing.
    /// </summary>
    [TerraformProperty("external_load_balancer_ipv4_address_pools")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> ExternalLoadBalancerIpv4AddressPools { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the edgecloud cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The GDCE cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The release channel a cluster is subscribed to. Possible values: [&amp;quot;RELEASE_CHANNEL_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;REGULAR&amp;quot;]
    /// </summary>
    [TerraformProperty("release_channel")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReleaseChannel { get; set; }

    /// <summary>
    /// The target cluster version. For example: &amp;quot;1.5.0&amp;quot;.
    /// </summary>
    [TerraformProperty("target_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TargetVersion { get; set; }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformProperty("authorization")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterAuthorizationBlock>>? Authorization { get; set; }

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    [TerraformProperty("control_plane")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterControlPlaneBlock>>? ControlPlane { get; set; }

    /// <summary>
    /// Block for control_plane_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEncryption block(s) allowed")]
    [TerraformProperty("control_plane_encryption")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterControlPlaneEncryptionBlock>>? ControlPlaneEncryption { get; set; }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformProperty("fleet")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterFleetBlock>>? Fleet { get; set; }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformProperty("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterMaintenancePolicyBlock>>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Block for networking.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    [TerraformProperty("networking")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterNetworkingBlock>>? Networking { get; set; }

    /// <summary>
    /// Block for system_addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemAddonsConfig block(s) allowed")]
    [TerraformProperty("system_addons_config")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterSystemAddonsConfigBlock>>? SystemAddonsConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleEdgecontainerClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The PEM-encoded public certificate of the cluster&#39;s CA.
    /// </summary>
    [TerraformProperty("cluster_ca_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterCaCertificate { get; }

    /// <summary>
    /// The control plane release version.
    /// </summary>
    [TerraformProperty("control_plane_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlPlaneVersion { get; }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The IP address of the Kubernetes API server.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// All the maintenance events scheduled for the cluster, including the ones
    /// ongoing, planned for the future and done in the past (up to 90 days).
    /// </summary>
    [TerraformProperty("maintenance_events")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceEvents { get; }

    /// <summary>
    /// The lowest release version among all worker nodes. This field can be empty
    /// if the cluster does not have any worker nodes.
    /// </summary>
    [TerraformProperty("node_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeVersion { get; }

    /// <summary>
    /// The port number of the Kubernetes API server.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// Indicates the status of the cluster.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
