using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcSecurityGroupRuleDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_security_group_rule.
/// </summary>
public class AwsVpcSecurityGroupRuleDataSource : TerraformDataSource
{
    public AwsVpcSecurityGroupRuleDataSource(string name) : base("aws_vpc_security_group_rule", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_rule_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityGroupRuleId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcSecurityGroupRuleDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CidrIpv4 => new TerraformReference(this, "cidr_ipv4");

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv6")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CidrIpv6 => new TerraformReference(this, "cidr_ipv6");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FromPort => new TerraformReference(this, "from_port");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [TerraformPropertyName("ip_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpProtocol => new TerraformReference(this, "ip_protocol");

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    [TerraformPropertyName("is_egress")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsEgress => new TerraformReference(this, "is_egress");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrefixListId => new TerraformReference(this, "prefix_list_id");

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("referenced_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReferencedSecurityGroupId => new TerraformReference(this, "referenced_security_group_id");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupId => new TerraformReference(this, "security_group_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ToPort => new TerraformReference(this, "to_port");

}
