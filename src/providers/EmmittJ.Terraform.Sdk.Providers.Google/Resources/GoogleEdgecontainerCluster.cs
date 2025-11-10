using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterAuthorizationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for control_plane_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterControlPlaneEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The Cloud KMS CryptoKey e.g.
    /// projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// to use for protecting control plane disks. If not specified, a
    /// Google-managed key will be used instead.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key");

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting control
    /// plane disks. Only applicable if kms_key is set.
    /// </summary>
    [TerraformPropertyName("kms_key_active_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyActiveVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_active_version");

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not &#39;KEY_AVAILABLE&#39;, then
    /// nodes may go offline as they cannot access their local data. This can be
    /// caused by a lack of permissions to use the key, or if the key is disabled
    /// or deleted.
    /// </summary>
    [TerraformPropertyName("kms_key_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyState => new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_state");

    /// <summary>
    /// Error status returned by Cloud KMS when using this key. This field may be
    /// populated only if &#39;kms_key_state&#39; is not &#39;KMS_KEY_STATE_KEY_AVAILABLE&#39;.
    /// If populated, this field contains the error status reported by Cloud KMS.
    /// </summary>
    [TerraformPropertyName("kms_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KmsStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "kms_status");

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterFleetBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster.
    /// Membership names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;&#39;.
    /// </summary>
    [TerraformPropertyName("membership")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Membership => new TerraformReferenceProperty<TerraformProperty<string>>("", "membership");

    /// <summary>
    /// The name of the Fleet host project where this cluster will be registered.
    /// Project names are formatted as
    /// &#39;projects/&amp;lt;project-number&amp;gt;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

}

/// <summary>
/// Block type for maintenance_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterMaintenancePolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for networking in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterNetworkingBlock : ITerraformBlock
{
    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIpv4CidrBlocks is required")]
    [TerraformPropertyName("cluster_ipv4_cidr_blocks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ClusterIpv4CidrBlocks { get; set; }

    /// <summary>
    /// If specified, dual stack mode is enabled and all pods in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [TerraformPropertyName("cluster_ipv6_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ClusterIpv6CidrBlocks { get; set; }

    /// <summary>
    /// IP addressing type of this cluster i.e. SINGLESTACK_V4 vs DUALSTACK_V4_V6.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkType => new TerraformReferenceProperty<TerraformProperty<string>>("", "network_type");

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these
    /// blocks. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicesIpv4CidrBlocks is required")]
    [TerraformPropertyName("services_ipv4_cidr_blocks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ServicesIpv4CidrBlocks { get; set; }

    /// <summary>
    /// If specified, dual stack mode is enabled and all services in the cluster are
    /// assigned an IPv6 address from these blocks alongside from an IPv4
    /// address. Only a single block is supported. This field cannot be changed
    /// after creation.
    /// </summary>
    [TerraformPropertyName("services_ipv6_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ServicesIpv6CidrBlocks { get; set; }

}

/// <summary>
/// Block type for system_addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerClusterSystemAddonsConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a google_edgecontainer_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEdgecontainerCluster : TerraformResource
{
    public GoogleEdgecontainerCluster(string name) : base("google_edgecontainer_cluster", name)
    {
    }

    /// <summary>
    /// The default maximum number of pods per node used if a maximum value is not
    /// specified explicitly for a node pool in this cluster. If unspecified, the
    /// Kubernetes default value will be used.
    /// </summary>
    [TerraformPropertyName("default_max_pods_per_node")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DefaultMaxPodsPerNode { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_max_pods_per_node");

    /// <summary>
    /// Address pools for cluster data plane external load balancing.
    /// </summary>
    [TerraformPropertyName("external_load_balancer_ipv4_address_pools")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ExternalLoadBalancerIpv4AddressPools { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "external_load_balancer_ipv4_address_pools");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User-defined labels for the edgecloud cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The GDCE cluster name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The release channel a cluster is subscribed to. Possible values: [&amp;quot;RELEASE_CHANNEL_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;REGULAR&amp;quot;]
    /// </summary>
    [TerraformPropertyName("release_channel")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReleaseChannel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_channel");

    /// <summary>
    /// The target cluster version. For example: &amp;quot;1.5.0&amp;quot;.
    /// </summary>
    [TerraformPropertyName("target_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TargetVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_version");

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    [TerraformPropertyName("authorization")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterAuthorizationBlock>>? Authorization { get; set; } = new();

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    [TerraformPropertyName("control_plane")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterControlPlaneBlock>>? ControlPlane { get; set; } = new();

    /// <summary>
    /// Block for control_plane_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlaneEncryption block(s) allowed")]
    [TerraformPropertyName("control_plane_encryption")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterControlPlaneEncryptionBlock>>? ControlPlaneEncryption { get; set; } = new();

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    [TerraformPropertyName("fleet")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterFleetBlock>>? Fleet { get; set; } = new();

    /// <summary>
    /// Block for maintenance_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_policy")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterMaintenancePolicyBlock>>? MaintenancePolicy { get; set; } = new();

    /// <summary>
    /// Block for networking.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    [TerraformPropertyName("networking")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterNetworkingBlock>>? Networking { get; set; } = new();

    /// <summary>
    /// Block for system_addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemAddonsConfig block(s) allowed")]
    [TerraformPropertyName("system_addons_config")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerClusterSystemAddonsConfigBlock>>? SystemAddonsConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleEdgecontainerClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The PEM-encoded public certificate of the cluster&#39;s CA.
    /// </summary>
    [TerraformPropertyName("cluster_ca_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterCaCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_ca_certificate");

    /// <summary>
    /// The control plane release version.
    /// </summary>
    [TerraformPropertyName("control_plane_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlPlaneVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_plane_version");

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The IP address of the Kubernetes API server.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// All the maintenance events scheduled for the cluster, including the ones
    /// ongoing, planned for the future and done in the past (up to 90 days).
    /// </summary>
    [TerraformPropertyName("maintenance_events")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceEvents => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_events");

    /// <summary>
    /// The lowest release version among all worker nodes. This field can be empty
    /// if the cluster does not have any worker nodes.
    /// </summary>
    [TerraformPropertyName("node_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_version");

    /// <summary>
    /// The port number of the Kubernetes API server.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// Indicates the status of the cluster.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
