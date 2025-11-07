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
    public TerraformProperty<HashSet<string>>? Fields
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("fields");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SamplingRate
    {
        get => GetProperty<TerraformProperty<double>>("sampling_rate");
        set => this.WithProperty("sampling_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
