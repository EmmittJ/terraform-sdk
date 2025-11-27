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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpPort is required")]
    public required TerraformValue<double> HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformValue<double> HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
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
    /// The origin_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginProtocolPolicy is required")]
    public required TerraformValue<string> OriginProtocolPolicy
    {
        get => new TerraformReference<string>(this, "origin_protocol_policy");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

    /// <summary>
    /// The quantity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quantity is required")]
    public required TerraformValue<double> Quantity
    {
        get => new TerraformReference<double>(this, "quantity");
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
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
