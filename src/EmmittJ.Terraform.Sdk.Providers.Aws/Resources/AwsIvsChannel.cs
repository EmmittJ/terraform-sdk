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
    public TerraformLiteralProperty<bool>? Authorized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("authorized");
        set => this.WithProperty("authorized", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The latency_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LatencyMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("latency_mode");
        set => this.WithProperty("latency_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recording_configuration_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecordingConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recording_configuration_arn");
        set => this.WithProperty("recording_configuration_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
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
