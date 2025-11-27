using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsQuicksightAccountSubscription.
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAccountSubscriptionTimeoutsBlock : TerraformBlock
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
/// Represents a aws_quicksight_account_subscription Terraform resource.
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public partial class AwsQuicksightAccountSubscription(string name) : TerraformResource("aws_quicksight_account_subscription", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryName
    {
        get => new TerraformReference<string>(this, "active_directory_name");
        set => SetArgument("active_directory_name", value);
    }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    public TerraformList<string>? AdminGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "admin_group").ResolveNodes(ctx));
        set => SetArgument("admin_group", value);
    }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    public TerraformList<string>? AdminProGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "admin_pro_group").ResolveNodes(ctx));
        set => SetArgument("admin_pro_group", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMethod is required")]
    public required TerraformValue<string> AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    public TerraformList<string>? AuthorGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "author_group").ResolveNodes(ctx));
        set => SetArgument("author_group", value);
    }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    public TerraformList<string>? AuthorProGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "author_pro_group").ResolveNodes(ctx));
        set => SetArgument("author_pro_group", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    public TerraformValue<string>? ContactNumber
    {
        get => new TerraformReference<string>(this, "contact_number");
        set => SetArgument("contact_number", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Edition is required")]
    public required TerraformValue<string> Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string>? EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamIdentityCenterInstanceArn
    {
        get => new TerraformReference<string>(this, "iam_identity_center_instance_arn");
        set => SetArgument("iam_identity_center_instance_arn", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationEmail is required")]
    public required TerraformValue<string> NotificationEmail
    {
        get => new TerraformReference<string>(this, "notification_email");
        set => SetArgument("notification_email", value);
    }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    public TerraformList<string>? ReaderGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "reader_group").ResolveNodes(ctx));
        set => SetArgument("reader_group", value);
    }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    public TerraformList<string>? ReaderProGroup
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "reader_pro_group").ResolveNodes(ctx));
        set => SetArgument("reader_pro_group", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    public TerraformValue<string>? Realm
    {
        get => new TerraformReference<string>(this, "realm");
        set => SetArgument("realm", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    public TerraformValue<string> AccountSubscriptionStatus
    {
        get => new TerraformReference<string>(this, "account_subscription_status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQuicksightAccountSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQuicksightAccountSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
