using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupRoleManagementPolicyDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azuread_group_role_management_policy.
/// </summary>
public class AzureadGroupRoleManagementPolicyDataSource : TerraformDataSource
{
    public AzureadGroupRoleManagementPolicyDataSource(string name) : base("azuread_group_role_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("description");
        this.WithOutput("display_name");
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The ID of the role of this policy to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupRoleManagementPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadGroupRoleManagementPolicyDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Description of the policy
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display name of the policy
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
