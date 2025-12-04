using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsCloudfrontVpcOrigin.
/// Nesting mode: single
/// </summary>
public class AwsCloudfrontVpcOriginTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_origin_endpoint_config in AwsCloudfrontVpcOrigin.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_origin_endpoint_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpPort is required")]
    public required TerraformValue<double> HttpPort
    {
        get => GetArgument<TerraformValue<double>>("http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformValue<double> HttpsPort
    {
        get => GetArgument<TerraformValue<double>>("https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The origin_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginProtocolPolicy is required")]
    public required TerraformValue<string> OriginProtocolPolicy
    {
        get => GetArgument<TerraformValue<string>>("origin_protocol_policy");
        set => SetArgument("origin_protocol_policy", value);
    }

    /// <summary>
    /// OriginSslProtocols block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlockOriginSslProtocolsBlock>? OriginSslProtocols
    {
        get => GetArgument<TerraformList<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlockOriginSslProtocolsBlock>>("origin_ssl_protocols");
        set => SetArgument("origin_ssl_protocols", value);
    }

}

/// <summary>
/// Block type for origin_ssl_protocols in AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlockOriginSslProtocolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_ssl_protocols";

    /// <summary>
    /// The items attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Items is required")]
    public required TerraformSet<string> Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    public required TerraformValue<double> Quantity
    {
        get => GetArgument<TerraformValue<double>>("quantity");
        set => SetArgument("quantity", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_vpc_origin Terraform resource.
/// Manages a aws_cloudfront_vpc_origin resource.
/// </summary>
public partial class AwsCloudfrontVpcOrigin(string name) : TerraformResource("aws_cloudfront_vpc_origin", name)
{
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
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudfrontVpcOriginTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudfrontVpcOriginTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcOriginEndpointConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock>? VpcOriginEndpointConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock>>("vpc_origin_endpoint_config");
        set => SetArgument("vpc_origin_endpoint_config", value);
    }

}
