using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterAuthorizationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneBlock : TerraformBlock
{
}

/// <summary>
/// Block type for control_plane_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud KMS CryptoKey e.g.
    /// projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// to use for protecting control plane disks. If not specified, a
    /// Google-managed key will be used instead.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting control
    /// plane disks. Only applicable if kms_key is set.
    /// </summary>
    public TerraformProperty<string>? KmsKeyActiveVersion
    {
        set => SetProperty("kms_key_active_version", value);
    }

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not &#39;KEY_AVAILABLE&#39;, then
    /// nodes may go offline as they cannot access their local data. This can be
    /// caused by a lack of permissions to use the key, or if the key is disabled
    /// or deleted.
    /// </summary>
    public TerraformProperty<string>? KmsKeyState
    {
        set => SetProperty("kms_key_state", value);
    }

    /// <summary>
    /// Error status returned by Cloud KMS when using this key. This field may be
    /// populated only if &#39;kms_key_state&#39; is not &#39;KMS_KEY_STATE_KEY_AVAILABLE&#39;.
    /// If populated, this field contains the error status reported by Cloud KMS.
    /// </summary>
    public List<TerraformProperty<object>>? KmsStatus
    {
        set => SetProperty("kms_status", value);
    }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster.
    /// Membership names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;&#39;.
    /// </summary>
    public TerraformProperty<string>? Membership
    {
        set => SetProperty("membership", value);
    }

    /// <summary>
    /// The name of the Fleet host project where this cluster will be registered.
    /// Project names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformProperty<string> Project
    {
        set => SetProperty("project", value);
    }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for networking in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIpv4CidrBlocks is required")]
    public List<TerraformProperty<string>>? ClusterIpv4CidrBlocks
    {
        set => SetProperty("cluster_ipv4_cidr_blocks", value);
    }

    /// <summary>
    /// If specified, dual stack mode is enabled and all pods in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    public List<TerraformProperty<string>>? ClusterIpv6CidrBlocks
    {
        set => SetProperty("cluster_ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// IP addressing type of this cluster i.e. SINGLESTACK_V4 vs DUALSTACK_V4_V6.
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicesIpv4CidrBlocks is required")]
    public List<TerraformProperty<string>>? ServicesIpv4CidrBlocks
    {
        set => SetProperty("services_ipv4_cidr_blocks", value);
    }

    /// <summary>
    /// If specified, dual stack mode is enabled and all services in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    public List<TerraformProperty<string>>? ServicesIpv6CidrBlocks
    {
        set => SetProperty("services_ipv6_cidr_blocks", value);
    }

}

/// <summary>
/// Block type for system_addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterSystemAddonsConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerClusterTimeoutsBlock : TerraformBlock
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
/// Manages a google_edgecontainer_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEdgecontainerCluster : TerraformResource
{
    public GoogleEdgecontainerCluster(string name) : base("google_edgecontainer_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_ca_certificate");
        SetOutput("control_plane_version");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("endpoint");
        SetOutput("maintenance_events");
        SetOutput("node_version");
        SetOutput("port");
        SetOutput("status");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("default_max_pods_per_node");
        SetOutput("external_load_balancer_ipv4_address_pools");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("release_channel");
        SetOutput("target_version");
    }

    /// <summary>
    /// The default maximum number of pods per node used if a maximum value is not
    /// specified explicitly for a node pool in this cluster. If unspecified, the
    /// Kubernetes default value will be used.
    /// </summary>
    public TerraformProperty<double> DefaultMaxPodsPerNode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_max_pods_per_node");
        set => SetProperty("default_max_pods_per_node", value);
    }

    /// <summary>
    /// Address pools for cluster data plane external load balancing.
    /// </summary>
    public List<TerraformProperty<string>> ExternalLoadBalancerIpv4AddressPools
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("external_load_balancer_ipv4_address_pools");
        set => SetProperty("external_load_balancer_ipv4_address_pools", value);
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
    /// User-defined labels for the edgecloud cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
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
    /// The GDCE cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The release channel a cluster is subscribed to. Possible values: [&amp;quot;RELEASE_CHANNEL_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;REGULAR&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ReleaseChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_channel");
        set => SetProperty("release_channel", value);
    }

    /// <summary>
    /// The target cluster version. For example: &amp;quot;1.5.0&amp;quot;.
    /// </summary>
    public TerraformProperty<string> TargetVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_version");
        set => SetProperty("target_version", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public List<GoogleEdgecontainerClusterAuthorizationBlock>? Authorization
    {
        set => SetProperty("authorization", value);
    }

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public List<GoogleEdgecontainerClusterControlPlaneBlock>? ControlPlane
    {
        set => SetProperty("control_plane", value);
    }

    /// <summary>
    /// Block for control_plane_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEncryption block(s) allowed")]
    public List<GoogleEdgecontainerClusterControlPlaneEncryptionBlock>? ControlPlaneEncryption
    {
        set => SetProperty("control_plane_encryption", value);
    }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public List<GoogleEdgecontainerClusterFleetBlock>? Fleet
    {
        set => SetProperty("fleet", value);
    }

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public List<GoogleEdgecontainerClusterMaintenancePolicyBlock>? MaintenancePolicy
    {
        set => SetProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Block for networking.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    public List<GoogleEdgecontainerClusterNetworkingBlock>? Networking
    {
        set => SetProperty("networking", value);
    }

    /// <summary>
    /// Block for system_addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemAddonsConfig block(s) allowed")]
    public List<GoogleEdgecontainerClusterSystemAddonsConfigBlock>? SystemAddonsConfig
    {
        set => SetProperty("system_addons_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEdgecontainerClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The PEM-encoded public certificate of the cluster&#39;s CA.
    /// </summary>
    public TerraformExpression ClusterCaCertificate => this["cluster_ca_certificate"];

    /// <summary>
    /// The control plane release version.
    /// </summary>
    public TerraformExpression ControlPlaneVersion => this["control_plane_version"];

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The IP address of the Kubernetes API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// All the maintenance events scheduled for the cluster, including the ones
    /// ongoing, planned for the future and done in the past (up to 90 days).
    /// </summary>
    public TerraformExpression MaintenanceEvents => this["maintenance_events"];

    /// <summary>
    /// The lowest release version among all worker nodes. This field can be empty
    /// if the cluster does not have any worker nodes.
    /// </summary>
    public TerraformExpression NodeVersion => this["node_version"];

    /// <summary>
    /// The port number of the Kubernetes API server.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// Indicates the status of the cluster.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
