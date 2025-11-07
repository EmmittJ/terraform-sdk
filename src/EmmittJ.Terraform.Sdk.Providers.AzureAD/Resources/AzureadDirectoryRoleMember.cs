using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_directory_role_member resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzureadDirectoryRoleMember : TerraformResource
{
    public AzureadDirectoryRoleMember(string name) : base("azuread_directory_role_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The object ID of the member
    /// </summary>
    public TerraformProperty<string>? MemberObjectId
    {
        get => GetProperty<TerraformProperty<string>>("member_object_id");
        set => this.WithProperty("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformProperty<string>? RoleObjectId
    {
        get => GetProperty<TerraformProperty<string>>("role_object_id");
        set => this.WithProperty("role_object_id", value);
    }

}
