using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public HashSet<string>? Fields
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("fields")?.Value;
        set => this.WithProperty("fields", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    public double? SamplingRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_rate")?.Value;
        set => this.WithProperty("sampling_rate", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
