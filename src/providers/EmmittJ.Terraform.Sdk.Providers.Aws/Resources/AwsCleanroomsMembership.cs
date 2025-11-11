using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_result_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCleanroomsMembershipDefaultResultConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

}

/// <summary>
/// Block type for payment_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCleanroomsMembershipPaymentConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public partial class AwsCleanroomsMembership : TerraformResource
{
    public AwsCleanroomsMembership(string name) : base("aws_cleanrooms_membership", name)
    {
    }

    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationId is required")]
    [TerraformProperty("collaboration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollaborationId { get; set; }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    [TerraformProperty("query_log_status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryLogStatus { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for default_result_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("default_result_configuration")]
    public partial TerraformList<TerraformBlock<AwsCleanroomsMembershipDefaultResultConfigurationBlock>>? DefaultResultConfiguration { get; set; }

    /// <summary>
    /// Block for payment_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("payment_configuration")]
    public partial TerraformList<TerraformBlock<AwsCleanroomsMembershipPaymentConfigurationBlock>>? PaymentConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    [TerraformProperty("collaboration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollaborationArn { get; }

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    [TerraformProperty("collaboration_creator_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollaborationCreatorAccountId { get; }

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    [TerraformProperty("collaboration_creator_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollaborationCreatorDisplayName { get; }

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    [TerraformProperty("collaboration_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollaborationName { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [TerraformProperty("member_abilities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> MemberAbilities { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
