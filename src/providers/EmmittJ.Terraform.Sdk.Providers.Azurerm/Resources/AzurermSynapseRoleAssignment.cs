using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSynapseRoleAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermSynapseRoleAssignmentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_synapse_role_assignment Terraform resource.
/// Manages a azurerm_synapse_role_assignment resource.
/// </summary>
public partial class AzurermSynapseRoleAssignment(string name) : TerraformResource("azurerm_synapse_role_assignment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The synapse_spark_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? SynapseSparkPoolId
    {
        get => new TerraformReference<string>(this, "synapse_spark_pool_id");
        set => SetArgument("synapse_spark_pool_id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? SynapseWorkspaceId
    {
        get => new TerraformReference<string>(this, "synapse_workspace_id");
        set => SetArgument("synapse_workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseRoleAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
