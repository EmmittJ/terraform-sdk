using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock : ITerraformBlock
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
public class GoogleGkeonpremVmwareClusterAuthorizationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAutoRepairConfigBlock : ITerraformBlock
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
public class GoogleGkeonpremVmwareClusterControlPlaneNodeBlock : ITerraformBlock
{
    /// <summary>
    /// The number of CPUs for each admin cluster node that serve as control planes
    /// for this VMware User Cluster. (default: 4 CPUs)
    /// </summary>
    [TerraformPropertyName("cpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cpus { get; set; }

    /// <summary>
    /// The megabytes of memory for each admin cluster node that serves as a
    /// control plane for this VMware User Cluster (default: 8192 MB memory).
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Memory { get; set; }

    /// <summary>
    /// The number of control plane nodes for this VMware User Cluster.
    /// (default: 1 replica).
    /// </summary>
    [TerraformPropertyName("replicas")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Replicas { get; set; }

    /// <summary>
    /// Vsphere-specific config.
    /// </summary>
    [TerraformPropertyName("vsphere_config")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VsphereConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "vsphere_config");

}

/// <summary>
/// Block type for dataplane_v2 in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterDataplaneV2Block : ITerraformBlock
{
    /// <summary>
    /// Enable advanced networking which requires dataplane_v2_enabled to be set true.
    /// </summary>
    [TerraformPropertyName("advanced_networking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdvancedNetworking { get; set; }

    /// <summary>
    /// Enables Dataplane V2.
    /// </summary>
    [TerraformPropertyName("dataplane_v2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataplaneV2Enabled { get; set; }

    /// <summary>
    /// Enable Dataplane V2 for clusters with Windows nodes.
    /// </summary>
    [TerraformPropertyName("windows_dataplane_v2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WindowsDataplaneV2Enabled { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlock : ITerraformBlock
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
    /// vcenter_network specifies vCenter network name. Inherited from the admin cluster.
    /// </summary>
    [TerraformPropertyName("vcenter_network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VcenterNetwork { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vcenter_network");

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterStorageBlock : ITerraformBlock
{
    /// <summary>
    /// Whether or not to deploy vSphere CSI components in the VMware User Cluster.
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VsphereCsiDisabled is required")]
    [TerraformPropertyName("vsphere_csi_disabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> VsphereCsiDisabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Controls whether the upgrade applies to the control plane only.
    /// </summary>
    [TerraformPropertyName("control_plane_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ControlPlaneOnly { get; set; }

}

/// <summary>
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterVcenterBlock : ITerraformBlock
{
    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    [TerraformPropertyName("address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>("", "address");

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    [TerraformPropertyName("ca_cert_data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CaCertData { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ca_cert_data");

    /// <summary>
    /// The name of the vCenter cluster for the user cluster.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Cluster { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster");

    /// <summary>
    /// The name of the vCenter datacenter for the user cluster.
    /// </summary>
    [TerraformPropertyName("datacenter")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Datacenter { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "datacenter");

    /// <summary>
    /// The name of the vCenter datastore for the user cluster.
    /// </summary>
    [TerraformPropertyName("datastore")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Datastore { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "datastore");

    /// <summary>
    /// The name of the vCenter folder for the user cluster.
    /// </summary>
    [TerraformPropertyName("folder")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Folder { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "folder");

    /// <summary>
    /// The name of the vCenter resource pool for the user cluster.
    /// </summary>
    [TerraformPropertyName("resource_pool")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourcePool { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "resource_pool");

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    [TerraformPropertyName("storage_policy_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StoragePolicyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_policy_name");

}

/// <summary>
/// Manages a google_gkeonprem_vmware_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareCluster : TerraformResource
{
    public GoogleGkeonpremVmwareCluster(string name) : base("google_gkeonprem_vmware_cluster", name)
    {
    }

    /// <summary>
    /// The admin cluster this VMware User Cluster belongs to.
    /// This is the full resource name of the admin cluster&#39;s hub membership.
    /// In the future, references to other resource types might be allowed if
    /// admin clusters are modeled as their own resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    [TerraformPropertyName("admin_cluster_membership")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminClusterMembership { get; set; }

    /// <summary>
    /// Annotations on the VMware User Cluster.
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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// A human readable description of this VMware User Cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Disable bundled ingress.
    /// </summary>
    [TerraformPropertyName("disable_bundled_ingress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableBundledIngress { get; set; }

    /// <summary>
    /// Enable advanced cluster. Default to false.
    /// </summary>
    [TerraformPropertyName("enable_advanced_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAdvancedCluster { get; set; }

    /// <summary>
    /// Enable control plane V2. Default to false.
    /// </summary>
    [TerraformPropertyName("enable_control_plane_v2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableControlPlaneV2 { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The VMware cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The Anthos clusters on the VMware version for your user cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnPremVersion is required")]
    [TerraformPropertyName("on_prem_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Enable VM tracking.
    /// </summary>
    [TerraformPropertyName("vm_tracking_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> VmTrackingEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "vm_tracking_enabled");

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    [TerraformPropertyName("anti_affinity_groups")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock>>? AntiAffinityGroups { get; set; } = new();

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformPropertyName("authorization")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterAuthorizationBlock>>? Authorization { get; set; } = new();

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    [TerraformPropertyName("auto_repair_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterAutoRepairConfigBlock>>? AutoRepairConfig { get; set; } = new();

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    [TerraformPropertyName("control_plane_node")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterControlPlaneNodeBlock>>? ControlPlaneNode { get; set; } = new();

    /// <summary>
    /// Block for dataplane_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataplaneV2 block(s) allowed")]
    [TerraformPropertyName("dataplane_v2")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterDataplaneV2Block>>? DataplaneV2 { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformPropertyName("load_balancer")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterLoadBalancerBlock>>? LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformPropertyName("storage")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterStorageBlock>>? Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeonpremVmwareClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformPropertyName("upgrade_policy")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    [TerraformPropertyName("vcenter")]
    public TerraformList<TerraformBlock<GoogleGkeonpremVmwareClusterVcenterBlock>>? Vcenter { get; set; } = new();

    /// <summary>
    /// The time at which VMware User Cluster was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time at which VMware User Cluster was deleted.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// The DNS name of VMware User Cluster&#39;s API server.
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
    /// The object name of the VMware OnPremUserCluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// 
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    [TerraformPropertyName("local_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_name");

    /// <summary>
    /// If set, there are currently changes in flight to the VMware User Cluster.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The current state of this cluster.
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
    /// The unique identifier of the VMware User Cluster.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The time at which VMware User Cluster was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// ValidationCheck represents the result of the preflight check job.
    /// </summary>
    [TerraformPropertyName("validation_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ValidationCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validation_check");

}
