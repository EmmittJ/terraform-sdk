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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformPropertyName("access_logs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccessLogs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "access_logs");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConnectionDraining => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "connection_draining");

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining_timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ConnectionDrainingTimeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "connection_draining_timeout");

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("cross_zone_load_balancing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CrossZoneLoadBalancing => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "cross_zone_load_balancing");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DesyncMitigationMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformPropertyName("health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "health_check");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleTimeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_timeout");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Instances => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "instances");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Internal => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internal");

    /// <summary>
    /// The listener attribute.
    /// </summary>
    [TerraformPropertyName("listener")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Listener => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "listener");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceSecurityGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_security_group");

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_security_group_id");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Subnets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnets");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

}
