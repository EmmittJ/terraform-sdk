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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    public string? MemberObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_object_id")?.Value;
        set => this.WithProperty("member_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public string? RoleObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_object_id")?.Value;
        set => this.WithProperty("role_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
