using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lb_hosted_zone_id Terraform data source.
/// Retrieves information about a aws_lb_hosted_zone_id.
/// </summary>
public partial class AwsLbHostedZoneIdDataSource(string name) : TerraformDataSource("aws_lb_hosted_zone_id", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
