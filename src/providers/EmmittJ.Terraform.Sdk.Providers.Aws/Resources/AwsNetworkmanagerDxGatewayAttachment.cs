using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerDxGatewayAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_dx_gateway_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerDxGatewayAttachment : TerraformResource
{
    public AwsNetworkmanagerDxGatewayAttachment(string name) : base("aws_networkmanager_dx_gateway_attachment", name)
    {
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    [TerraformProperty("core_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CoreNetworkId { get; set; }

    /// <summary>
    /// The direct_connect_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectConnectGatewayArn is required")]
    [TerraformProperty("direct_connect_gateway_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectConnectGatewayArn { get; set; }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeLocations is required")]
    [TerraformProperty("edge_locations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? EdgeLocations { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNetworkmanagerDxGatewayAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    [TerraformProperty("attachment_policy_rule_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AttachmentPolicyRuleNumber { get; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [TerraformProperty("attachment_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AttachmentType { get; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkArn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAccountId { get; }

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

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
