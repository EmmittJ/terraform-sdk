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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "close_on_deletion");
        set => SetArgument("close_on_deletion", value);
    }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    public TerraformValue<bool>? CreateGovcloud
    {
        get => new TerraformReference<bool>(this, "create_govcloud");
        set => SetArgument("create_govcloud", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    public TerraformValue<string>? IamUserAccessToBilling
    {
        get => new TerraformReference<string>(this, "iam_user_access_to_billing");
        set => SetArgument("iam_user_access_to_billing", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    public TerraformValue<string> GovcloudId
    {
        get => new TerraformReference<string>(this, "govcloud_id");
    }

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformValue<string> JoinedMethod
    {
        get => new TerraformReference<string>(this, "joined_method");
    }

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformValue<string> JoinedTimestamp
    {
        get => new TerraformReference<string>(this, "joined_timestamp");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOrganizationsAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOrganizationsAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
