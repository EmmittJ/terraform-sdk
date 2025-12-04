using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for assign_to_user in AzurermMachineLearningComputeInstance.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceAssignToUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assign_to_user";

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformValue<string>? ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMachineLearningComputeInstance.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for ssh in AzurermMachineLearningComputeInstance.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeInstanceSshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformValue<string> PublicKey
    {
        get => GetArgument<TerraformValue<string>>("public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}


/// <summary>
/// Block type for timeouts in AzurermMachineLearningComputeInstance.
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningComputeInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_machine_learning_compute_instance Terraform resource.
/// Manages a azurerm_machine_learning_compute_instance resource.
/// </summary>
public partial class AzurermMachineLearningComputeInstance(string name) : TerraformResource("azurerm_machine_learning_compute_instance", name)
{
    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationType
    {
        get => GetArgument<TerraformValue<string>>("authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformValue<string> MachineLearningWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NodePublicIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("node_public_ip_enabled");
        set => SetArgument("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetResourceId
    {
        get => GetArgument<TerraformValue<string>>("subnet_resource_id");
        set => SetArgument("subnet_resource_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    public required TerraformValue<string> VirtualMachineSize
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_size");
        set => SetArgument("virtual_machine_size", value);
    }

    /// <summary>
    /// AssignToUser block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignToUser block(s) allowed")]
    public TerraformList<AzurermMachineLearningComputeInstanceAssignToUserBlock>? AssignToUser
    {
        get => GetArgument<TerraformList<AzurermMachineLearningComputeInstanceAssignToUserBlock>>("assign_to_user");
        set => SetArgument("assign_to_user", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMachineLearningComputeInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMachineLearningComputeInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Ssh block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    public TerraformList<AzurermMachineLearningComputeInstanceSshBlock>? Ssh
    {
        get => GetArgument<TerraformList<AzurermMachineLearningComputeInstanceSshBlock>>("ssh");
        set => SetArgument("ssh", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMachineLearningComputeInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMachineLearningComputeInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
