using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_administrative_unit_member resource.
/// </summary>
public class AzureadAdministrativeUnitMember : TerraformResource
{
    public AzureadAdministrativeUnitMember(string name) : base("azuread_administrative_unit_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformProperty<string>? AdministrativeUnitObjectId
    {
        get => GetProperty<TerraformProperty<string>>("administrative_unit_object_id");
        set => this.WithProperty("administrative_unit_object_id", value);
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

}
