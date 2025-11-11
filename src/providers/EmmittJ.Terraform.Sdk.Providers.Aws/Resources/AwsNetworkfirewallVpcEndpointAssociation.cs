using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_vpc_endpoint_association resource.
/// </summary>
public partial class AwsNetworkfirewallVpcEndpointAssociation : TerraformResource
{
    public AwsNetworkfirewallVpcEndpointAssociation(string name) : base("aws_networkfirewall_vpc_endpoint_association", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    [TerraformProperty("firewall_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FirewallArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("subnet_mapping")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>>? SubnetMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The vpc_endpoint_association_arn attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_association_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcEndpointAssociationArn { get; }

    /// <summary>
    /// The vpc_endpoint_association_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcEndpointAssociationId { get; }

    /// <summary>
    /// The vpc_endpoint_association_status attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_association_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VpcEndpointAssociationStatus { get; }

}
