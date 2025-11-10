using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for minimum_healthy_hosts in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<double>? Value
    {
        get => GetProperty<TerraformProperty<double>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for traffic_routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for zonal_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigZonalConfigBlock : TerraformBlock
{
    /// <summary>
    /// The first_zone_monitor_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? FirstZoneMonitorDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("first_zone_monitor_duration_in_seconds");
        set => WithProperty("first_zone_monitor_duration_in_seconds", value);
    }

    /// <summary>
    /// The monitor_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MonitorDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("monitor_duration_in_seconds");
        set => WithProperty("monitor_duration_in_seconds", value);
    }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodedeployDeploymentConfig : TerraformResource
{
    public AwsCodedeployDeploymentConfig(string name) : base("aws_codedeploy_deployment_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("deployment_config_id");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformProperty<string>? ComputePlatform
    {
        get => GetProperty<TerraformProperty<string>>("compute_platform");
        set => this.WithProperty("compute_platform", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentConfigName is required")]
    public required TerraformProperty<string> DeploymentConfigName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("deployment_config_name");
        set => this.WithProperty("deployment_config_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for minimum_healthy_hosts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHosts block(s) allowed")]
    public List<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>? MinimumHealthyHosts
    {
        get => GetProperty<List<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>>("minimum_healthy_hosts");
        set => this.WithProperty("minimum_healthy_hosts", value);
    }

    /// <summary>
    /// Block for traffic_routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfig block(s) allowed")]
    public List<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>? TrafficRoutingConfig
    {
        get => GetProperty<List<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>>("traffic_routing_config");
        set => this.WithProperty("traffic_routing_config", value);
    }

    /// <summary>
    /// Block for zonal_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalConfig block(s) allowed")]
    public List<AwsCodedeployDeploymentConfigZonalConfigBlock>? ZonalConfig
    {
        get => GetProperty<List<AwsCodedeployDeploymentConfigZonalConfigBlock>>("zonal_config");
        set => this.WithProperty("zonal_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    public TerraformExpression DeploymentConfigId => this["deployment_config_id"];

}
