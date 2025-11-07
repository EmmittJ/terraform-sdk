using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_type");
        set => this.WithProperty("principal_type", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

    /// <summary>
    /// The synapse_spark_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseSparkPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_spark_pool_id");
        set => this.WithProperty("synapse_spark_pool_id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

}
