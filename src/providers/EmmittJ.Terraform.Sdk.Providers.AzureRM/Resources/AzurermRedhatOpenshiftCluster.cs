using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_server_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterApiServerProfileBlock() : TerraformBlock("api_server_profile")
{


    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformProperty("visibility")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Visibility { get; set; }

}

/// <summary>
/// Block type for cluster_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterClusterProfileBlock() : TerraformBlock("cluster_profile")
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformProperty("fips_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The pull_secret attribute.
    /// </summary>
    [TerraformProperty("pull_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PullSecret { get; set; }


    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for ingress_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterIngressProfileBlock() : TerraformBlock("ingress_profile")
{


    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformProperty("visibility")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Visibility { get; set; }

}

/// <summary>
/// Block type for main_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterMainProfileBlock() : TerraformBlock("main_profile")
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_at_host_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmSize { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterNetworkProfileBlock() : TerraformBlock("network_profile")
{
    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformProperty("outbound_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutboundType { get; set; }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodCidr is required")]
    [TerraformProperty("pod_cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PodCidr { get; set; }

    /// <summary>
    /// The preconfigured_network_security_group_enabled attribute.
    /// </summary>
    [TerraformProperty("preconfigured_network_security_group_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreconfiguredNetworkSecurityGroupEnabled { get; set; }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCidr is required")]
    [TerraformProperty("service_cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceCidr { get; set; }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterServicePrincipalBlock() : TerraformBlock("service_principal")
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedhatOpenshiftClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for worker_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRedhatOpenshiftClusterWorkerProfileBlock() : TerraformBlock("worker_profile")
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformProperty("disk_size_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_at_host_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformProperty("node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmSize { get; set; }

}

/// <summary>
/// Manages a azurerm_redhat_openshift_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermRedhatOpenshiftCluster : TerraformResource
{
    public AzurermRedhatOpenshiftCluster(string name) : base("azurerm_redhat_openshift_cluster", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for api_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiServerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApiServerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerProfile block(s) allowed")]
    [TerraformProperty("api_server_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterApiServerProfileBlock> ApiServerProfile { get; set; } = new();

    /// <summary>
    /// Block for cluster_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClusterProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterProfile block(s) allowed")]
    [TerraformProperty("cluster_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterClusterProfileBlock> ClusterProfile { get; set; } = new();

    /// <summary>
    /// Block for ingress_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IngressProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressProfile block(s) allowed")]
    [TerraformProperty("ingress_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterIngressProfileBlock> IngressProfile { get; set; } = new();

    /// <summary>
    /// Block for main_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainProfile block(s) allowed")]
    [TerraformProperty("main_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterMainProfileBlock> MainProfile { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformProperty("network_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterNetworkProfileBlock> NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServicePrincipal block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformProperty("service_principal")]
    public required TerraformList<AzurermRedhatOpenshiftClusterServicePrincipalBlock> ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermRedhatOpenshiftClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerProfile block(s) allowed")]
    [TerraformProperty("worker_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterWorkerProfileBlock> WorkerProfile { get; set; } = new();

    /// <summary>
    /// The console_url attribute.
    /// </summary>
    [TerraformProperty("console_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConsoleUrl { get; }

}
