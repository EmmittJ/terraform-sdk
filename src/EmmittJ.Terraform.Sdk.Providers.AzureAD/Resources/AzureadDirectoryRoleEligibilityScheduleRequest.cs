using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_directory_role_eligibility_schedule_request resource.
/// </summary>
public class AzureadDirectoryRoleEligibilityScheduleRequest : TerraformResource
{
    public AzureadDirectoryRoleEligibilityScheduleRequest(string name) : base("azuread_directory_role_eligibility_schedule_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the role eligibility schedule request
    /// </summary>
    public TerraformProperty<string>? DirectoryScopeId
    {
        get => GetProperty<TerraformProperty<string>>("directory_scope_id");
        set => this.WithProperty("directory_scope_id", value);
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
    /// Justification for why the role is assigned
    /// </summary>
    public TerraformProperty<string>? Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this role eligibility schedule request
    /// </summary>
    public TerraformProperty<string>? RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

}
