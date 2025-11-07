using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_role_assignment resource.
/// </summary>
public class AzurermRoleAssignment : TerraformResource
{
    public AzurermRoleAssignment(string name) : base("azurerm_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public TerraformProperty<string>? ConditionVersion
    {
        get => GetProperty<TerraformProperty<string>>("condition_version");
        set => this.WithProperty("condition_version", value);
    }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedManagedIdentityResourceId
    {
        get => GetProperty<TerraformProperty<string>>("delegated_managed_identity_resource_id");
        set => this.WithProperty("delegated_managed_identity_resource_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalType
    {
        get => GetProperty<TerraformProperty<string>>("principal_type");
        set => this.WithProperty("principal_type", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformProperty<string>? RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleDefinitionName
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_name");
        set => this.WithProperty("role_definition_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipServicePrincipalAadCheck
    {
        get => GetProperty<TerraformProperty<bool>>("skip_service_principal_aad_check");
        set => this.WithProperty("skip_service_principal_aad_check", value);
    }

}
