using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_database_principal_assignment resource.
/// </summary>
public class AzurermKustoDatabasePrincipalAssignment : TerraformResource
{
    public AzurermKustoDatabasePrincipalAssignment(string name) : base("azurerm_kusto_database_principal_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_name");
        this.DeclareOutput("tenant_name");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public string? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id")?.Value;
        set => this.WithProperty("principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public string? PrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_type")?.Value;
        set => this.WithProperty("principal_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_name attribute.
    /// </summary>
    public TerraformExpression PrincipalName => this["principal_name"];

    /// <summary>
    /// The tenant_name attribute.
    /// </summary>
    public TerraformExpression TenantName => this["tenant_name"];

}
