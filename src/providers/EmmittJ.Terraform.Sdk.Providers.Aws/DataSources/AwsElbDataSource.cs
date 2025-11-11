using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elb.
/// </summary>
public class AwsElbDataSource : TerraformDataSource
{
    public AwsElbDataSource(string name) : base("aws_elb", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformPropertyName("access_logs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccessLogs => new TerraformReference(this, "access_logs");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConnectionDraining => new TerraformReference(this, "connection_draining");

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining_timeout")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ConnectionDrainingTimeout => new TerraformReference(this, "connection_draining_timeout");

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("cross_zone_load_balancing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CrossZoneLoadBalancing => new TerraformReference(this, "cross_zone_load_balancing");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesyncMitigationMode => new TerraformReference(this, "desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformPropertyName("health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HealthCheck => new TerraformReference(this, "health_check");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleTimeout => new TerraformReference(this, "idle_timeout");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Instances => new TerraformReference(this, "instances");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Internal => new TerraformReference(this, "internal");

    /// <summary>
    /// The listener attribute.
    /// </summary>
    [TerraformPropertyName("listener")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Listener => new TerraformReference(this, "listener");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceSecurityGroup => new TerraformReference(this, "source_security_group");

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceSecurityGroupId => new TerraformReference(this, "source_security_group_id");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Subnets => new TerraformReference(this, "subnets");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneId => new TerraformReference(this, "zone_id");

}
