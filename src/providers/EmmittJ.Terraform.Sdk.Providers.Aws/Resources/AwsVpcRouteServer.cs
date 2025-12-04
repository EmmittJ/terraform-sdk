using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcRouteServer.
/// Nesting mode: single
/// </summary>
public class AwsVpcRouteServerTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_route_server Terraform resource.
/// Manages a aws_vpc_route_server resource.
/// </summary>
public partial class AwsVpcRouteServer(string name) : TerraformResource("aws_vpc_route_server", name)
{
    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AmazonSideAsn is required")]
    public required TerraformValue<double> AmazonSideAsn
    {
        get => GetArgument<TerraformValue<double>>("amazon_side_asn");
        set => SetArgument("amazon_side_asn", value);
    }

    /// <summary>
    /// The persist_routes attribute.
    /// </summary>
    public TerraformValue<string>? PersistRoutes
    {
        get => GetArgument<TerraformValue<string>>("persist_routes");
        set => SetArgument("persist_routes", value);
    }

    /// <summary>
    /// The persist_routes_duration attribute.
    /// </summary>
    public TerraformValue<double>? PersistRoutesDuration
    {
        get => GetArgument<TerraformValue<double>>("persist_routes_duration");
        set => SetArgument("persist_routes_duration", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The sns_notifications_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SnsNotificationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sns_notifications_enabled");
        set => SetArgument("sns_notifications_enabled", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformValue<string> RouteServerId
        => AsReference("route_server_id");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => AsReference("sns_topic_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcRouteServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcRouteServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
