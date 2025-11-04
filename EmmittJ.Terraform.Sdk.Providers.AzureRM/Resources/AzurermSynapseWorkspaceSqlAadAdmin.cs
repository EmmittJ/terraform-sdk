using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_workspace_sql_aad_admin resource.
/// </summary>
public class AzurermSynapseWorkspaceSqlAadAdmin : TerraformResource
{
    public AzurermSynapseWorkspaceSqlAadAdmin(string name) : base("azurerm_synapse_workspace_sql_aad_admin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login attribute.
    /// </summary>
    public string? Login
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login")?.Value;
        set => this.WithProperty("login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public string? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id")?.Value;
        set => this.WithProperty("synapse_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
