using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_member resource.
/// </summary>
public partial class AwsDetectiveMember : TerraformResource
{
    public AwsDetectiveMember(string name) : base("aws_detective_member", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    [TerraformProperty("disable_email_notification")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableEmailNotification { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformProperty("email_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    [TerraformProperty("graph_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GraphArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The administrator_id attribute.
    /// </summary>
    [TerraformProperty("administrator_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorId { get; }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformProperty("disabled_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisabledReason { get; }

    /// <summary>
    /// The invited_time attribute.
    /// </summary>
    [TerraformProperty("invited_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvitedTime { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_time attribute.
    /// </summary>
    [TerraformProperty("updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedTime { get; }

    /// <summary>
    /// The volume_usage_in_bytes attribute.
    /// </summary>
    [TerraformProperty("volume_usage_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeUsageInBytes { get; }

}
