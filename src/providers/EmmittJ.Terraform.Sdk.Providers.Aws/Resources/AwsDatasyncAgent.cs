using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatasyncAgentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datasync_agent resource.
/// </summary>
public partial class AwsDatasyncAgent : TerraformResource
{
    public AwsDatasyncAgent(string name) : base("aws_datasync_agent", name)
    {
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    [TerraformProperty("activation_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ActivationKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The private_link_endpoint attribute.
    /// </summary>
    [TerraformProperty("private_link_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateLinkEndpoint { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    [TerraformProperty("security_group_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupArns { get; set; }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    [TerraformProperty("subnet_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetArns { get; set; }

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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcEndpointId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDatasyncAgentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
