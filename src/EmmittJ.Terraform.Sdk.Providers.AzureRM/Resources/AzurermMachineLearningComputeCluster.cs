using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for scale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterScaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

    /// <summary>
    /// The scale_down_nodes_after_idle_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleDownNodesAfterIdleDuration is required")]
    public required TerraformProperty<string> ScaleDownNodesAfterIdleDuration
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_nodes_after_idle_duration");
        set => WithProperty("scale_down_nodes_after_idle_duration", value);
    }

}

/// <summary>
/// Block type for ssh in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterSshBlock : TerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => WithProperty("admin_username", value);
    }

    /// <summary>
    /// The key_value attribute.
    /// </summary>
    public TerraformProperty<string>? KeyValue
    {
        get => GetProperty<TerraformProperty<string>>("key_value");
        set => WithProperty("key_value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningComputeClusterTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_machine_learning_compute_cluster resource.
/// </summary>
public class AzurermMachineLearningComputeCluster : TerraformResource
{
    public AzurermMachineLearningComputeCluster(string name) : base("azurerm_machine_learning_compute_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
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
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformProperty<string> MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("machine_learning_workspace_id");
        set => this.WithProperty("machine_learning_workspace_id", value);
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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The ssh_public_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SshPublicAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssh_public_access_enabled");
        set => this.WithProperty("ssh_public_access_enabled", value);
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_resource_id");
        set => this.WithProperty("subnet_resource_id", value);
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
    /// The vm_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmPriority is required")]
    public required TerraformProperty<string> VmPriority
    {
        get => GetProperty<TerraformProperty<string>>("vm_priority");
        set => this.WithProperty("vm_priority", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningComputeClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMachineLearningComputeClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for scale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleSettings block(s) allowed")]
    public List<AzurermMachineLearningComputeClusterScaleSettingsBlock>? ScaleSettings
    {
        get => GetProperty<List<AzurermMachineLearningComputeClusterScaleSettingsBlock>>("scale_settings");
        set => this.WithProperty("scale_settings", value);
    }

    /// <summary>
    /// Block for ssh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    public List<AzurermMachineLearningComputeClusterSshBlock>? Ssh
    {
        get => GetProperty<List<AzurermMachineLearningComputeClusterSshBlock>>("ssh");
        set => this.WithProperty("ssh", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningComputeClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMachineLearningComputeClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
