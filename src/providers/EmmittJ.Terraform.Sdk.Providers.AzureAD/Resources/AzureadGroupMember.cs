using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupMemberTimeoutsBlock : TerraformBlock
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
        SetOutput("group_object_id");
        SetOutput("id");
        SetOutput("member_object_id");
    }

    /// <summary>
    /// The object ID of the group you want to add the member to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupObjectId is required")]
    public required TerraformProperty<string> GroupObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_object_id");
        set => SetProperty("group_object_id", value);
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
    /// The object ID of the principal you want to add as a member to the group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    public required TerraformProperty<string> MemberObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_object_id");
        set => SetProperty("member_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadGroupMemberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
