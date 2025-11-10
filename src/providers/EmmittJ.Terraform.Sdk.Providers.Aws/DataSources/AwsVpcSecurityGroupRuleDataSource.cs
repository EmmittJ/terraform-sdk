using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcSecurityGroupRuleDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_rule_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecurityGroupRuleId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_rule_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcSecurityGroupRuleDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CidrIpv4 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_ipv4");

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_ipv6")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CidrIpv6 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_ipv6");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FromPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "from_port");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [TerraformPropertyName("ip_protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpProtocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_protocol");

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    [TerraformPropertyName("is_egress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsEgress => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_egress");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrefixListId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prefix_list_id");

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("referenced_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReferencedSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "referenced_security_group_id");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ToPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "to_port");

}
