using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontRealtimeLogConfigEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The stream_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamType is required")]
    public required TerraformProperty<string> StreamType
    {
        get => GetProperty<TerraformProperty<string>>("stream_type");
        set => WithProperty("stream_type", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_realtime_log_config resource.
/// </summary>
public class AwsCloudfrontRealtimeLogConfig : TerraformResource
{
    public AwsCloudfrontRealtimeLogConfig(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public HashSet<TerraformProperty<string>>? Fields
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("fields");
        set => this.WithProperty("fields", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformProperty<double> SamplingRate
    {
        get => GetProperty<TerraformProperty<double>>("sampling_rate");
        set => this.WithProperty("sampling_rate", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public List<AwsCloudfrontRealtimeLogConfigEndpointBlock>? Endpoint
    {
        get => GetProperty<List<AwsCloudfrontRealtimeLogConfigEndpointBlock>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
