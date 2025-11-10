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
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        get => GetProperty<TerraformProperty<string>>("bucket_prefix");
        set => WithProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
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
        get => GetProperty<TerraformProperty<double>>("healthy_threshold");
        set => WithProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<double> Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => WithProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformProperty<double> UnhealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_threshold");
        set => WithProperty("unhealthy_threshold", value);
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
        get => GetProperty<TerraformProperty<double>>("instance_port");
        set => WithProperty("instance_port", value);
    }

    /// <summary>
    /// The instance_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProtocol is required")]
    public required TerraformProperty<string> InstanceProtocol
    {
        get => GetProperty<TerraformProperty<string>>("instance_protocol");
        set => WithProperty("instance_protocol", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformProperty<double> LbPort
    {
        get => GetProperty<TerraformProperty<double>>("lb_port");
        set => WithProperty("lb_port", value);
    }

    /// <summary>
    /// The lb_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbProtocol is required")]
    public required TerraformProperty<string> LbProtocol
    {
        get => GetProperty<TerraformProperty<string>>("lb_protocol");
        set => WithProperty("lb_protocol", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_certificate_id");
        set => WithProperty("ssl_certificate_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("source_security_group_id");
        this.DeclareOutput("zone_id");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformProperty<bool>? ConnectionDraining
    {
        get => GetProperty<TerraformProperty<bool>>("connection_draining");
        set => this.WithProperty("connection_draining", value);
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ConnectionDrainingTimeout
    {
        get => GetProperty<TerraformProperty<double>>("connection_draining_timeout");
        set => this.WithProperty("connection_draining_timeout", value);
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossZoneLoadBalancing
    {
        get => GetProperty<TerraformProperty<bool>>("cross_zone_load_balancing");
        set => this.WithProperty("cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DesyncMitigationMode
    {
        get => GetProperty<TerraformProperty<string>>("desync_mitigation_mode");
        set => this.WithProperty("desync_mitigation_mode", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeout
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout");
        set => this.WithProperty("idle_timeout", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Instances
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformProperty<bool>? Internal
    {
        get => GetProperty<TerraformProperty<bool>>("internal");
        set => this.WithProperty("internal", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? SourceSecurityGroup
    {
        get => GetProperty<TerraformProperty<string>>("source_security_group");
        set => this.WithProperty("source_security_group", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => this.WithProperty("subnets", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsElbAccessLogsBlock>? AccessLogs
    {
        get => GetProperty<List<AwsElbAccessLogsBlock>>("access_logs");
        set => this.WithProperty("access_logs", value);
    }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public List<AwsElbHealthCheckBlock>? HealthCheck
    {
        get => GetProperty<List<AwsElbHealthCheckBlock>>("health_check");
        set => this.WithProperty("health_check", value);
    }

    /// <summary>
    /// Block for listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    public HashSet<AwsElbListenerBlock>? Listener
    {
        get => GetProperty<HashSet<AwsElbListenerBlock>>("listener");
        set => this.WithProperty("listener", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElbTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElbTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
