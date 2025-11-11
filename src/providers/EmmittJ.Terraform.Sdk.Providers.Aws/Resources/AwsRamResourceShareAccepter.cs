using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRamResourceShareAccepterTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_ram_resource_share_accepter resource.
/// </summary>
public partial class AwsRamResourceShareAccepter : TerraformResource
{
    public AwsRamResourceShareAccepter(string name) : base("aws_ram_resource_share_accepter", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareArn is required")]
    [TerraformProperty("share_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRamResourceShareAccepterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The invitation_arn attribute.
    /// </summary>
    [TerraformProperty("invitation_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvitationArn { get; }

    /// <summary>
    /// The receiver_account_id attribute.
    /// </summary>
    [TerraformProperty("receiver_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReceiverAccountId { get; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Resources { get; }

    /// <summary>
    /// The sender_account_id attribute.
    /// </summary>
    [TerraformProperty("sender_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SenderAccountId { get; }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [TerraformProperty("share_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ShareId { get; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [TerraformProperty("share_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ShareName { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
