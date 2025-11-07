using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rum_metrics_destination resource.
/// </summary>
public class AwsRumMetricsDestination : TerraformResource
{
    public AwsRumMetricsDestination(string name) : base("aws_rum_metrics_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_monitor_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppMonitorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_monitor_name");
        set => this.WithProperty("app_monitor_name", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Destination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_arn");
        set => this.WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
