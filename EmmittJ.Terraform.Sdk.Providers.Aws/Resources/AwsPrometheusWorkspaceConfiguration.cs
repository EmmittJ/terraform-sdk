using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_prometheus_workspace_configuration resource.
/// </summary>
public class AwsPrometheusWorkspaceConfiguration : TerraformResource
{
    public AwsPrometheusWorkspaceConfiguration(string name) : base("aws_prometheus_workspace_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public double? RetentionPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period_in_days")?.Value;
        set => this.WithProperty("retention_period_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
