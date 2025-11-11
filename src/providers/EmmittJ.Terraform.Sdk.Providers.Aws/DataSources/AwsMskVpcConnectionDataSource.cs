using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_vpc_connection.
/// </summary>
public partial class AwsMskVpcConnectionDataSource : TerraformDataSource
{
    public AwsMskVpcConnectionDataSource(string name) : base("aws_msk_vpc_connection", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformProperty("authentication")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Authentication { get; }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [TerraformProperty("client_subnets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ClientSubnets { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The target_cluster_arn attribute.
    /// </summary>
    [TerraformProperty("target_cluster_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TargetClusterArn { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
