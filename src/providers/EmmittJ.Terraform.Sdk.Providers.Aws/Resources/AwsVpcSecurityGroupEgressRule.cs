using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_security_group_egress_rule resource.
/// </summary>
public class AwsVpcSecurityGroupEgressRule : TerraformResource
{
    public AwsVpcSecurityGroupEgressRule(string name) : base("aws_vpc_security_group_egress_rule", name)
    {
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CidrIpv4 { get; set; }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CidrIpv6 { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FromPort { get; set; }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    [TerraformPropertyName("ip_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpProtocol { get; set; }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrefixListId { get; set; }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("referenced_security_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReferencedSecurityGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    [TerraformPropertyName("security_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityGroupId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ToPort { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_rule_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupRuleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_rule_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
