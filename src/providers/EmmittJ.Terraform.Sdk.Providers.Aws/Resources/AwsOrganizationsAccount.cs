using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsOrganizationsAccount.
/// Nesting mode: single
/// </summary>
public class AwsOrganizationsAccountTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_organizations_account Terraform resource.
/// Manages a aws_organizations_account resource.
/// </summary>
public partial class AwsOrganizationsAccount(string name) : TerraformResource("aws_organizations_account", name)
{
    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? CloseOnDeletion
    {
        get => GetArgument<TerraformValue<bool>>("close_on_deletion");
        set => SetArgument("close_on_deletion", value);
    }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    public TerraformValue<bool>? CreateGovcloud
    {
        get => GetArgument<TerraformValue<bool>>("create_govcloud");
        set => SetArgument("create_govcloud", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    public TerraformValue<string>? IamUserAccessToBilling
    {
        get => GetArgument<TerraformValue<string>>("iam_user_access_to_billing");
        set => SetArgument("iam_user_access_to_billing", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformValue<string> ParentId
    {
        get => GetArgument<TerraformValue<string>>("parent_id") ?? CreateReference("parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleName
    {
        get => GetArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    public TerraformValue<string> GovcloudId
        => CreateReference("govcloud_id");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformValue<string> JoinedMethod
        => CreateReference("joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformValue<string> JoinedTimestamp
        => CreateReference("joined_timestamp");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOrganizationsAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOrganizationsAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
