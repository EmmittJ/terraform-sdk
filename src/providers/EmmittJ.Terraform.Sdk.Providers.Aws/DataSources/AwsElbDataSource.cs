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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessLogs
        => CreateReference("access_logs");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => CreateReference("availability_zones");

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionDraining
        => CreateReference("connection_draining");

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformValue<double> ConnectionDrainingTimeout
        => CreateReference("connection_draining_timeout");

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool> CrossZoneLoadBalancing
        => CreateReference("cross_zone_load_balancing");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string> DesyncMitigationMode
        => CreateReference("desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthCheck
        => CreateReference("health_check");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeout
        => CreateReference("idle_timeout");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformSet<string> Instances
        => CreateReference("instances");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
        => CreateReference("internal");

    /// <summary>
    /// The listener attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Listener
        => CreateReference("listener");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => CreateReference("security_groups");

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroup
        => CreateReference("source_security_group");

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroupId
        => CreateReference("source_security_group_id");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
        => CreateReference("subnets");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => CreateReference("zone_id");

}
