using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSecurityGroupRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_security_group_rule resource.
/// </summary>
public partial class AwsSecurityGroupRule : TerraformResource
{
    public AwsSecurityGroupRule(string name) : base("aws_security_group_rule", name)
    {
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CidrBlocks { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    [TerraformProperty("prefix_list_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PrefixListIds { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    [TerraformProperty("security_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityGroupId { get; set; }

    /// <summary>
    /// The self attribute.
    /// </summary>
    [TerraformProperty("self")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Self { get; set; }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformProperty("source_security_group_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceSecurityGroupId { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSecurityGroupRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformProperty("security_group_rule_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupRuleId { get; }

}
