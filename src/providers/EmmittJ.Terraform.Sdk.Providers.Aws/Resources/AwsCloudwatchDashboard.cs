using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_dashboard resource.
/// </summary>
public class AwsCloudwatchDashboard : TerraformResource
{
    public AwsCloudwatchDashboard(string name) : base("aws_cloudwatch_dashboard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dashboard_arn");
        SetOutput("dashboard_body");
        SetOutput("dashboard_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The dashboard_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardBody is required")]
    public required TerraformProperty<string> DashboardBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dashboard_body");
        set => SetProperty("dashboard_body", value);
    }

    /// <summary>
    /// The dashboard_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardName is required")]
    public required TerraformProperty<string> DashboardName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dashboard_name");
        set => SetProperty("dashboard_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The dashboard_arn attribute.
    /// </summary>
    public TerraformExpression DashboardArn => this["dashboard_arn"];

}
