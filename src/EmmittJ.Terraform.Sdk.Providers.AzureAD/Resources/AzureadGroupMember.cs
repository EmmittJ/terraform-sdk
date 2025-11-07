using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_group_member resource.
/// </summary>
public class AzureadGroupMember : TerraformResource
{
    public AzureadGroupMember(string name) : base("azuread_group_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The object ID of the group you want to add the member to
    /// </summary>
    public TerraformProperty<string>? GroupObjectId
    {
        get => GetProperty<TerraformProperty<string>>("group_object_id");
        set => this.WithProperty("group_object_id", value);
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
    /// The object ID of the principal you want to add as a member to the group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    public TerraformProperty<string>? MemberObjectId
    {
        get => GetProperty<TerraformProperty<string>>("member_object_id");
        set => this.WithProperty("member_object_id", value);
    }

}
