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
    public TerraformProperty<string>? EndpointGroupRegion
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_group_region");
        set => this.WithProperty("endpoint_group_region", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("health_check_interval_seconds");
        set => this.WithProperty("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        get => GetProperty<TerraformProperty<string>>("health_check_path");
        set => this.WithProperty("health_check_path", value);
    }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckPort
    {
        get => GetProperty<TerraformProperty<double>>("health_check_port");
        set => this.WithProperty("health_check_port", value);
    }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckProtocol
    {
        get => GetProperty<TerraformProperty<string>>("health_check_protocol");
        set => this.WithProperty("health_check_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ListenerArn
    {
        get => GetProperty<TerraformProperty<string>>("listener_arn");
        set => this.WithProperty("listener_arn", value);
    }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    public TerraformProperty<double>? ThresholdCount
    {
        get => GetProperty<TerraformProperty<double>>("threshold_count");
        set => this.WithProperty("threshold_count", value);
    }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? TrafficDialPercentage
    {
        get => GetProperty<TerraformProperty<double>>("traffic_dial_percentage");
        set => this.WithProperty("traffic_dial_percentage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
