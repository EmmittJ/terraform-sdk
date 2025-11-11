using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterAzureActiveDirectoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientApplicationId is required")]
    [TerraformProperty("client_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientApplicationId { get; set; }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    [TerraformProperty("cluster_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterApplicationId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformProperty("thumbprint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Thumbprint { get; set; }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    [TerraformProperty("thumbprint_secondary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThumbprintSecondary { get; set; }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformProperty("x509_store_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> X509StoreName { get; set; }

}

/// <summary>
/// Block type for certificate_common_names in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterCertificateCommonNamesBlock : TerraformBlockBase
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformProperty("x509_store_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> X509StoreName { get; set; }

}

/// <summary>
/// Block type for client_certificate_common_name in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterClientCertificateCommonNameBlock : TerraformBlockBase
{
    /// <summary>
    /// The common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    [TerraformProperty("common_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CommonName { get; set; }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    [TerraformProperty("is_admin")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsAdmin { get; set; }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    [TerraformProperty("issuer_thumbprint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IssuerThumbprint { get; set; }

}

/// <summary>
/// Block type for client_certificate_thumbprint in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterClientCertificateThumbprintBlock : TerraformBlockBase
{
    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    [TerraformProperty("is_admin")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsAdmin { get; set; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformProperty("thumbprint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Thumbprint { get; set; }

}

/// <summary>
/// Block type for diagnostics_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterDiagnosticsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobEndpoint is required")]
    [TerraformProperty("blob_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BlobEndpoint { get; set; }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    [TerraformProperty("protected_account_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtectedAccountKeyName { get; set; }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    [TerraformProperty("queue_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueueEndpoint { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformProperty("storage_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    [TerraformProperty("table_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableEndpoint { get; set; }

}

/// <summary>
/// Block type for fabric_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterFabricSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterNodeTypeBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacities attribute.
    /// </summary>
    [TerraformProperty("capacities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Capacities { get; set; }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    [TerraformProperty("client_endpoint_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ClientEndpointPort { get; set; }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    [TerraformProperty("durability_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DurabilityLevel { get; set; }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    [TerraformProperty("http_endpoint_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> HttpEndpointPort { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformProperty("instance_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InstanceCount { get; set; }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    [TerraformProperty("is_primary")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsPrimary { get; set; }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    [TerraformProperty("is_stateless")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsStateless { get; set; }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    [TerraformProperty("multiple_availability_zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultipleAvailabilityZones { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    [TerraformProperty("placement_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? PlacementProperties { get; set; }

    /// <summary>
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    [TerraformProperty("reverse_proxy_endpoint_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReverseProxyEndpointPort { get; set; }

}

/// <summary>
/// Block type for reverse_proxy_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterReverseProxyCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    [TerraformProperty("thumbprint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Thumbprint { get; set; }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    [TerraformProperty("thumbprint_secondary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThumbprintSecondary { get; set; }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformProperty("x509_store_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> X509StoreName { get; set; }

}

/// <summary>
/// Block type for reverse_proxy_certificate_common_names in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock : TerraformBlockBase
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    [TerraformProperty("x509_store_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> X509StoreName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServiceFabricClusterTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

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
public partial class AzurermServiceFabricClusterUpgradePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The force_restart_enabled attribute.
    /// </summary>
    [TerraformProperty("force_restart_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceRestartEnabled { get; set; }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    [TerraformProperty("health_check_retry_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckRetryTimeout { get; set; }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    [TerraformProperty("health_check_stable_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckStableDuration { get; set; }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    [TerraformProperty("health_check_wait_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckWaitDuration { get; set; }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    [TerraformProperty("upgrade_domain_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpgradeDomainTimeout { get; set; }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    [TerraformProperty("upgrade_replica_set_check_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpgradeReplicaSetCheckTimeout { get; set; }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    [TerraformProperty("upgrade_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpgradeTimeout { get; set; }

}

/// <summary>
/// Manages a azurerm_service_fabric_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermServiceFabricCluster : TerraformResource
{
    public AzurermServiceFabricCluster(string name) : base("azurerm_service_fabric_cluster", name)
    {
    }

    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    [TerraformProperty("add_on_features")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AddOnFeatures { get; set; }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    [TerraformProperty("cluster_code_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterCodeVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    [TerraformProperty("management_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagementEndpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    [TerraformProperty("reliability_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReliabilityLevel { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    [TerraformProperty("service_fabric_zonal_upgrade_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceFabricZonalUpgradeMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    [TerraformProperty("upgrade_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UpgradeMode { get; set; }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    [TerraformProperty("vm_image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmImage { get; set; }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    [TerraformProperty("vmss_zonal_upgrade_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VmssZonalUpgradeMode { get; set; }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    [TerraformProperty("azure_active_directory")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterAzureActiveDirectoryBlock>>? AzureActiveDirectory { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformProperty("certificate")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    [TerraformProperty("certificate_common_names")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterCertificateCommonNamesBlock>>? CertificateCommonNames { get; set; }

    /// <summary>
    /// Block for client_certificate_common_name.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("client_certificate_common_name")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterClientCertificateCommonNameBlock>>? ClientCertificateCommonName { get; set; }

    /// <summary>
    /// Block for client_certificate_thumbprint.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("client_certificate_thumbprint")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterClientCertificateThumbprintBlock>>? ClientCertificateThumbprint { get; set; }

    /// <summary>
    /// Block for diagnostics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    [TerraformProperty("diagnostics_config")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterDiagnosticsConfigBlock>>? DiagnosticsConfig { get; set; }

    /// <summary>
    /// Block for fabric_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("fabric_settings")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterFabricSettingsBlock>>? FabricSettings { get; set; }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    [TerraformProperty("node_type")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterNodeTypeBlock>>? NodeType { get; set; }

    /// <summary>
    /// Block for reverse_proxy_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    [TerraformProperty("reverse_proxy_certificate")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterReverseProxyCertificateBlock>>? ReverseProxyCertificate { get; set; }

    /// <summary>
    /// Block for reverse_proxy_certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    [TerraformProperty("reverse_proxy_certificate_common_names")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>>? ReverseProxyCertificateCommonNames { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermServiceFabricClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformProperty("upgrade_policy")]
    public partial TerraformList<TerraformBlock<AzurermServiceFabricClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterEndpoint { get; }

}
