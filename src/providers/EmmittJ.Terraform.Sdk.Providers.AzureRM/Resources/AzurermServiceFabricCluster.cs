using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterAzureActiveDirectoryBlock : ITerraformBlock
{
    /// <summary>
    /// The client_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientApplicationId is required")]
    [TerraformPropertyName("client_application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientApplicationId { get; set; }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    [TerraformPropertyName("cluster_application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterApplicationId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformPropertyName("tenant_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TenantId { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformPropertyName("thumbprint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Thumbprint { get; set; }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_secondary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThumbprintSecondary { get; set; }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformPropertyName("x509_store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> X509StoreName { get; set; }

}

/// <summary>
/// Block type for certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateCommonNamesBlock : ITerraformBlock
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformPropertyName("x509_store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> X509StoreName { get; set; }

}

/// <summary>
/// Block type for client_certificate_common_name in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateCommonNameBlock : ITerraformBlock
{
    /// <summary>
    /// The common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    [TerraformPropertyName("common_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CommonName { get; set; }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    [TerraformPropertyName("is_admin")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsAdmin { get; set; }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("issuer_thumbprint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IssuerThumbprint { get; set; }

}

/// <summary>
/// Block type for client_certificate_thumbprint in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateThumbprintBlock : ITerraformBlock
{
    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    [TerraformPropertyName("is_admin")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsAdmin { get; set; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformPropertyName("thumbprint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Thumbprint { get; set; }

}

/// <summary>
/// Block type for diagnostics_config in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterDiagnosticsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobEndpoint is required")]
    [TerraformPropertyName("blob_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BlobEndpoint { get; set; }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    [TerraformPropertyName("protected_account_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProtectedAccountKeyName { get; set; }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    [TerraformPropertyName("queue_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueueEndpoint { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformPropertyName("storage_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountName { get; set; }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    [TerraformPropertyName("table_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableEndpoint { get; set; }

}

/// <summary>
/// Block type for fabric_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterFabricSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterNodeTypeBlock : ITerraformBlock
{
    /// <summary>
    /// The capacities attribute.
    /// </summary>
    [TerraformPropertyName("capacities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Capacities { get; set; }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    [TerraformPropertyName("client_endpoint_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ClientEndpointPort { get; set; }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    [TerraformPropertyName("durability_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DurabilityLevel { get; set; }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    [TerraformPropertyName("http_endpoint_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> HttpEndpointPort { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformPropertyName("instance_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> InstanceCount { get; set; }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    [TerraformPropertyName("is_primary")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsPrimary { get; set; }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    [TerraformPropertyName("is_stateless")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsStateless { get; set; }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("multiple_availability_zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultipleAvailabilityZones { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    [TerraformPropertyName("placement_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? PlacementProperties { get; set; }

    /// <summary>
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    [TerraformPropertyName("reverse_proxy_endpoint_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReverseProxyEndpointPort { get; set; }

}

/// <summary>
/// Block type for reverse_proxy_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformPropertyName("thumbprint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Thumbprint { get; set; }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_secondary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThumbprintSecondary { get; set; }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformPropertyName("x509_store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> X509StoreName { get; set; }

}

/// <summary>
/// Block type for reverse_proxy_certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock : ITerraformBlock
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformPropertyName("x509_store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> X509StoreName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The force_restart_enabled attribute.
    /// </summary>
    [TerraformPropertyName("force_restart_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceRestartEnabled { get; set; }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    [TerraformPropertyName("health_check_retry_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckRetryTimeout { get; set; }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    [TerraformPropertyName("health_check_stable_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckStableDuration { get; set; }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    [TerraformPropertyName("health_check_wait_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckWaitDuration { get; set; }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_domain_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpgradeDomainTimeout { get; set; }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_replica_set_check_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpgradeTimeout { get; set; }

}

/// <summary>
/// Manages a azurerm_service_fabric_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServiceFabricCluster : TerraformResource
{
    public AzurermServiceFabricCluster(string name) : base("azurerm_service_fabric_cluster", name)
    {
    }

    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    [TerraformPropertyName("add_on_features")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AddOnFeatures { get; set; }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_code_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterCodeVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_code_version");

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
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    [TerraformPropertyName("management_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagementEndpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    [TerraformPropertyName("reliability_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReliabilityLevel { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    [TerraformPropertyName("service_fabric_zonal_upgrade_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    [TerraformPropertyName("upgrade_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UpgradeMode { get; set; }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    [TerraformPropertyName("vm_image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmImage { get; set; }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    [TerraformPropertyName("vmss_zonal_upgrade_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VmssZonalUpgradeMode { get; set; }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    [TerraformPropertyName("azure_active_directory")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterAzureActiveDirectoryBlock>>? AzureActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformPropertyName("certificate")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterCertificateBlock>>? Certificate { get; set; } = new();

    /// <summary>
    /// Block for certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    [TerraformPropertyName("certificate_common_names")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterCertificateCommonNamesBlock>>? CertificateCommonNames { get; set; } = new();

    /// <summary>
    /// Block for client_certificate_common_name.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("client_certificate_common_name")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterClientCertificateCommonNameBlock>>? ClientCertificateCommonName { get; set; } = new();

    /// <summary>
    /// Block for client_certificate_thumbprint.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("client_certificate_thumbprint")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterClientCertificateThumbprintBlock>>? ClientCertificateThumbprint { get; set; } = new();

    /// <summary>
    /// Block for diagnostics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    [TerraformPropertyName("diagnostics_config")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterDiagnosticsConfigBlock>>? DiagnosticsConfig { get; set; } = new();

    /// <summary>
    /// Block for fabric_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("fabric_settings")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterFabricSettingsBlock>>? FabricSettings { get; set; } = new();

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    [TerraformPropertyName("node_type")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterNodeTypeBlock>>? NodeType { get; set; } = new();

    /// <summary>
    /// Block for reverse_proxy_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    [TerraformPropertyName("reverse_proxy_certificate")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterReverseProxyCertificateBlock>>? ReverseProxyCertificate { get; set; } = new();

    /// <summary>
    /// Block for reverse_proxy_certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    [TerraformPropertyName("reverse_proxy_certificate_common_names")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>>? ReverseProxyCertificateCommonNames { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServiceFabricClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformPropertyName("upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermServiceFabricClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; } = new();

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_endpoint");

}
