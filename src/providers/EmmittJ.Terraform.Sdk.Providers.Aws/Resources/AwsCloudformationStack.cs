using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackTimeoutsBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack resource.
/// </summary>
public class AwsCloudformationStack : TerraformResource
{
    public AwsCloudformationStack(string name) : base("aws_cloudformation_stack", name)
    {
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformPropertyName("capabilities")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Capabilities { get; set; }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    [TerraformPropertyName("disable_rollback")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableRollback { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformPropertyName("notification_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NotificationArns { get; set; }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformPropertyName("on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OnFailure { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Parameters { get; set; } = default!;

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    [TerraformPropertyName("policy_body")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PolicyBody { get; set; } = default!;

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    [TerraformPropertyName("policy_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformPropertyName("template_body")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TemplateBody { get; set; } = default!;

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformPropertyName("template_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateUrl { get; set; }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInMinutes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudformationStackTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformPropertyName("outputs")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Outputs => new TerraformReference(this, "outputs");

}
