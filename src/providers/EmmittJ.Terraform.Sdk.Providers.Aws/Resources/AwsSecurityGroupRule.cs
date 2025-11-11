using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSecurityGroupRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_security_group_rule resource.
/// </summary>
public class AwsSecurityGroupRule : TerraformResource
{
    public AwsSecurityGroupRule(string name) : base("aws_security_group_rule", name)
    {
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CidrBlocks { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Ipv6CidrBlocks { get; set; }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PrefixListIds { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    [TerraformPropertyName("security_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecurityGroupId { get; set; }

    /// <summary>
    /// The self attribute.
    /// </summary>
    [TerraformPropertyName("self")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Self { get; set; }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SourceSecurityGroupId { get; set; } = default!;

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ToPort { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSecurityGroupRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_rule_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupRuleId => new TerraformReference(this, "security_group_rule_id");

}
