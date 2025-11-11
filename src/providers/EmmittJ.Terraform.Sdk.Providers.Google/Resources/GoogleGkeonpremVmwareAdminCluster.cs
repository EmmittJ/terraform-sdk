using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addon_node in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterAddonNodeBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock : TerraformBlockBase
{
    /// <summary>
    /// Spread nodes across at least three physical hosts (requires at least three
    /// hosts).
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AagConfigDisabled is required")]
    [TerraformProperty("aag_config_disabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AagConfigDisabled { get; set; }

}

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterAuthorizationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether auto repair is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_node in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of vCPUs for the control-plane node of the admin cluster.
    /// </summary>
    [TerraformProperty("cpus")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Cpus { get; set; }

    /// <summary>
    /// The number of mebibytes of memory for the control-plane node of the admin cluster.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Memory { get; set; }

    /// <summary>
    /// The number of control plane nodes for this VMware admin cluster.
    /// </summary>
    [TerraformProperty("replicas")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Replicas { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges.
    /// Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    [TerraformProperty("pod_address_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? PodAddressCidrBlocks { get; set; }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address
    /// from these ranges. Only a single range is supported.. This field
    /// cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    [TerraformProperty("service_address_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>
    /// vcenter_network specifies vCenter network name.
    /// </summary>
    [TerraformProperty("vcenter_network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VcenterNetwork { get; set; }

}

/// <summary>
/// Block type for platform_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock : TerraformBlockBase
{


    /// <summary>
    /// The required platform version e.g. 1.13.1.
    /// If the current platform version is lower than the target version,
    /// the platform version will be updated to the target version.
    /// If the target version is not installed in the platform
    /// (bundle versions), download the target version bundle.
    /// </summary>
    [TerraformProperty("required_platform_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequiredPlatformVersion { get; set; }


}

/// <summary>
/// Block type for private_registry_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The registry address.
    /// </summary>
    [TerraformProperty("address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The CA certificate public key for private registry.
    /// </summary>
    [TerraformProperty("ca_cert")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CaCert { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterProxyBlock : TerraformBlockBase
{
    /// <summary>
    /// A comma-separated list of IP addresses, IP address ranges,
    /// host names, and domain names that should not go through the proxy server.
    /// </summary>
    [TerraformProperty("no_proxy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NoProxy { get; set; }

    /// <summary>
    /// The proxy url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterTimeoutsBlock : TerraformBlockBase
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
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareAdminClusterVcenterBlock : TerraformBlockBase
{
    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    [TerraformProperty("address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    [TerraformProperty("ca_cert_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CaCertData { get; set; }

    /// <summary>
    /// The name of the vCenter cluster for the admin cluster.
    /// </summary>
    [TerraformProperty("cluster")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Cluster { get; set; }

    /// <summary>
    /// The name of the virtual machine disk (VMDK) for the admin cluster.
    /// </summary>
    [TerraformProperty("data_disk")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataDisk { get; set; }

    /// <summary>
    /// The name of the vCenter datacenter for the admin cluster.
    /// </summary>
    [TerraformProperty("datacenter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Datacenter { get; set; }

    /// <summary>
    /// The name of the vCenter datastore for the admin cluster.
    /// </summary>
    [TerraformProperty("datastore")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Datastore { get; set; }

    /// <summary>
    /// The name of the vCenter folder for the admin cluster.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The name of the vCenter resource pool for the admin cluster.
    /// </summary>
    [TerraformProperty("resource_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourcePool { get; set; }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    [TerraformProperty("storage_policy_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StoragePolicyName { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_vmware_admin_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremVmwareAdminCluster : TerraformResource
{
    public GoogleGkeonpremVmwareAdminCluster(string name) : base("google_gkeonprem_vmware_admin_cluster", name)
    {
    }

    /// <summary>
    /// Annotations on the VMware Admin Cluster.
    /// This field has the same restrictions as Kubernetes annotations.
    /// The total size of all keys and values combined is limited to 256k.
    /// Key can have 2 segments: prefix (optional) and name (required),
    /// separated by a slash (/).
    /// Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Annotations { get; set; }

    /// <summary>
    /// The bootstrap cluster this VMware admin cluster belongs to.
    /// </summary>
    [TerraformProperty("bootstrap_cluster_membership")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BootstrapClusterMembership { get; set; }

    /// <summary>
    /// A human readable description of this VMware admin cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// If set, the advanced cluster feature is enabled.
    /// </summary>
    [TerraformProperty("enable_advanced_cluster")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableAdvancedCluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The OS image type for the VMware admin cluster.
    /// </summary>
    [TerraformProperty("image_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ImageType { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The VMware admin cluster resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Anthos clusters on the VMware version for the admin cluster.
    /// </summary>
    [TerraformProperty("on_prem_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for addon_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonNode block(s) allowed")]
    [TerraformProperty("addon_node")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAddonNodeBlock>>? AddonNode { get; set; }

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    [TerraformProperty("anti_affinity_groups")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock>>? AntiAffinityGroups { get; set; }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformProperty("authorization")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAuthorizationBlock>>? Authorization { get; set; }

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    [TerraformProperty("auto_repair_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock>>? AutoRepairConfig { get; set; }

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    [TerraformProperty("control_plane_node")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock>>? ControlPlaneNode { get; set; }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformProperty("load_balancer")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock>>? LoadBalancer { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for platform_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlatformConfig block(s) allowed")]
    [TerraformProperty("platform_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock>>? PlatformConfig { get; set; }

    /// <summary>
    /// Block for private_registry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryConfig block(s) allowed")]
    [TerraformProperty("private_registry_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock>>? PrivateRegistryConfig { get; set; }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformProperty("proxy")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterProxyBlock>>? Proxy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleGkeonpremVmwareAdminClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    [TerraformProperty("vcenter")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterVcenterBlock>>? Vcenter { get; set; }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// The DNS name of VMware admin cluster&#39;s API server.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Fleet configuration for the cluster.
    /// </summary>
    [TerraformProperty("fleet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Fleet { get; }

    /// <summary>
    /// The object name of the VMwareAdminCluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    [TerraformProperty("local_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LocalName { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the VMware admin cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The lifecycle state of the VMware admin cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the VMware Admin Cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
