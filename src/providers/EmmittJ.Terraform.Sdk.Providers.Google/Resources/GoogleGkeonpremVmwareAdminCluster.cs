using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addon_node in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAddonNodeBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock : ITerraformBlock
{
    /// <summary>
    /// Spread nodes across at least three physical hosts (requires at least three
    /// hosts).
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AagConfigDisabled is required")]
    [TerraformPropertyName("aag_config_disabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AagConfigDisabled { get; set; }

}

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAuthorizationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether auto repair is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_node in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock : ITerraformBlock
{
    /// <summary>
    /// The number of vCPUs for the control-plane node of the admin cluster.
    /// </summary>
    [TerraformPropertyName("cpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cpus { get; set; }

    /// <summary>
    /// The number of mebibytes of memory for the control-plane node of the admin cluster.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Memory { get; set; }

    /// <summary>
    /// The number of control plane nodes for this VMware admin cluster.
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Replicas { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges.
    /// Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    [TerraformPropertyName("pod_address_cidr_blocks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PodAddressCidrBlocks { get; set; }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address
    /// from these ranges. Only a single range is supported.. This field
    /// cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    [TerraformPropertyName("service_address_cidr_blocks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>
    /// vcenter_network specifies vCenter network name.
    /// </summary>
    [TerraformPropertyName("vcenter_network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VcenterNetwork { get; set; }

}

/// <summary>
/// Block type for platform_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The list of bundles installed in the admin cluster.
    /// </summary>
    [TerraformPropertyName("bundles")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Bundles => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "bundles");

    /// <summary>
    /// The platform version e.g. 1.13.2.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "platform_version");

    /// <summary>
    /// The required platform version e.g. 1.13.1.
    /// If the current platform version is lower than the target version,
    /// the platform version will be updated to the target version.
    /// If the target version is not installed in the platform
    /// (bundle versions), download the target version bundle.
    /// </summary>
    [TerraformPropertyName("required_platform_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequiredPlatformVersion { get; set; }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "status");

}

/// <summary>
/// Block type for private_registry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The registry address.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address { get; set; }

    /// <summary>
    /// The CA certificate public key for private registry.
    /// </summary>
    [TerraformPropertyName("ca_cert")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CaCert { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterProxyBlock : ITerraformBlock
{
    /// <summary>
    /// A comma-separated list of IP addresses, IP address ranges,
    /// host names, and domain names that should not go through the proxy server.
    /// </summary>
    [TerraformPropertyName("no_proxy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NoProxy { get; set; }

    /// <summary>
    /// The proxy url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterVcenterBlock : ITerraformBlock
{
    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address { get; set; }

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    [TerraformPropertyName("ca_cert_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CaCertData { get; set; }

    /// <summary>
    /// The name of the vCenter cluster for the admin cluster.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cluster { get; set; }

    /// <summary>
    /// The name of the virtual machine disk (VMDK) for the admin cluster.
    /// </summary>
    [TerraformPropertyName("data_disk")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataDisk { get; set; }

    /// <summary>
    /// The name of the vCenter datacenter for the admin cluster.
    /// </summary>
    [TerraformPropertyName("datacenter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Datacenter { get; set; }

    /// <summary>
    /// The name of the vCenter datastore for the admin cluster.
    /// </summary>
    [TerraformPropertyName("datastore")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Datastore { get; set; }

    /// <summary>
    /// The name of the vCenter folder for the admin cluster.
    /// </summary>
    [TerraformPropertyName("folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Folder { get; set; }

    /// <summary>
    /// The name of the vCenter resource pool for the admin cluster.
    /// </summary>
    [TerraformPropertyName("resource_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourcePool { get; set; }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    [TerraformPropertyName("storage_policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StoragePolicyName { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_vmware_admin_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareAdminCluster : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Annotations { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "annotations");

    /// <summary>
    /// The bootstrap cluster this VMware admin cluster belongs to.
    /// </summary>
    [TerraformPropertyName("bootstrap_cluster_membership")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BootstrapClusterMembership { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_cluster_membership");

    /// <summary>
    /// A human readable description of this VMware admin cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// If set, the advanced cluster feature is enabled.
    /// </summary>
    [TerraformPropertyName("enable_advanced_cluster")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableAdvancedCluster { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_advanced_cluster");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The OS image type for the VMware admin cluster.
    /// </summary>
    [TerraformPropertyName("image_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_type");

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The VMware admin cluster resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The Anthos clusters on the VMware version for the admin cluster.
    /// </summary>
    [TerraformPropertyName("on_prem_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for addon_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonNode block(s) allowed")]
    [TerraformPropertyName("addon_node")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAddonNodeBlock>>? AddonNode { get; set; } = new();

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    [TerraformPropertyName("anti_affinity_groups")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock>>? AntiAffinityGroups { get; set; } = new();

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformPropertyName("authorization")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAuthorizationBlock>>? Authorization { get; set; } = new();

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    [TerraformPropertyName("auto_repair_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock>>? AutoRepairConfig { get; set; } = new();

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    [TerraformPropertyName("control_plane_node")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock>>? ControlPlaneNode { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformPropertyName("load_balancer")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock>>? LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for platform_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlatformConfig block(s) allowed")]
    [TerraformPropertyName("platform_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock>>? PlatformConfig { get; set; } = new();

    /// <summary>
    /// Block for private_registry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryConfig block(s) allowed")]
    [TerraformPropertyName("private_registry_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock>>? PrivateRegistryConfig { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformPropertyName("proxy")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterProxyBlock>>? Proxy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeonpremVmwareAdminClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    [TerraformPropertyName("vcenter")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareAdminClusterVcenterBlock>>? Vcenter { get; set; } = new();

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// The DNS name of VMware admin cluster&#39;s API server.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Fleet configuration for the cluster.
    /// </summary>
    [TerraformPropertyName("fleet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Fleet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "fleet");

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
    [TerraformPropertyName("local_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_name");

    /// <summary>
    /// If set, there are currently changes in flight to the VMware admin cluster.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The lifecycle state of the VMware admin cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

    /// <summary>
    /// The unique identifier of the VMware Admin Cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
