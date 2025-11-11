using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_security_group_egress_rule resource.
/// </summary>
public partial class AwsVpcSecurityGroupEgressRule : TerraformResource
{
    public AwsVpcSecurityGroupEgressRule(string name) : base("aws_vpc_security_group_egress_rule", name)
    {
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    [TerraformProperty("cidr_ipv4")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CidrIpv4 { get; set; }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    [TerraformProperty("cidr_ipv6")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CidrIpv6 { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FromPort { get; set; }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    [TerraformProperty("ip_protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpProtocol { get; set; }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("prefix_list_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrefixListId { get; set; }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    [TerraformProperty("referenced_security_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReferencedSecurityGroupId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ToPort { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformProperty("security_group_rule_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecurityGroupRuleId { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
