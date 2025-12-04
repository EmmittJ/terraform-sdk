using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attributes in AwsGlobalacceleratorCustomRoutingAccelerator.
/// Nesting mode: list
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// The flow_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FlowLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("flow_logs_enabled");
        set => SetArgument("flow_logs_enabled", value);
    }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? FlowLogsS3Bucket
    {
        get => GetArgument<TerraformValue<string>>("flow_logs_s3_bucket");
        set => SetArgument("flow_logs_s3_bucket", value);
    }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? FlowLogsS3Prefix
    {
        get => GetArgument<TerraformValue<string>>("flow_logs_s3_prefix");
        set => SetArgument("flow_logs_s3_prefix", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlobalacceleratorCustomRoutingAccelerator.
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_globalaccelerator_custom_routing_accelerator Terraform resource.
/// Manages a aws_globalaccelerator_custom_routing_accelerator resource.
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingAccelerator(string name) : TerraformResource("aws_globalaccelerator_custom_routing_accelerator", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformList<string>? IpAddresses
    {
        get => GetArgument<TerraformList<string>>("ip_addresses");
        set => SetArgument("ip_addresses", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpSets
        => AsReference("ip_sets");

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    public TerraformList<AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
