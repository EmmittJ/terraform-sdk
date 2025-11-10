using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_acl_rule resource.
/// </summary>
public class AwsNetworkAclRule : TerraformResource
{
    public AwsNetworkAclRule(string name) : base("aws_network_acl_rule", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CidrBlock { get; set; }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    [TerraformPropertyName("egress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Egress { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FromPort { get; set; }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    [TerraformPropertyName("icmp_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IcmpCode { get; set; }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    [TerraformPropertyName("icmp_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IcmpType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    [TerraformPropertyName("network_acl_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkAclId { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    [TerraformPropertyName("rule_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleAction { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformPropertyName("rule_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RuleNumber { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ToPort { get; set; }

}
