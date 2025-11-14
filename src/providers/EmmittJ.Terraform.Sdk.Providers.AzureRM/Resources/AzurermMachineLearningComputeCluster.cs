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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for scale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterScaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_settings";

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformArgument("max_node_count")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => new TerraformReference<double>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformArgument("min_node_count")]
    public required TerraformValue<double> MinNodeCount
    {
        get => new TerraformReference<double>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

    /// <summary>
    /// The scale_down_nodes_after_idle_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleDownNodesAfterIdleDuration is required")]
    [TerraformArgument("scale_down_nodes_after_idle_duration")]
    public required TerraformValue<string> ScaleDownNodesAfterIdleDuration
    {
        get => new TerraformReference<string>(this, "scale_down_nodes_after_idle_duration");
        set => SetArgument("scale_down_nodes_after_idle_duration", value);
    }

}

/// <summary>
/// Block type for ssh in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningComputeClusterSshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh";

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformArgument("admin_username")]
    public required TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The key_value attribute.
    /// </summary>
    [TerraformArgument("key_value")]
    public TerraformValue<string>? KeyValue
    {
        get => new TerraformReference<string>(this, "key_value");
        set => SetArgument("key_value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningComputeClusterTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_machine_learning_compute_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMachineLearningComputeCluster : TerraformResource
{
    public AzurermMachineLearningComputeCluster(string name) : base("azurerm_machine_learning_compute_cluster", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
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
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    [TerraformArgument("machine_learning_workspace_id")]
    public required TerraformValue<string> MachineLearningWorkspaceId
    {
        get => new TerraformReference<string>(this, "machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("node_public_ip_enabled")]
    public TerraformValue<bool>? NodePublicIpEnabled
    {
        get => new TerraformReference<bool>(this, "node_public_ip_enabled");
        set => SetArgument("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The ssh_public_access_enabled attribute.
    /// </summary>
    [TerraformArgument("ssh_public_access_enabled")]
    public TerraformValue<bool>? SshPublicAccessEnabled
    {
        get => new TerraformReference<bool>(this, "ssh_public_access_enabled");
        set => SetArgument("ssh_public_access_enabled", value);
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    [TerraformArgument("subnet_resource_id")]
    public TerraformValue<string> SubnetResourceId
    {
        get => new TerraformReference<string>(this, "subnet_resource_id");
        set => SetArgument("subnet_resource_id", value);
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
    /// The vm_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmPriority is required")]
    [TerraformArgument("vm_priority")]
    public required TerraformValue<string> VmPriority
    {
        get => new TerraformReference<string>(this, "vm_priority");
        set => SetArgument("vm_priority", value);
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

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMachineLearningComputeClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for scale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleSettings block(s) allowed")]
    [TerraformArgument("scale_settings")]
    public required TerraformList<AzurermMachineLearningComputeClusterScaleSettingsBlock> ScaleSettings { get; set; } = new();

    /// <summary>
    /// Block for ssh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    [TerraformArgument("ssh")]
    public TerraformList<AzurermMachineLearningComputeClusterSshBlock> Ssh { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMachineLearningComputeClusterTimeoutsBlock Timeouts { get; set; } = new();

}
