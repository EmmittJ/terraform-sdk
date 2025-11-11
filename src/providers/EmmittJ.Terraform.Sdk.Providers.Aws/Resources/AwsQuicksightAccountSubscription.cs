using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAccountSubscriptionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public class AwsQuicksightAccountSubscription : TerraformResource
{
    public AwsQuicksightAccountSubscription(string name) : base("aws_quicksight_account_subscription", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ActiveDirectoryName { get; set; }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    [TerraformPropertyName("admin_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdminGroup { get; set; }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    [TerraformPropertyName("admin_pro_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdminProGroup { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMethod is required")]
    [TerraformPropertyName("authentication_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthenticationMethod { get; set; }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    [TerraformPropertyName("author_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AuthorGroup { get; set; }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    [TerraformPropertyName("author_pro_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AuthorProGroup { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    [TerraformPropertyName("contact_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContactNumber { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DirectoryId { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Edition is required")]
    [TerraformPropertyName("edition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Edition { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformPropertyName("email_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmailAddress { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_identity_center_instance_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamIdentityCenterInstanceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationEmail is required")]
    [TerraformPropertyName("notification_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NotificationEmail { get; set; }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    [TerraformPropertyName("reader_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ReaderGroup { get; set; }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    [TerraformPropertyName("reader_pro_group")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ReaderProGroup { get; set; }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [TerraformPropertyName("realm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Realm { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsQuicksightAccountSubscriptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    [TerraformPropertyName("account_subscription_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountSubscriptionStatus => new TerraformReference(this, "account_subscription_status");

}
