using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryScopeId is required")]
    public required TerraformProperty<string> DirectoryScopeId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Justification is required")]
    public required TerraformProperty<string> Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this role eligibility schedule request
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
