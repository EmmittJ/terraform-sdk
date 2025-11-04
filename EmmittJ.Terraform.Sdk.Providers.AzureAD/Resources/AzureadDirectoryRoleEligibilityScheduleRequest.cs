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
    public string? DirectoryScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_scope_id")?.Value;
        set => this.WithProperty("directory_scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Justification for why the role is assigned
    /// </summary>
    public string? Justification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("justification")?.Value;
        set => this.WithProperty("justification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    public string? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id")?.Value;
        set => this.WithProperty("principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the directory role for this role eligibility schedule request
    /// </summary>
    public string? RoleDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_definition_id")?.Value;
        set => this.WithProperty("role_definition_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
