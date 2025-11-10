using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Spread nodes across at least three physical hosts (requires at least three
    /// hosts).
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AagConfigDisabled is required")]
    public required TerraformProperty<bool> AagConfigDisabled
    {
        set => SetProperty("aag_config_disabled", value);
    }

}

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAuthorizationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterAutoRepairConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether auto repair is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for control_plane_node in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterControlPlaneNodeBlock : TerraformBlock
{
    /// <summary>
    /// The number of CPUs for each admin cluster node that serve as control planes
    /// for this VMware User Cluster. (default: 4 CPUs)
    /// </summary>
    public TerraformProperty<double>? Cpus
    {
        set => SetProperty("cpus", value);
    }

    /// <summary>
    /// The megabytes of memory for each admin cluster node that serves as a
    /// control plane for this VMware User Cluster (default: 8192 MB memory).
    /// </summary>
    public TerraformProperty<double>? Memory
    {
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The number of control plane nodes for this VMware User Cluster.
    /// (default: 1 replica).
    /// </summary>
    public TerraformProperty<double>? Replicas
    {
        set => SetProperty("replicas", value);
    }

    /// <summary>
    /// Vsphere-specific config.
    /// </summary>
    public List<TerraformProperty<object>>? VsphereConfig
    {
        set => SetProperty("vsphere_config", value);
    }

}

/// <summary>
/// Block type for dataplane_v2 in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterDataplaneV2Block : TerraformBlock
{
    /// <summary>
    /// Enable advanced networking which requires dataplane_v2_enabled to be set true.
    /// </summary>
    public TerraformProperty<bool>? AdvancedNetworking
    {
        set => SetProperty("advanced_networking", value);
    }

    /// <summary>
    /// Enables Dataplane V2.
    /// </summary>
    public TerraformProperty<bool>? DataplaneV2Enabled
    {
        set => SetProperty("dataplane_v2_enabled", value);
    }

    /// <summary>
    /// Enable Dataplane V2 for clusters with Windows nodes.
    /// </summary>
    public TerraformProperty<bool>? WindowsDataplaneV2Enabled
    {
        set => SetProperty("windows_dataplane_v2_enabled", value);
    }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterLoadBalancerBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges.
    /// Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public List<TerraformProperty<string>>? PodAddressCidrBlocks
    {
        set => SetProperty("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address
    /// from these ranges. Only a single range is supported.. This field
    /// cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public List<TerraformProperty<string>>? ServiceAddressCidrBlocks
    {
        set => SetProperty("service_address_cidr_blocks", value);
    }

    /// <summary>
    /// vcenter_network specifies vCenter network name. Inherited from the admin cluster.
    /// </summary>
    public TerraformProperty<string>? VcenterNetwork
    {
        set => SetProperty("vcenter_network", value);
    }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterStorageBlock : TerraformBlock
{
    /// <summary>
    /// Whether or not to deploy vSphere CSI components in the VMware User Cluster.
    /// Enabled by default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VsphereCsiDisabled is required")]
    public required TerraformProperty<bool> VsphereCsiDisabled
    {
        set => SetProperty("vsphere_csi_disabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Controls whether the upgrade applies to the control plane only.
    /// </summary>
    public TerraformProperty<bool>? ControlPlaneOnly
    {
        set => SetProperty("control_plane_only", value);
    }

}

/// <summary>
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareClusterVcenterBlock : TerraformBlock
{
    /// <summary>
    /// The vCenter IP address.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        set => SetProperty("address", value);
    }

    /// <summary>
    /// Contains the vCenter CA certificate public key for SSL verification.
    /// </summary>
    public TerraformProperty<string>? CaCertData
    {
        set => SetProperty("ca_cert_data", value);
    }

    /// <summary>
    /// The name of the vCenter cluster for the user cluster.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The name of the vCenter datacenter for the user cluster.
    /// </summary>
    public TerraformProperty<string>? Datacenter
    {
        set => SetProperty("datacenter", value);
    }

    /// <summary>
    /// The name of the vCenter datastore for the user cluster.
    /// </summary>
    public TerraformProperty<string>? Datastore
    {
        set => SetProperty("datastore", value);
    }

    /// <summary>
    /// The name of the vCenter folder for the user cluster.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        set => SetProperty("folder", value);
    }

    /// <summary>
    /// The name of the vCenter resource pool for the user cluster.
    /// </summary>
    public TerraformProperty<string>? ResourcePool
    {
        set => SetProperty("resource_pool", value);
    }

    /// <summary>
    /// The name of the vCenter storage policy for the user cluster.
    /// </summary>
    public TerraformProperty<string>? StoragePolicyName
    {
        set => SetProperty("storage_policy_name", value);
    }

}

/// <summary>
/// Manages a google_gkeonprem_vmware_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareCluster : TerraformResource
{
    public GoogleGkeonpremVmwareCluster(string name) : base("google_gkeonprem_vmware_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delete_time");
        SetOutput("effective_annotations");
        SetOutput("endpoint");
        SetOutput("etag");
        SetOutput("fleet");
        SetOutput("local_name");
        SetOutput("reconciling");
        SetOutput("state");
        SetOutput("status");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("validation_check");
        SetOutput("admin_cluster_membership");
        SetOutput("annotations");
        SetOutput("description");
        SetOutput("disable_bundled_ingress");
        SetOutput("enable_advanced_cluster");
        SetOutput("enable_control_plane_v2");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("on_prem_version");
        SetOutput("project");
        SetOutput("vm_tracking_enabled");
    }

    /// <summary>
    /// The admin cluster this VMware User Cluster belongs to.
    /// This is the full resource name of the admin cluster&#39;s hub membership.
    /// In the future, references to other resource types might be allowed if
    /// admin clusters are modeled as their own resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminClusterMembership is required")]
    public required TerraformProperty<string> AdminClusterMembership
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_cluster_membership");
        set => SetProperty("admin_cluster_membership", value);
    }

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
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// A human readable description of this VMware User Cluster.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Disable bundled ingress.
    /// </summary>
    public TerraformProperty<bool> DisableBundledIngress
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_bundled_ingress");
        set => SetProperty("disable_bundled_ingress", value);
    }

    /// <summary>
    /// Enable advanced cluster. Default to false.
    /// </summary>
    public TerraformProperty<bool> EnableAdvancedCluster
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_advanced_cluster");
        set => SetProperty("enable_advanced_cluster", value);
    }

    /// <summary>
    /// Enable control plane V2. Default to false.
    /// </summary>
    public TerraformProperty<bool> EnableControlPlaneV2
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_control_plane_v2");
        set => SetProperty("enable_control_plane_v2", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The VMware cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Anthos clusters on the VMware version for your user cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnPremVersion is required")]
    public required TerraformProperty<string> OnPremVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("on_prem_version");
        set => SetProperty("on_prem_version", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Enable VM tracking.
    /// </summary>
    public TerraformProperty<bool> VmTrackingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vm_tracking_enabled");
        set => SetProperty("vm_tracking_enabled", value);
    }

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterAntiAffinityGroupsBlock>? AntiAffinityGroups
    {
        set => SetProperty("anti_affinity_groups", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterAuthorizationBlock>? Authorization
    {
        set => SetProperty("authorization", value);
    }

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterAutoRepairConfigBlock>? AutoRepairConfig
    {
        set => SetProperty("auto_repair_config", value);
    }

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlaneNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterControlPlaneNodeBlock>? ControlPlaneNode
    {
        set => SetProperty("control_plane_node", value);
    }

    /// <summary>
    /// Block for dataplane_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataplaneV2 block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterDataplaneV2Block>? DataplaneV2
    {
        set => SetProperty("dataplane_v2", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterLoadBalancerBlock>? LoadBalancer
    {
        set => SetProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterNetworkConfigBlock>? NetworkConfig
    {
        set => SetProperty("network_config", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterStorageBlock>? Storage
    {
        set => SetProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeonpremVmwareClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterUpgradePolicyBlock>? UpgradePolicy
    {
        set => SetProperty("upgrade_policy", value);
    }

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    public List<GoogleGkeonpremVmwareClusterVcenterBlock>? Vcenter
    {
        set => SetProperty("vcenter", value);
    }

    /// <summary>
    /// The time at which VMware User Cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time at which VMware User Cluster was deleted.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// The DNS name of VMware User Cluster&#39;s API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Fleet configuration for the cluster.
    /// </summary>
    public TerraformExpression Fleet => this["fleet"];

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
    public TerraformExpression LocalName => this["local_name"];

    /// <summary>
    /// If set, there are currently changes in flight to the VMware User Cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The unique identifier of the VMware User Cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time at which VMware User Cluster was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// ValidationCheck represents the result of the preflight check job.
    /// </summary>
    public TerraformExpression ValidationCheck => this["validation_check"];

}
