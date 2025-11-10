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
        set => SetProperty("failover", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckId
    {
        set => SetProperty("health_check_id", value);
    }

    /// <summary>
    /// The multi_value_answer attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiValueAnswer
    {
        set => SetProperty("multi_value_answer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SetIdentifier
    {
        set => SetProperty("set_identifier", value);
    }

    /// <summary>
    /// The traffic_policy_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficPolicyInstanceId
    {
        set => SetProperty("traffic_policy_instance_id", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        set => SetProperty("weight", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("zone_id");
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
    }

    /// <summary>
    /// Block for resource_record_set.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock>? ResourceRecordSet
    {
        set => SetProperty("resource_record_set", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53RecordsExclusiveTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
