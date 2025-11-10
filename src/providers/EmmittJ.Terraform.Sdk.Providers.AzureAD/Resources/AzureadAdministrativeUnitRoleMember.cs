using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitRoleMemberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("administrative_unit_object_id");
        SetOutput("id");
        SetOutput("member_object_id");
        SetOutput("role_object_id");
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministrativeUnitObjectId is required")]
    public required TerraformProperty<string> AdministrativeUnitObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrative_unit_object_id");
        set => SetProperty("administrative_unit_object_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    public required TerraformProperty<string> MemberObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_object_id");
        set => SetProperty("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleObjectId is required")]
    public required TerraformProperty<string> RoleObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_object_id");
        set => SetProperty("role_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAdministrativeUnitRoleMemberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
