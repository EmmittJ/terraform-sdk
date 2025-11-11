using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsQbusinessApplicationAttachmentsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// Status information about whether file upload functionality is activated or deactivated for your end user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentsControlMode is required")]
    [TerraformProperty("attachments_control_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AttachmentsControlMode { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsQbusinessApplicationEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The identifier of the AWS KMS key that is used to encrypt your data. Amazon Q doesn&#39;t support asymmetric keys.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformProperty("kms_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsQbusinessApplicationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_qbusiness_application resource.
/// </summary>
public partial class AwsQbusinessApplication : TerraformResource
{
    public AwsQbusinessApplication(string name) : base("aws_qbusiness_application", name)
    {
    }

    /// <summary>
    /// A description of the Amazon Q application.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM service role that provides permissions for the Amazon Q application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamServiceRoleArn is required")]
    [TerraformProperty("iam_service_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IamServiceRoleArn { get; set; }

    /// <summary>
    /// ARN of the IAM Identity Center instance you are either creating for—or connecting to—your Amazon Q Business application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityCenterInstanceArn is required")]
    [TerraformProperty("identity_center_instance_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityCenterInstanceArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for attachments_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attachments_configuration")]
    public TerraformList<TerraformBlock<AwsQbusinessApplicationAttachmentsConfigurationBlock>>? AttachmentsConfiguration { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsQbusinessApplicationEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsQbusinessApplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    [TerraformProperty("identity_center_application_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityCenterApplicationArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
