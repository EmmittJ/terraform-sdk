using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_record_set in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlock : TerraformBlock
{
    /// <summary>
    /// The failover attribute.
    /// </summary>
    public TerraformProperty<string>? Failover
    {
        get => GetProperty<TerraformProperty<string>>("failover");
        set => WithProperty("failover", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckId
    {
        get => GetProperty<TerraformProperty<string>>("health_check_id");
        set => WithProperty("health_check_id", value);
    }

    /// <summary>
    /// The multi_value_answer attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiValueAnswer
    {
        get => GetProperty<TerraformProperty<bool>>("multi_value_answer");
        set => WithProperty("multi_value_answer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SetIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("set_identifier");
        set => WithProperty("set_identifier", value);
    }

    /// <summary>
    /// The traffic_policy_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficPolicyInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_policy_instance_id");
        set => WithProperty("traffic_policy_instance_id", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => WithProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordsExclusiveTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_route53_records_exclusive resource.
/// </summary>
public class AwsRoute53RecordsExclusive : TerraformResource
{
    public AwsRoute53RecordsExclusive(string name) : base("aws_route53_records_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// Block for resource_record_set.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock>? ResourceRecordSet
    {
        get => GetProperty<HashSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock>>("resource_record_set");
        set => this.WithProperty("resource_record_set", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53RecordsExclusiveTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53RecordsExclusiveTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
