using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rum_metrics_destination Terraform resource.
/// Manages a aws_rum_metrics_destination resource.
/// </summary>
public partial class AwsRumMetricsDestination(string name) : TerraformResource("aws_rum_metrics_destination", name)
{
    /// <summary>
    /// The app_monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppMonitorName is required")]
    public required TerraformValue<string> AppMonitorName
    {
        get => new TerraformReference<string>(this, "app_monitor_name");
        set => SetArgument("app_monitor_name", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformValue<string>? DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
