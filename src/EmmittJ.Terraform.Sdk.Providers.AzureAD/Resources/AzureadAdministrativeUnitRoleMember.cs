using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_administrative_unit_role_member resource.
/// </summary>
public class AzureadAdministrativeUnitRoleMember : TerraformResource
{
    public AzureadAdministrativeUnitRoleMember(string name) : base("azuread_administrative_unit_role_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformLiteralProperty<string>? AdministrativeUnitObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrative_unit_object_id");
        set => this.WithProperty("administrative_unit_object_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    public TerraformLiteralProperty<string>? MemberObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_object_id");
        set => this.WithProperty("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformLiteralProperty<string>? RoleObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_object_id");
        set => this.WithProperty("role_object_id", value);
    }

}
