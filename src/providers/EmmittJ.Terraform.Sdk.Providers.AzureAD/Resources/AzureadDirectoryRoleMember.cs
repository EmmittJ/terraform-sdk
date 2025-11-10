using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleMemberTimeoutsBlock : TerraformBlock
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
        SetOutput("id");
        SetOutput("member_object_id");
        SetOutput("role_object_id");
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
    public TerraformProperty<string> MemberObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_object_id");
        set => SetProperty("member_object_id", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformProperty<string> RoleObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_object_id");
        set => SetProperty("role_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleMemberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
