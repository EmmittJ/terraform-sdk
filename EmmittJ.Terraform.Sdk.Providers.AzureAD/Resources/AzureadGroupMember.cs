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
    public string? GroupObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_object_id")?.Value;
        set => this.WithProperty("group_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The object ID of the principal you want to add as a member to the group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    public string? MemberObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_object_id")?.Value;
        set => this.WithProperty("member_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
