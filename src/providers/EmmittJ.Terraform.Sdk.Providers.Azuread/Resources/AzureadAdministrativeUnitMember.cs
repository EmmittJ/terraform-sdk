using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAdministrativeUnitMember.
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitMemberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_administrative_unit_member Terraform resource.
/// Manages a azuread_administrative_unit_member resource.
/// </summary>
public partial class AzureadAdministrativeUnitMember(string name) : TerraformResource("azuread_administrative_unit_member", name)
{
    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformValue<string>? AdministrativeUnitObjectId
    {
        get => new TerraformReference<string>(this, "administrative_unit_object_id");
        set => SetArgument("administrative_unit_object_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    public TerraformValue<string>? MemberObjectId
    {
        get => new TerraformReference<string>(this, "member_object_id");
        set => SetArgument("member_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAdministrativeUnitMemberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAdministrativeUnitMemberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
