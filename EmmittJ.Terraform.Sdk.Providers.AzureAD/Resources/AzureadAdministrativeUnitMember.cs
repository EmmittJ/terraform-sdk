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
    public string? AdministrativeUnitObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrative_unit_object_id")?.Value;
        set => this.WithProperty("administrative_unit_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
