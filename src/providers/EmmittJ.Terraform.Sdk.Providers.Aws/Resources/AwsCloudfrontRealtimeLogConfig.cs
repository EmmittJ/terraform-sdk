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
        set => SetProperty("stream_type", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_realtime_log_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontRealtimeLogConfig : TerraformResource
{
    public AwsCloudfrontRealtimeLogConfig(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("fields");
        SetOutput("id");
        SetOutput("name");
        SetOutput("sampling_rate");
    }

    /// <summary>
    /// The fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public HashSet<TerraformProperty<string>> Fields
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("fields");
        set => SetProperty("fields", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformProperty<double> SamplingRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_rate");
        set => SetProperty("sampling_rate", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public List<AwsCloudfrontRealtimeLogConfigEndpointBlock>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
