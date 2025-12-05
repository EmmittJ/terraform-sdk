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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryName
    {
        get => GetArgument<TerraformValue<string>>("active_directory_name");
        set => SetArgument("active_directory_name", value);
    }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    public TerraformList<string>? AdminGroup
    {
        get => GetArgument<TerraformList<string>>("admin_group");
        set => SetArgument("admin_group", value);
    }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    public TerraformList<string>? AdminProGroup
    {
        get => GetArgument<TerraformList<string>>("admin_pro_group");
        set => SetArgument("admin_pro_group", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMethod is required")]
    public required TerraformValue<string> AuthenticationMethod
    {
        get => GetRequiredArgument<TerraformValue<string>>("authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    public TerraformList<string>? AuthorGroup
    {
        get => GetArgument<TerraformList<string>>("author_group");
        set => SetArgument("author_group", value);
    }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    public TerraformList<string>? AuthorProGroup
    {
        get => GetArgument<TerraformList<string>>("author_pro_group");
        set => SetArgument("author_pro_group", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? CreateReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    public TerraformValue<string>? ContactNumber
    {
        get => GetArgument<TerraformValue<string>>("contact_number");
        set => SetArgument("contact_number", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryId
    {
        get => GetArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Edition is required")]
    public required TerraformValue<string> Edition
    {
        get => GetRequiredArgument<TerraformValue<string>>("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string>? EmailAddress
    {
        get => GetArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamIdentityCenterInstanceArn
    {
        get => GetArgument<TerraformValue<string>>("iam_identity_center_instance_arn");
        set => SetArgument("iam_identity_center_instance_arn", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationEmail is required")]
    public required TerraformValue<string> NotificationEmail
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_email");
        set => SetArgument("notification_email", value);
    }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    public TerraformList<string>? ReaderGroup
    {
        get => GetArgument<TerraformList<string>>("reader_group");
        set => SetArgument("reader_group", value);
    }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    public TerraformList<string>? ReaderProGroup
    {
        get => GetArgument<TerraformList<string>>("reader_pro_group");
        set => SetArgument("reader_pro_group", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    public TerraformValue<string>? Realm
    {
        get => GetArgument<TerraformValue<string>>("realm");
        set => SetArgument("realm", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    public TerraformValue<string> AccountSubscriptionStatus
        => CreateReference("account_subscription_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQuicksightAccountSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQuicksightAccountSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
