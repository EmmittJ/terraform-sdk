using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_globalaccelerator_endpoint_group resource.
/// </summary>
public class AwsGlobalacceleratorEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorEndpointGroup(string name) : base("aws_globalaccelerator_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public string? EndpointGroupRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_group_region")?.Value;
        set => this.WithProperty("endpoint_group_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public double? HealthCheckIntervalSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_interval_seconds")?.Value;
        set => this.WithProperty("health_check_interval_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public string? HealthCheckPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_path")?.Value;
        set => this.WithProperty("health_check_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    public double? HealthCheckPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_port")?.Value;
        set => this.WithProperty("health_check_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    public string? HealthCheckProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_protocol")?.Value;
        set => this.WithProperty("health_check_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The listener_arn attribute.
    /// </summary>
    public string? ListenerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("listener_arn")?.Value;
        set => this.WithProperty("listener_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    public double? ThresholdCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("threshold_count")?.Value;
        set => this.WithProperty("threshold_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    public double? TrafficDialPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("traffic_dial_percentage")?.Value;
        set => this.WithProperty("traffic_dial_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
