using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elb resource.
/// </summary>
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
    public HashSet<string>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones")?.Value;
        set => this.WithProperty("availability_zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public bool? ConnectionDraining
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("connection_draining")?.Value;
        set => this.WithProperty("connection_draining", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public double? ConnectionDrainingTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("connection_draining_timeout")?.Value;
        set => this.WithProperty("connection_draining_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public bool? CrossZoneLoadBalancing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cross_zone_load_balancing")?.Value;
        set => this.WithProperty("cross_zone_load_balancing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public string? DesyncMitigationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desync_mitigation_mode")?.Value;
        set => this.WithProperty("desync_mitigation_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The idle_timeout attribute.
    /// </summary>
    public double? IdleTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout")?.Value;
        set => this.WithProperty("idle_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public HashSet<string>? Instances
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("instances")?.Value;
        set => this.WithProperty("instances", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public bool? Internal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internal")?.Value;
        set => this.WithProperty("internal", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public string? SourceSecurityGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_security_group")?.Value;
        set => this.WithProperty("source_security_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<string>? Subnets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnets")?.Value;
        set => this.WithProperty("subnets", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
