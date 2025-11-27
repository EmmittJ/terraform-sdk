using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_dashboard Terraform resource.
/// Manages a aws_cloudwatch_dashboard resource.
/// </summary>
public partial class AwsCloudwatchDashboard(string name) : TerraformResource("aws_cloudwatch_dashboard", name)
{
    /// <summary>
    /// The dashboard_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardBody is required")]
    public required TerraformValue<string> DashboardBody
    {
        get => new TerraformReference<string>(this, "dashboard_body");
        set => SetArgument("dashboard_body", value);
    }

    /// <summary>
    /// The dashboard_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardName is required")]
    public required TerraformValue<string> DashboardName
    {
        get => new TerraformReference<string>(this, "dashboard_name");
        set => SetArgument("dashboard_name", value);
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

    /// <summary>
    /// The dashboard_arn attribute.
    /// </summary>
    public TerraformValue<string> DashboardArn
    {
        get => new TerraformReference<string>(this, "dashboard_arn");
    }

}
