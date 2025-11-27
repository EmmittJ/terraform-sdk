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
        get => new TerraformReference<bool>(this, "flow_logs_enabled");
        set => SetArgument("flow_logs_enabled", value);
    }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? FlowLogsS3Bucket
    {
        get => new TerraformReference<string>(this, "flow_logs_s3_bucket");
        set => SetArgument("flow_logs_s3_bucket", value);
    }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? FlowLogsS3Prefix
    {
        get => new TerraformReference<string>(this, "flow_logs_s3_prefix");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformList<string>? IpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_addresses").ResolveNodes(ctx));
        set => SetArgument("ip_addresses", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpSets
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_sets").ResolveNodes(ctx));
    }

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
