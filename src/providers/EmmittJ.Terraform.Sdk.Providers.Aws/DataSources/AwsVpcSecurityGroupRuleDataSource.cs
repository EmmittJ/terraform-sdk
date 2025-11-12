using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcSecurityGroupRuleDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_security_group_rule.
/// </summary>
public partial class AwsVpcSecurityGroupRuleDataSource : TerraformDataSource
{
    public AwsVpcSecurityGroupRuleDataSource(string name) : base("aws_vpc_security_group_rule", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformProperty("security_group_rule_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityGroupRuleId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    [TerraformProperty("cidr_ipv4")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CidrIpv4 { get; }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    [TerraformProperty("cidr_ipv6")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CidrIpv6 { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> FromPort { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [TerraformProperty("ip_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpProtocol { get; }

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    [TerraformProperty("is_egress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsEgress { get; }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("prefix_list_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrefixListId { get; }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    [TerraformProperty("referenced_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReferencedSecurityGroupId { get; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformProperty("security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ToPort { get; }

}
