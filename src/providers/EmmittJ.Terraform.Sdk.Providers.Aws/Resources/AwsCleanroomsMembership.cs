using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_result_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

}

/// <summary>
/// Block type for payment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipPaymentConfigurationBlock
{
}

/// <summary>
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public class AwsCleanroomsMembership : TerraformResource
{
    public AwsCleanroomsMembership(string name) : base("aws_cleanrooms_membership", name)
    {
    }

    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationId is required")]
    [TerraformPropertyName("collaboration_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CollaborationId { get; set; }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    [TerraformPropertyName("query_log_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueryLogStatus { get; set; }

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
    /// Block for default_result_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("default_result_configuration")]
    public TerraformList<TerraformBlock<AwsCleanroomsMembershipDefaultResultConfigurationBlock>>? DefaultResultConfiguration { get; set; }

    /// <summary>
    /// Block for payment_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("payment_configuration")]
    public TerraformList<TerraformBlock<AwsCleanroomsMembershipPaymentConfigurationBlock>>? PaymentConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CollaborationArn => new TerraformReference(this, "collaboration_arn");

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_creator_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CollaborationCreatorAccountId => new TerraformReference(this, "collaboration_creator_account_id");

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_creator_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CollaborationCreatorDisplayName => new TerraformReference(this, "collaboration_creator_display_name");

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CollaborationName => new TerraformReference(this, "collaboration_name");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [TerraformPropertyName("member_abilities")]
    // Output-only attribute - read-only reference
    public TerraformList<string> MemberAbilities => new TerraformReference(this, "member_abilities");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
