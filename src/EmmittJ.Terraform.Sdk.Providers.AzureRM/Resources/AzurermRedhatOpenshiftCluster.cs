using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for api_server_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterApiServerProfileBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => WithProperty("ip_address", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    public required TerraformProperty<string> Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => WithProperty("visibility", value);
    }

}

/// <summary>
/// Block type for cluster_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterClusterProfileBlock : TerraformBlock
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The pull_secret attribute.
    /// </summary>
    public TerraformProperty<string>? PullSecret
    {
        get => GetProperty<TerraformProperty<string>>("pull_secret");
        set => WithProperty("pull_secret", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_id");
        set => WithProperty("resource_group_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for ingress_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterIngressProfileBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => WithProperty("ip_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    public required TerraformProperty<string> Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => WithProperty("visibility", value);
    }

}

/// <summary>
/// Block type for main_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterMainProfileBlock : TerraformBlock
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => WithProperty("vm_size", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundType
    {
        get => GetProperty<TerraformProperty<string>>("outbound_type");
        set => WithProperty("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodCidr is required")]
    public required TerraformProperty<string> PodCidr
    {
        get => GetProperty<TerraformProperty<string>>("pod_cidr");
        set => WithProperty("pod_cidr", value);
    }

    /// <summary>
    /// The preconfigured_network_security_group_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PreconfiguredNetworkSecurityGroupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("preconfigured_network_security_group_enabled");
        set => WithProperty("preconfigured_network_security_group_enabled", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCidr is required")]
    public required TerraformProperty<string> ServiceCidr
    {
        get => GetProperty<TerraformProperty<string>>("service_cidr");
        set => WithProperty("service_cidr", value);
    }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedhatOpenshiftClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for worker_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterWorkerProfileBlock : TerraformBlock
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformProperty<double> DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => WithProperty("vm_size", value);
    }

}

/// <summary>
/// Manages a azurerm_redhat_openshift_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedhatOpenshiftCluster : TerraformResource
{
    public AzurermRedhatOpenshiftCluster(string name) : base("azurerm_redhat_openshift_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("console_url");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for api_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApiServerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterApiServerProfileBlock>? ApiServerProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterApiServerProfileBlock>>("api_server_profile");
        set => this.WithProperty("api_server_profile", value);
    }

    /// <summary>
    /// Block for cluster_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClusterProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterClusterProfileBlock>? ClusterProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterClusterProfileBlock>>("cluster_profile");
        set => this.WithProperty("cluster_profile", value);
    }

    /// <summary>
    /// Block for ingress_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IngressProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterIngressProfileBlock>? IngressProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterIngressProfileBlock>>("ingress_profile");
        set => this.WithProperty("ingress_profile", value);
    }

    /// <summary>
    /// Block for main_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterMainProfileBlock>? MainProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterMainProfileBlock>>("main_profile");
        set => this.WithProperty("main_profile", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterNetworkProfileBlock>? NetworkProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterNetworkProfileBlock>>("network_profile");
        set => this.WithProperty("network_profile", value);
    }

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServicePrincipal block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterServicePrincipalBlock>? ServicePrincipal
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterServicePrincipalBlock>>("service_principal");
        set => this.WithProperty("service_principal", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedhatOpenshiftClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRedhatOpenshiftClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for worker_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerProfile block(s) allowed")]
    public List<AzurermRedhatOpenshiftClusterWorkerProfileBlock>? WorkerProfile
    {
        get => GetProperty<List<AzurermRedhatOpenshiftClusterWorkerProfileBlock>>("worker_profile");
        set => this.WithProperty("worker_profile", value);
    }

    /// <summary>
    /// The console_url attribute.
    /// </summary>
    public TerraformExpression ConsoleUrl => this["console_url"];

}
