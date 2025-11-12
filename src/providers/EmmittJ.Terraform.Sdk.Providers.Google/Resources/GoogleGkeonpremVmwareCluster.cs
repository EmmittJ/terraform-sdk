using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock() : TerraformBlock("anti_affinity_groups")
{
    /// <summary>
    /// Spread nodes across at least three physical hosts (requires at least three
    /// hosts).
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AagConfigDisabled is required")]
    [TerraformProperty("aag_config_disabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AagConfigDisabled { get; set; }

}

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterAuthorizationBlock() : TerraformBlock("authorization")
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterAutoRepairConfigBlock() : TerraformBlock("auto_repair_config")
{
    /// <summary>
    /// Whether auto repair is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for control_plane_node in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterControlPlaneNodeBlock() : TerraformBlock("control_plane_node")
{
    /// <summary>
    /// The number of CPUs for each admin cluster node that serve as control planes
    /// for this VMware User Cluster. (default: 4 CPUs)
    /// </summary>
    [TerraformProperty("cpus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Cpus { get; set; }

    /// <summary>
    /// The megabytes of memory for each admin cluster node that serves as a
    /// control plane for this VMware User Cluster (default: 8192 MB memory).
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Memory { get; set; }

    /// <summary>
    /// The number of control plane nodes for this VMware User Cluster.
    /// (default: 1 replica).
    /// </summary>
    [TerraformProperty("replicas")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Replicas { get; set; }


}

/// <summary>
/// Block type for dataplane_v2 in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterDataplaneV2Block() : TerraformBlock("dataplane_v2")
{
    /// <summary>
    /// Enable advanced networking which requires dataplane_v2_enabled to be set true.
    /// </summary>
    [TerraformProperty("advanced_networking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdvancedNetworking { get; set; }

    /// <summary>
    /// Enables Dataplane V2.
    /// </summary>
    [TerraformProperty("dataplane_v2_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataplaneV2Enabled { get; set; }

    /// <summary>
    /// Enable Dataplane V2 for clusters with Windows nodes.
    /// </summary>
    [TerraformProperty("windows_dataplane_v2_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WindowsDataplaneV2Enabled { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterLoadBalancerBlock() : TerraformBlock("load_balancer")
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterNetworkConfigBlock() : TerraformBlock("network_config")
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges.
    /// Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    [TerraformProperty("pod_address_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PodAddressCidrBlocks { get; set; }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address
    /// from these ranges. Only a single range is supported.. This field
    /// cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    [TerraformProperty("service_address_cidr_blocks")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ServiceAddressCidrBlocks { get; set; }

    /// <summary>
    /// vcenter_network specifies vCenter network name. Inherited from the admin cluster.
    /// </summary>
    [TerraformProperty("vcenter_network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VcenterNetwork { get; set; }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterStorageBlock() : TerraformBlock("storage")
{
    /// <summary>
    /// Whether or not to deploy vSphere CSI components in the VMware User Cluster.
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VsphereCsiDisabled is required")]
    [TerraformProperty("vsphere_csi_disabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> VsphereCsiDisabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremVmwareClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterUpgradePolicyBlock() : TerraformBlock("upgrade_policy")
{
    /// <summary>
    /// Controls whether the upgrade applies to the control plane only.
    /// </summary>
    [TerraformProperty("control_plane_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ControlPlaneOnly { get; set; }

}

/// <summary>
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremVmwareClusterVcenterBlock() : TerraformBlock("vcenter")
{

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    [TerraformProperty("ca_cert_data")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CaCertData { get; set; }

    /// <summary>
    /// The name of the vCenter cluster for the user cluster.
    /// </summary>
    [TerraformProperty("cluster")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The name of the vCenter datacenter for the user cluster.
    /// </summary>
    [TerraformProperty("datacenter")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Datacenter { get; set; }

    /// <summary>
    /// The name of the vCenter datastore for the user cluster.
    /// </summary>
    [TerraformProperty("datastore")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Datastore { get; set; }

    /// <summary>
    /// The name of the vCenter folder for the user cluster.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The name of the vCenter resource pool for the user cluster.
    /// </summary>
    [TerraformProperty("resource_pool")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourcePool { get; set; }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    [TerraformProperty("storage_policy_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StoragePolicyName { get; set; }

}

/// <summary>
/// Manages a google_gkeonprem_vmware_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremVmwareCluster : TerraformResource
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
    [TerraformProperty("admin_cluster_membership")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminClusterMembership { get; set; }

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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// A human readable description of this VMware User Cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Disable bundled ingress.
    /// </summary>
    [TerraformProperty("disable_bundled_ingress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableBundledIngress { get; set; }

    /// <summary>
    /// Enable advanced cluster. Default to false.
    /// </summary>
    [TerraformProperty("enable_advanced_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAdvancedCluster { get; set; }

    /// <summary>
    /// Enable control plane V2. Default to false.
    /// </summary>
    [TerraformProperty("enable_control_plane_v2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableControlPlaneV2 { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The VMware cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Anthos clusters on the VMware version for your user cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnPremVersion is required")]
    [TerraformProperty("on_prem_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OnPremVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Enable VM tracking.
    /// </summary>
    [TerraformProperty("vm_tracking_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> VmTrackingEnabled { get; set; }

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    [TerraformProperty("anti_affinity_groups")]
    public TerraformList<GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock> AntiAffinityGroups { get; set; } = new();

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformProperty("authorization")]
    public TerraformList<GoogleGkeonpremVmwareClusterAuthorizationBlock> Authorization { get; set; } = new();

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    [TerraformProperty("auto_repair_config")]
    public TerraformList<GoogleGkeonpremVmwareClusterAutoRepairConfigBlock> AutoRepairConfig { get; set; } = new();

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    [TerraformProperty("control_plane_node")]
    public required TerraformList<GoogleGkeonpremVmwareClusterControlPlaneNodeBlock> ControlPlaneNode { get; set; } = new();

    /// <summary>
    /// Block for dataplane_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataplaneV2 block(s) allowed")]
    [TerraformProperty("dataplane_v2")]
    public TerraformList<GoogleGkeonpremVmwareClusterDataplaneV2Block> DataplaneV2 { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    [TerraformProperty("load_balancer")]
    public TerraformList<GoogleGkeonpremVmwareClusterLoadBalancerBlock> LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<GoogleGkeonpremVmwareClusterNetworkConfigBlock> NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformProperty("storage")]
    public TerraformList<GoogleGkeonpremVmwareClusterStorageBlock> Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleGkeonpremVmwareClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformProperty("upgrade_policy")]
    public TerraformList<GoogleGkeonpremVmwareClusterUpgradePolicyBlock> UpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    [TerraformProperty("vcenter")]
    public TerraformList<GoogleGkeonpremVmwareClusterVcenterBlock> Vcenter { get; set; } = new();

    /// <summary>
    /// The time at which VMware User Cluster was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time at which VMware User Cluster was deleted.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// The DNS name of VMware User Cluster&#39;s API server.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Fleet configuration for the cluster.
    /// </summary>
    [TerraformProperty("fleet")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Fleet { get; }

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
    [TerraformProperty("local_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LocalName { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the VMware User Cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the VMware User Cluster.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time at which VMware User Cluster was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// ValidationCheck represents the result of the preflight check job.
    /// </summary>
    [TerraformProperty("validation_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ValidationCheck { get; }

}
