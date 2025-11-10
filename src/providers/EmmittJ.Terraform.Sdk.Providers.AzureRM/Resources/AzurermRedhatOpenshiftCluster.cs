using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_server_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterApiServerProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>("", "url");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformPropertyName("visibility")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Visibility { get; set; }

}

/// <summary>
/// Block type for cluster_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterClusterProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FipsEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The pull_secret attribute.
    /// </summary>
    [TerraformPropertyName("pull_secret")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PullSecret { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_group_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceGroupId => new TerraformReferenceProperty<TerraformProperty<string>>("", "resource_group_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for ingress_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterIngressProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformPropertyName("visibility")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Visibility { get; set; }

}

/// <summary>
/// Block type for main_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterMainProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmSize { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterNetworkProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformPropertyName("outbound_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutboundType { get; set; }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodCidr is required")]
    [TerraformPropertyName("pod_cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PodCidr { get; set; }

    /// <summary>
    /// The preconfigured_network_security_group_enabled attribute.
    /// </summary>
    [TerraformPropertyName("preconfigured_network_security_group_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreconfiguredNetworkSecurityGroupEnabled { get; set; }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCidr is required")]
    [TerraformPropertyName("service_cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceCidr { get; set; }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterServicePrincipalBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientSecret { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedhatOpenshiftClusterTimeoutsBlock : ITerraformBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for worker_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterWorkerProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformPropertyName("disk_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NodeCount { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmSize { get; set; }

}

/// <summary>
/// Manages a azurerm_redhat_openshift_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedhatOpenshiftCluster : TerraformResource
{
    public AzurermRedhatOpenshiftCluster(string name) : base("azurerm_redhat_openshift_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for api_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiServerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApiServerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerProfile block(s) allowed")]
    [TerraformPropertyName("api_server_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterApiServerProfileBlock>>? ApiServerProfile { get; set; } = new();

    /// <summary>
    /// Block for cluster_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClusterProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterProfile block(s) allowed")]
    [TerraformPropertyName("cluster_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterClusterProfileBlock>>? ClusterProfile { get; set; } = new();

    /// <summary>
    /// Block for ingress_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IngressProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressProfile block(s) allowed")]
    [TerraformPropertyName("ingress_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterIngressProfileBlock>>? IngressProfile { get; set; } = new();

    /// <summary>
    /// Block for main_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainProfile block(s) allowed")]
    [TerraformPropertyName("main_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterMainProfileBlock>>? MainProfile { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformPropertyName("network_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterNetworkProfileBlock>>? NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServicePrincipal block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformPropertyName("service_principal")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterServicePrincipalBlock>>? ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRedhatOpenshiftClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerProfile block(s) allowed")]
    [TerraformPropertyName("worker_profile")]
    public TerraformList<TerraformBlock<AzurermRedhatOpenshiftClusterWorkerProfileBlock>>? WorkerProfile { get; set; } = new();

    /// <summary>
    /// The console_url attribute.
    /// </summary>
    [TerraformPropertyName("console_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConsoleUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "console_url");

}
