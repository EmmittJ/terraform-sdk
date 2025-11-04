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
        this.DeclareOutput("dashboard_arn");
    }

    /// <summary>
    /// The dashboard_body attribute.
    /// </summary>
    public string? DashboardBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dashboard_body")?.Value;
        set => this.WithProperty("dashboard_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dashboard_name attribute.
    /// </summary>
    public string? DashboardName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dashboard_name")?.Value;
        set => this.WithProperty("dashboard_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dashboard_arn attribute.
    /// </summary>
    public TerraformExpression DashboardArn => this["dashboard_arn"];

}
