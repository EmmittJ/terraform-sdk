using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseRoleAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_synapse_role_assignment resource.
/// </summary>
public class AzurermSynapseRoleAssignment : TerraformResource
{
    public AzurermSynapseRoleAssignment(string name) : base("azurerm_synapse_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("principal_id");
        SetOutput("principal_type");
        SetOutput("role_name");
        SetOutput("synapse_spark_pool_id");
        SetOutput("synapse_workspace_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformProperty<string> PrincipalType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_type");
        set => SetProperty("principal_type", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// The synapse_spark_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> SynapseSparkPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_spark_pool_id");
        set => SetProperty("synapse_spark_pool_id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synapse_workspace_id");
        set => SetProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseRoleAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
