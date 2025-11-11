using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerVpcAttachmentOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    [TerraformProperty("appliance_mode_support")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplianceModeSupport { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DnsSupport { get; set; }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    [TerraformProperty("ipv6_support")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Ipv6Support { get; set; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SecurityGroupReferencingSupport { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerVpcAttachmentTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_vpc_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkmanagerVpcAttachment : TerraformResource
{
    public AwsNetworkmanagerVpcAttachment(string name) : base("aws_networkmanager_vpc_attachment", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArns is required")]
    [TerraformProperty("subnet_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetArns { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vpc_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcArn is required")]
    [TerraformProperty("vpc_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcArn { get; set; }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformProperty("options")]
    public partial TerraformList<TerraformBlock<AwsNetworkmanagerVpcAttachmentOptionsBlock>>? Options { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkmanagerVpcAttachmentTimeoutsBlock>? Timeouts { get; set; }

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
    /// The edge_location attribute.
    /// </summary>
    [TerraformProperty("edge_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EdgeLocation { get; }

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
