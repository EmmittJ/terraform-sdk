using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsOdbNetworkPeeringConnection.
/// Nesting mode: single
/// </summary>
public class AwsOdbNetworkPeeringConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a aws_odb_network_peering_connection Terraform resource.
/// A peering connection between an ODB network and either another ODB network or a customer-owned VPC.
/// </summary>
public partial class AwsOdbNetworkPeeringConnection(string name) : TerraformResource("aws_odb_network_peering_connection", name)
{
    /// <summary>
    /// Display name of the odb network peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Required field. The unique identifier of the ODB network that initiates the peering connection. A sample ID is odbpcx-abcdefgh12345678. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformValue<string> OdbNetworkId
    {
        get => new TerraformReference<string>(this, "odb_network_id");
        set => SetArgument("odb_network_id", value);
    }

    /// <summary>
    /// Required field. The unique identifier of the ODB peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetworkId is required")]
    public required TerraformValue<string> PeerNetworkId
    {
        get => new TerraformReference<string>(this, "peer_network_id");
        set => SetArgument("peer_network_id", value);
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
    /// Created time of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> OdbNetworkArn
    {
        get => new TerraformReference<string>(this, "odb_network_arn");
    }

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    public TerraformValue<string> OdbPeeringConnectionType
    {
        get => new TerraformReference<string>(this, "odb_peering_connection_type");
    }

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    public TerraformValue<string> PeerNetworkArn
    {
        get => new TerraformReference<string>(this, "peer_network_arn");
    }

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The reason for the current status of the ODB peering connection..
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
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
    public AwsOdbNetworkPeeringConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOdbNetworkPeeringConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
