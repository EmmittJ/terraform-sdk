using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lb_hosted_zone_id.
/// </summary>
public partial class AwsLbHostedZoneIdDataSource : TerraformDataSource
{
    public AwsLbHostedZoneIdDataSource(string name) : base("aws_lb_hosted_zone_id", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformProperty("load_balancer_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancerType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
