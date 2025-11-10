using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudfrontVpcOriginTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
/// Block type for vpc_origin_endpoint_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpPort is required")]
    public required TerraformProperty<double> HttpPort
    {
        get => GetProperty<TerraformProperty<double>>("http_port");
        set => WithProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformProperty<double> HttpsPort
    {
        get => GetProperty<TerraformProperty<double>>("https_port");
        set => WithProperty("https_port", value);
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
    /// The origin_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginProtocolPolicy is required")]
    public required TerraformProperty<string> OriginProtocolPolicy
    {
        get => GetProperty<TerraformProperty<string>>("origin_protocol_policy");
        set => WithProperty("origin_protocol_policy", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_vpc_origin resource.
/// </summary>
public class AwsCloudfrontVpcOrigin : TerraformResource
{
    public AwsCloudfrontVpcOrigin(string name) : base("aws_cloudfront_vpc_origin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudfrontVpcOriginTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudfrontVpcOriginTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_origin_endpoint_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock>? VpcOriginEndpointConfig
    {
        get => GetProperty<List<AwsCloudfrontVpcOriginVpcOriginEndpointConfigBlock>>("vpc_origin_endpoint_config");
        set => this.WithProperty("vpc_origin_endpoint_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
