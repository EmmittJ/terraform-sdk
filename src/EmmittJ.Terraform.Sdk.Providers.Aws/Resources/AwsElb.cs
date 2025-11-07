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
    public TerraformLiteralProperty<HashSet<string>>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ConnectionDraining
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("connection_draining");
        set => this.WithProperty("connection_draining", value);
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ConnectionDrainingTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("connection_draining_timeout");
        set => this.WithProperty("connection_draining_timeout", value);
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CrossZoneLoadBalancing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cross_zone_load_balancing");
        set => this.WithProperty("cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DesyncMitigationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desync_mitigation_mode");
        set => this.WithProperty("desync_mitigation_mode", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdleTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout");
        set => this.WithProperty("idle_timeout", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Instances
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Internal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internal");
        set => this.WithProperty("internal", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceSecurityGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_security_group");
        set => this.WithProperty("source_security_group", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Subnets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnets");
        set => this.WithProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
