using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elb.
/// </summary>
public class AwsElbDataSource : TerraformDataSource
{
    public AwsElbDataSource(string name) : base("aws_elb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_logs");
        this.WithOutput("arn");
        this.WithOutput("availability_zones");
        this.WithOutput("connection_draining");
        this.WithOutput("connection_draining_timeout");
        this.WithOutput("cross_zone_load_balancing");
        this.WithOutput("desync_mitigation_mode");
        this.WithOutput("dns_name");
        this.WithOutput("health_check");
        this.WithOutput("idle_timeout");
        this.WithOutput("instances");
        this.WithOutput("internal");
        this.WithOutput("listener");
        this.WithOutput("security_groups");
        this.WithOutput("source_security_group");
        this.WithOutput("source_security_group_id");
        this.WithOutput("subnets");
        this.WithOutput("zone_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformExpression AccessLogs => this["access_logs"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformExpression ConnectionDraining => this["connection_draining"];

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformExpression ConnectionDrainingTimeout => this["connection_draining_timeout"];

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformExpression CrossZoneLoadBalancing => this["cross_zone_load_balancing"];

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformExpression DesyncMitigationMode => this["desync_mitigation_mode"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformExpression HealthCheck => this["health_check"];

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformExpression IdleTimeout => this["idle_timeout"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformExpression Internal => this["internal"];

    /// <summary>
    /// The listener attribute.
    /// </summary>
    public TerraformExpression Listener => this["listener"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformExpression SourceSecurityGroup => this["source_security_group"];

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformExpression SourceSecurityGroupId => this["source_security_group_id"];

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformExpression Subnets => this["subnets"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}
