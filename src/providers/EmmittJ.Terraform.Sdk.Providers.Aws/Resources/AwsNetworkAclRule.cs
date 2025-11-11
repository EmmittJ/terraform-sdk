using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_acl_rule resource.
/// </summary>
public partial class AwsNetworkAclRule : TerraformResource
{
    public AwsNetworkAclRule(string name) : base("aws_network_acl_rule", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CidrBlock { get; set; }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    [TerraformProperty("egress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Egress { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FromPort { get; set; }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    [TerraformProperty("icmp_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IcmpCode { get; set; }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    [TerraformProperty("icmp_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IcmpType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    [TerraformProperty("network_acl_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkAclId { get; set; }

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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    [TerraformProperty("rule_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleAction { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformProperty("rule_number")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RuleNumber { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ToPort { get; set; }

}
