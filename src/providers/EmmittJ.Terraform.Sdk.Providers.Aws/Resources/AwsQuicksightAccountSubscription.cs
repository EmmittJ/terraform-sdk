using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsQuicksightAccountSubscriptionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public partial class AwsQuicksightAccountSubscription : TerraformResource
{
    public AwsQuicksightAccountSubscription(string name) : base("aws_quicksight_account_subscription", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    [TerraformProperty("active_directory_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectoryName { get; set; }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    [TerraformProperty("admin_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminGroup { get; set; }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    [TerraformProperty("admin_pro_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminProGroup { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMethod is required")]
    [TerraformProperty("authentication_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationMethod { get; set; }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    [TerraformProperty("author_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AuthorGroup { get; set; }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    [TerraformProperty("author_pro_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AuthorProGroup { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    [TerraformProperty("contact_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContactNumber { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformProperty("directory_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryId { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Edition is required")]
    [TerraformProperty("edition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Edition { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformProperty("email_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmailAddress { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    [TerraformProperty("iam_identity_center_instance_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamIdentityCenterInstanceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationEmail is required")]
    [TerraformProperty("notification_email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NotificationEmail { get; set; }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    [TerraformProperty("reader_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ReaderGroup { get; set; }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    [TerraformProperty("reader_pro_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ReaderProGroup { get; set; }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [TerraformProperty("realm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Realm { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsQuicksightAccountSubscriptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    [TerraformProperty("account_subscription_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccountSubscriptionStatus { get; }

}
