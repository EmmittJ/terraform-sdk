using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elb.
/// </summary>
public partial class AwsElbDataSource : TerraformDataSource
{
    public AwsElbDataSource(string name) : base("aws_elb", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformProperty("access_logs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AccessLogs { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AvailabilityZones { get; }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    [TerraformProperty("connection_draining")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ConnectionDraining { get; }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    [TerraformProperty("connection_draining_timeout")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ConnectionDrainingTimeout { get; }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformProperty("cross_zone_load_balancing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CrossZoneLoadBalancing { get; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformProperty("desync_mitigation_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DesyncMitigationMode { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformProperty("health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthCheck { get; }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> IdleTimeout { get; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Instances { get; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformProperty("internal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Internal { get; }

    /// <summary>
    /// The listener attribute.
    /// </summary>
    [TerraformProperty("listener")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Listener { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    [TerraformProperty("source_security_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceSecurityGroup { get; }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformProperty("source_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceSecurityGroupId { get; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Subnets { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZoneId { get; }

}
