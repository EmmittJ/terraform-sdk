using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_marketplace_role_assignment resource.
/// </summary>
public class AzurermMarketplaceRoleAssignment : TerraformResource
{
    public AzurermMarketplaceRoleAssignment(string name) : base("azurerm_marketplace_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_type");
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public string? Condition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("condition")?.Value;
        set => this.WithProperty("condition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public string? ConditionVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("condition_version")?.Value;
        set => this.WithProperty("condition_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    public string? DelegatedManagedIdentityResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delegated_managed_identity_resource_id")?.Value;
        set => this.WithProperty("delegated_managed_identity_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_definition_id attribute.
    /// </summary>
    public string? RoleDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_definition_id")?.Value;
        set => this.WithProperty("role_definition_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    public string? RoleDefinitionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_definition_name")?.Value;
        set => this.WithProperty("role_definition_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    public bool? SkipServicePrincipalAadCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_service_principal_aad_check")?.Value;
        set => this.WithProperty("skip_service_principal_aad_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

}
