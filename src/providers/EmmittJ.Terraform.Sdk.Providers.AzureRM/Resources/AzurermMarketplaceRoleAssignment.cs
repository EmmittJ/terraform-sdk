using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceRoleAssignmentTimeoutsBlock : TerraformBlock
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
        SetOutput("principal_type");
        SetOutput("condition");
        SetOutput("condition_version");
        SetOutput("delegated_managed_identity_resource_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("principal_id");
        SetOutput("role_definition_id");
        SetOutput("role_definition_name");
        SetOutput("skip_service_principal_aad_check");
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string> Condition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("condition");
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public TerraformProperty<string> ConditionVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("condition_version");
        set => SetProperty("condition_version", value);
    }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> DelegatedManagedIdentityResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delegated_managed_identity_resource_id");
        set => SetProperty("delegated_managed_identity_resource_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_id");
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    public TerraformProperty<string> RoleDefinitionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_name");
        set => SetProperty("role_definition_name", value);
    }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    public TerraformProperty<bool> SkipServicePrincipalAadCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_service_principal_aad_check");
        set => SetProperty("skip_service_principal_aad_check", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMarketplaceRoleAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

}
