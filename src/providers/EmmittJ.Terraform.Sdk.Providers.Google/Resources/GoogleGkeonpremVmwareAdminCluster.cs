using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addon_node in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAddonNodeBlock : TerraformBlock
{
}

/// <summary>
/// Block type for anti_affinity_groups in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock : TerraformBlock
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
public class GoogleGkeonpremVmwareAdminClusterAuthorizationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for auto_repair_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock : TerraformBlock
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
public class GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock : TerraformBlock
{
    /// <summary>
    /// The number of vCPUs for the control-plane node of the admin cluster.
    /// </summary>
    public TerraformProperty<double>? Cpus
    {
        set => SetProperty("cpus", value);
    }

    /// <summary>
    /// The number of mebibytes of memory for the control-plane node of the admin cluster.
    /// </summary>
    public TerraformProperty<double>? Memory
    {
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The number of control plane nodes for this VMware admin cluster.
    /// </summary>
    public TerraformProperty<double>? Replicas
    {
        set => SetProperty("replicas", value);
    }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock : TerraformBlock
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
    /// vcenter_network specifies vCenter network name.
    /// </summary>
    public TerraformProperty<string>? VcenterNetwork
    {
        set => SetProperty("vcenter_network", value);
    }

}

/// <summary>
/// Block type for platform_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock : TerraformBlock
{
    /// <summary>
    /// The list of bundles installed in the admin cluster.
    /// </summary>
    public List<TerraformProperty<object>>? Bundles
    {
        set => SetProperty("bundles", value);
    }

    /// <summary>
    /// The platform version e.g. 1.13.2.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        set => SetProperty("platform_version", value);
    }

    /// <summary>
    /// The required platform version e.g. 1.13.1.
    /// If the current platform version is lower than the target version,
    /// the platform version will be updated to the target version.
    /// If the target version is not installed in the platform
    /// (bundle versions), download the target version bundle.
    /// </summary>
    public TerraformProperty<string>? RequiredPlatformVersion
    {
        set => SetProperty("required_platform_version", value);
    }

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public List<TerraformProperty<object>>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Block type for private_registry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock : TerraformBlock
{
    /// <summary>
    /// The registry address.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        set => SetProperty("address", value);
    }

    /// <summary>
    /// The CA certificate public key for private registry.
    /// </summary>
    public TerraformProperty<string>? CaCert
    {
        set => SetProperty("ca_cert", value);
    }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterProxyBlock : TerraformBlock
{
    /// <summary>
    /// A comma-separated list of IP addresses, IP address ranges,
    /// host names, and domain names that should not go through the proxy server.
    /// </summary>
    public TerraformProperty<string>? NoProxy
    {
        set => SetProperty("no_proxy", value);
    }

    /// <summary>
    /// The proxy url.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterTimeoutsBlock : TerraformBlock
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
/// Block type for vcenter in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeonpremVmwareAdminClusterVcenterBlock : TerraformBlock
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
    /// The name of the vCenter cluster for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The name of the virtual machine disk (VMDK) for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? DataDisk
    {
        set => SetProperty("data_disk", value);
    }

    /// <summary>
    /// The name of the vCenter datacenter for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? Datacenter
    {
        set => SetProperty("datacenter", value);
    }

    /// <summary>
    /// The name of the vCenter datastore for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? Datastore
    {
        set => SetProperty("datastore", value);
    }

    /// <summary>
    /// The name of the vCenter folder for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        set => SetProperty("folder", value);
    }

    /// <summary>
    /// The name of the vCenter resource pool for the admin cluster.
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
/// Manages a google_gkeonprem_vmware_admin_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeonpremVmwareAdminCluster : TerraformResource
{
    public GoogleGkeonpremVmwareAdminCluster(string name) : base("google_gkeonprem_vmware_admin_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
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
        SetOutput("annotations");
        SetOutput("bootstrap_cluster_membership");
        SetOutput("description");
        SetOutput("enable_advanced_cluster");
        SetOutput("id");
        SetOutput("image_type");
        SetOutput("location");
        SetOutput("name");
        SetOutput("on_prem_version");
        SetOutput("project");
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
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The bootstrap cluster this VMware admin cluster belongs to.
    /// </summary>
    public TerraformProperty<string> BootstrapClusterMembership
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bootstrap_cluster_membership");
        set => SetProperty("bootstrap_cluster_membership", value);
    }

    /// <summary>
    /// A human readable description of this VMware admin cluster.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If set, the advanced cluster feature is enabled.
    /// </summary>
    public TerraformProperty<bool> EnableAdvancedCluster
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_advanced_cluster");
        set => SetProperty("enable_advanced_cluster", value);
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
    /// The OS image type for the VMware admin cluster.
    /// </summary>
    public TerraformProperty<string> ImageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_type");
        set => SetProperty("image_type", value);
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
    /// The VMware admin cluster resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Anthos clusters on the VMware version for the admin cluster.
    /// </summary>
    public TerraformProperty<string> OnPremVersion
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
    /// Block for addon_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonNode block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterAddonNodeBlock>? AddonNode
    {
        set => SetProperty("addon_node", value);
    }

    /// <summary>
    /// Block for anti_affinity_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AntiAffinityGroups block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterAntiAffinityGroupsBlock>? AntiAffinityGroups
    {
        set => SetProperty("anti_affinity_groups", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterAuthorizationBlock>? Authorization
    {
        set => SetProperty("authorization", value);
    }

    /// <summary>
    /// Block for auto_repair_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRepairConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterAutoRepairConfigBlock>? AutoRepairConfig
    {
        set => SetProperty("auto_repair_config", value);
    }

    /// <summary>
    /// Block for control_plane_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneNode block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterControlPlaneNodeBlock>? ControlPlaneNode
    {
        set => SetProperty("control_plane_node", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterLoadBalancerBlock>? LoadBalancer
    {
        set => SetProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterNetworkConfigBlock>? NetworkConfig
    {
        set => SetProperty("network_config", value);
    }

    /// <summary>
    /// Block for platform_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PlatformConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterPlatformConfigBlock>? PlatformConfig
    {
        set => SetProperty("platform_config", value);
    }

    /// <summary>
    /// Block for private_registry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateRegistryConfig block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterPrivateRegistryConfigBlock>? PrivateRegistryConfig
    {
        set => SetProperty("private_registry_config", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterProxyBlock>? Proxy
    {
        set => SetProperty("proxy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeonpremVmwareAdminClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vcenter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vcenter block(s) allowed")]
    public List<GoogleGkeonpremVmwareAdminClusterVcenterBlock>? Vcenter
    {
        set => SetProperty("vcenter", value);
    }

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// The DNS name of VMware admin cluster&#39;s API server.
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
    public TerraformExpression LocalName => this["local_name"];

    /// <summary>
    /// If set, there are currently changes in flight to the VMware admin cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The lifecycle state of the VMware admin cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The unique identifier of the VMware Admin Cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
