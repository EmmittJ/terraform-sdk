using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assign_to_user in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceAssignToUserBlock : TerraformBlock
{
    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceIdentityBlock : TerraformBlock
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
/// Block type for ssh in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceSshBlock : TerraformBlock
{
    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformProperty<string> PublicKey
    {
        get => GetProperty<TerraformProperty<string>>("public_key");
        set => WithProperty("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningComputeInstanceTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_machine_learning_compute_instance resource.
/// </summary>
public class AzurermMachineLearningComputeInstance : TerraformResource
{
    public AzurermMachineLearningComputeInstance(string name) : base("azurerm_machine_learning_compute_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
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
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    public required TerraformProperty<string> VirtualMachineSize
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_size");
        set => this.WithProperty("virtual_machine_size", value);
    }

    /// <summary>
    /// Block for assign_to_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignToUser block(s) allowed")]
    public List<AzurermMachineLearningComputeInstanceAssignToUserBlock>? AssignToUser
    {
        get => GetProperty<List<AzurermMachineLearningComputeInstanceAssignToUserBlock>>("assign_to_user");
        set => this.WithProperty("assign_to_user", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningComputeInstanceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMachineLearningComputeInstanceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for ssh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    public List<AzurermMachineLearningComputeInstanceSshBlock>? Ssh
    {
        get => GetProperty<List<AzurermMachineLearningComputeInstanceSshBlock>>("ssh");
        set => this.WithProperty("ssh", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningComputeInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMachineLearningComputeInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
