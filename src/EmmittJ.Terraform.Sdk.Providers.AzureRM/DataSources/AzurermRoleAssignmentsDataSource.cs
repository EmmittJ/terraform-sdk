using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_role_assignments.
/// </summary>
public class AzurermRoleAssignmentsDataSource : TerraformDataSource
{
    public AzurermRoleAssignmentsDataSource(string name) : base("azurerm_role_assignments", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("role_assignments");
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
    /// The limit_at_scope attribute.
    /// </summary>
    public bool? LimitAtScope
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("limit_at_scope")?.Value;
        set => this.WithProperty("limit_at_scope", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_assignments attribute.
    /// </summary>
    public TerraformExpression RoleAssignments => this["role_assignments"];

}
