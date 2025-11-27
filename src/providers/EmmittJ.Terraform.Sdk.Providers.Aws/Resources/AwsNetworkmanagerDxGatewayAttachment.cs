using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerDxGatewayAttachment.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerDxGatewayAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_dx_gateway_attachment Terraform resource.
/// Manages a aws_networkmanager_dx_gateway_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerDxGatewayAttachment(string name) : TerraformResource("aws_networkmanager_dx_gateway_attachment", name)
{
    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformValue<string> CoreNetworkId
    {
        get => new TerraformReference<string>(this, "core_network_id");
        set => SetArgument("core_network_id", value);
    }

    /// <summary>
    /// The direct_connect_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectConnectGatewayArn is required")]
    public required TerraformValue<string> DirectConnectGatewayArn
    {
        get => new TerraformReference<string>(this, "direct_connect_gateway_arn");
        set => SetArgument("direct_connect_gateway_arn", value);
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeLocations is required")]
    public TerraformList<string>? EdgeLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "edge_locations").ResolveNodes(ctx));
        set => SetArgument("edge_locations", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformValue<double> AttachmentPolicyRuleNumber
    {
        get => new TerraformReference<double>(this, "attachment_policy_rule_number");
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformValue<string> AttachmentType
    {
        get => new TerraformReference<string>(this, "attachment_type");
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => new TerraformReference<string>(this, "core_network_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformValue<string> SegmentName
    {
        get => new TerraformReference<string>(this, "segment_name");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerDxGatewayAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerDxGatewayAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
