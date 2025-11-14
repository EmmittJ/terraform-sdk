using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for api_server_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterApiServerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_server_profile";



    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformArgument("visibility")]
    public required TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

}

/// <summary>
/// Block type for cluster_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterClusterProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_profile";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformArgument("domain")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformArgument("fips_enabled")]
    public TerraformValue<bool>? FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformArgument("managed_resource_group_name")]
    public TerraformValue<string>? ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The pull_secret attribute.
    /// </summary>
    [TerraformArgument("pull_secret")]
    public TerraformValue<string>? PullSecret
    {
        get => new TerraformReference<string>(this, "pull_secret");
        set => SetArgument("pull_secret", value);
    }


    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for ingress_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterIngressProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_profile";



    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Visibility is required")]
    [TerraformArgument("visibility")]
    public required TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

}

/// <summary>
/// Block type for main_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterMainProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "main_profile";

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformArgument("encryption_at_host_enabled")]
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformArgument("vm_size")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The outbound_type attribute.
    /// </summary>
    [TerraformArgument("outbound_type")]
    public TerraformValue<string>? OutboundType
    {
        get => new TerraformReference<string>(this, "outbound_type");
        set => SetArgument("outbound_type", value);
    }

    /// <summary>
    /// The pod_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodCidr is required")]
    [TerraformArgument("pod_cidr")]
    public required TerraformValue<string> PodCidr
    {
        get => new TerraformReference<string>(this, "pod_cidr");
        set => SetArgument("pod_cidr", value);
    }

    /// <summary>
    /// The preconfigured_network_security_group_enabled attribute.
    /// </summary>
    [TerraformArgument("preconfigured_network_security_group_enabled")]
    public TerraformValue<bool>? PreconfiguredNetworkSecurityGroupEnabled
    {
        get => new TerraformReference<bool>(this, "preconfigured_network_security_group_enabled");
        set => SetArgument("preconfigured_network_security_group_enabled", value);
    }

    /// <summary>
    /// The service_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCidr is required")]
    [TerraformArgument("service_cidr")]
    public required TerraformValue<string> ServiceCidr
    {
        get => new TerraformReference<string>(this, "service_cidr");
        set => SetArgument("service_cidr", value);
    }

}

/// <summary>
/// Block type for service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_principal";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformArgument("client_id")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformArgument("client_secret")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedhatOpenshiftClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for worker_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermRedhatOpenshiftClusterWorkerProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_profile";

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformArgument("disk_size_gb")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformArgument("encryption_at_host_enabled")]
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformArgument("node_count")]
    public required TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformArgument("vm_size")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for api_server_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiServerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApiServerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiServerProfile block(s) allowed")]
    [TerraformArgument("api_server_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterApiServerProfileBlock> ApiServerProfile { get; set; } = new();

    /// <summary>
    /// Block for cluster_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClusterProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterProfile block(s) allowed")]
    [TerraformArgument("cluster_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterClusterProfileBlock> ClusterProfile { get; set; } = new();

    /// <summary>
    /// Block for ingress_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IngressProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressProfile block(s) allowed")]
    [TerraformArgument("ingress_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterIngressProfileBlock> IngressProfile { get; set; } = new();

    /// <summary>
    /// Block for main_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainProfile block(s) allowed")]
    [TerraformArgument("main_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterMainProfileBlock> MainProfile { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformArgument("network_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterNetworkProfileBlock> NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServicePrincipal block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    [TerraformArgument("service_principal")]
    public required TerraformList<AzurermRedhatOpenshiftClusterServicePrincipalBlock> ServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRedhatOpenshiftClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerProfile block(s) allowed")]
    [TerraformArgument("worker_profile")]
    public required TerraformList<AzurermRedhatOpenshiftClusterWorkerProfileBlock> WorkerProfile { get; set; } = new();

    /// <summary>
    /// The console_url attribute.
    /// </summary>
    [TerraformArgument("console_url")]
    public TerraformValue<string> ConsoleUrl
    {
        get => new TerraformReference<string>(this, "console_url");
    }

}
