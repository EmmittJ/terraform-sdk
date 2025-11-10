using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsElbAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        set => SetProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        set => SetProperty("interval", value);
    }

}

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsElbHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthyThreshold is required")]
    public required TerraformProperty<double> HealthyThreshold
    {
        set => SetProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<double> Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformProperty<double> UnhealthyThreshold
    {
        set => SetProperty("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for listener in .
/// Nesting mode: set
/// </summary>
public class AwsElbListenerBlock : TerraformBlock
{
    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    public required TerraformProperty<double> InstancePort
    {
        set => SetProperty("instance_port", value);
    }

    /// <summary>
    /// The instance_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProtocol is required")]
    public required TerraformProperty<string> InstanceProtocol
    {
        set => SetProperty("instance_protocol", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformProperty<double> LbPort
    {
        set => SetProperty("lb_port", value);
    }

    /// <summary>
    /// The lb_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbProtocol is required")]
    public required TerraformProperty<string> LbProtocol
    {
        set => SetProperty("lb_protocol", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateId
    {
        set => SetProperty("ssl_certificate_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElbTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_elb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElb : TerraformResource
{
    public AwsElb(string name) : base("aws_elb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("source_security_group_id");
        SetOutput("zone_id");
        SetOutput("availability_zones");
        SetOutput("connection_draining");
        SetOutput("connection_draining_timeout");
        SetOutput("cross_zone_load_balancing");
        SetOutput("desync_mitigation_mode");
        SetOutput("id");
        SetOutput("idle_timeout");
        SetOutput("instances");
        SetOutput("internal");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("security_groups");
        SetOutput("source_security_group");
        SetOutput("subnets");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AvailabilityZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("availability_zones");
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformProperty<bool> ConnectionDraining
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("connection_draining");
        set => SetProperty("connection_draining", value);
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformProperty<double> ConnectionDrainingTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("connection_draining_timeout");
        set => SetProperty("connection_draining_timeout", value);
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformProperty<bool> CrossZoneLoadBalancing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cross_zone_load_balancing");
        set => SetProperty("cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformProperty<string> DesyncMitigationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desync_mitigation_mode");
        set => SetProperty("desync_mitigation_mode", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformProperty<double> IdleTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_timeout");
        set => SetProperty("idle_timeout", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Instances
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("instances");
        set => SetProperty("instances", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformProperty<bool> Internal
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internal");
        set => SetProperty("internal", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformProperty<string> SourceSecurityGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_security_group");
        set => SetProperty("source_security_group", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Subnets
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnets");
        set => SetProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsElbAccessLogsBlock>? AccessLogs
    {
        set => SetProperty("access_logs", value);
    }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public List<AwsElbHealthCheckBlock>? HealthCheck
    {
        set => SetProperty("health_check", value);
    }

    /// <summary>
    /// Block for listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Listener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    public HashSet<AwsElbListenerBlock>? Listener
    {
        set => SetProperty("listener", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElbTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformExpression SourceSecurityGroupId => this["source_security_group_id"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}
