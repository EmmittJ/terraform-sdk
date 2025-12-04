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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
