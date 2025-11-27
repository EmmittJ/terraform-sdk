using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elb Terraform data source.
/// Retrieves information about a aws_elb.
/// </summary>
public partial class AwsElbDataSource(string name) : TerraformDataSource("aws_elb", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessLogs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_logs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionDraining
    {
        get => new TerraformReference<bool>(this, "connection_draining");
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformValue<double> ConnectionDrainingTimeout
    {
        get => new TerraformReference<double>(this, "connection_draining_timeout");
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool> CrossZoneLoadBalancing
    {
        get => new TerraformReference<bool>(this, "cross_zone_load_balancing");
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string> DesyncMitigationMode
    {
        get => new TerraformReference<string>(this, "desync_mitigation_mode");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheck
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "health_check").ResolveNodes(ctx));
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeout
    {
        get => new TerraformReference<double>(this, "idle_timeout");
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformSet<string> Instances
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instances").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
    {
        get => new TerraformReference<bool>(this, "internal");
    }

    /// <summary>
    /// The listener attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Listener
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "listener").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroup
    {
        get => new TerraformReference<string>(this, "source_security_group");
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroupId
    {
        get => new TerraformReference<string>(this, "source_security_group_id");
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
    }

}
