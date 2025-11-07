using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
    }

    /// <summary>
    /// ID of the group to which this policy is assigned
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
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
    public TerraformProperty<string>? RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
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
