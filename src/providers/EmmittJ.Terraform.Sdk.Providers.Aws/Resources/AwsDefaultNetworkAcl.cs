using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for egress in .
/// Nesting mode: set
/// </summary>
public partial class AwsDefaultNetworkAclEgressBlock() : TerraformBlock("egress")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CidrBlock { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    [TerraformProperty("rule_no")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RuleNo { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: set
/// </summary>
public partial class AwsDefaultNetworkAclIngressBlock() : TerraformBlock("ingress")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CidrBlock { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    [TerraformProperty("rule_no")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RuleNo { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Manages a aws_default_network_acl resource.
/// </summary>
public partial class AwsDefaultNetworkAcl : TerraformResource
{
    public AwsDefaultNetworkAcl(string name) : base("aws_default_network_acl", name)
    {
    }

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNetworkAclId is required")]
    [TerraformProperty("default_network_acl_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultNetworkAclId { get; set; }

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
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

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
    /// Block for egress.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("egress")]
    public TerraformSet<AwsDefaultNetworkAclEgressBlock> Egress { get; set; } = new();

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ingress")]
    public TerraformSet<AwsDefaultNetworkAclIngressBlock> Ingress { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
