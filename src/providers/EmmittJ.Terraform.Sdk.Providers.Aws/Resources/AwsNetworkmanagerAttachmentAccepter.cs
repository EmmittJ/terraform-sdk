using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerAttachmentAccepterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_attachment_accepter resource.
/// </summary>
public partial class AwsNetworkmanagerAttachmentAccepter : TerraformResource
{
    public AwsNetworkmanagerAttachmentAccepter(string name) : base("aws_networkmanager_attachment_accepter", name)
    {
    }

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentId is required")]
    [TerraformProperty("attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttachmentId { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformProperty("attachment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttachmentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkmanagerAttachmentAccepterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    [TerraformProperty("attachment_policy_rule_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AttachmentPolicyRuleNumber { get; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkArn { get; }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [TerraformProperty("core_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkId { get; }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformProperty("edge_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EdgeLocation { get; }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [TerraformProperty("edge_locations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> EdgeLocations { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAccountId { get; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceArn { get; }

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    [TerraformProperty("segment_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SegmentName { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
