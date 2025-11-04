using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ivs_channel resource.
/// </summary>
public class AwsIvsChannel : TerraformResource
{
    public AwsIvsChannel(string name) : base("aws_ivs_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ingest_endpoint");
        this.DeclareOutput("playback_url");
    }

    /// <summary>
    /// The authorized attribute.
    /// </summary>
    public bool? Authorized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("authorized")?.Value;
        set => this.WithProperty("authorized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The latency_mode attribute.
    /// </summary>
    public string? LatencyMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("latency_mode")?.Value;
        set => this.WithProperty("latency_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The recording_configuration_arn attribute.
    /// </summary>
    public string? RecordingConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recording_configuration_arn")?.Value;
        set => this.WithProperty("recording_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ingest_endpoint attribute.
    /// </summary>
    public TerraformExpression IngestEndpoint => this["ingest_endpoint"];

    /// <summary>
    /// The playback_url attribute.
    /// </summary>
    public TerraformExpression PlaybackUrl => this["playback_url"];

}
