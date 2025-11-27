using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_query_log Terraform resource.
/// Manages a aws_route53_query_log resource.
/// </summary>
public partial class AwsRoute53QueryLog(string name) : TerraformResource("aws_route53_query_log", name)
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    public required TerraformValue<string> CloudwatchLogGroupArn
    {
        get => new TerraformReference<string>(this, "cloudwatch_log_group_arn");
        set => SetArgument("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
