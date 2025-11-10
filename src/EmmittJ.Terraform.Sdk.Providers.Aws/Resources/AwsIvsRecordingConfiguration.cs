using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIvsRecordingConfigurationDestinationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for thumbnail_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIvsRecordingConfigurationThumbnailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The recording_mode attribute.
    /// </summary>
    public TerraformProperty<string>? RecordingMode
    {
        get => GetProperty<TerraformProperty<string>>("recording_mode");
        set => WithProperty("recording_mode", value);
    }

    /// <summary>
    /// The target_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TargetIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("target_interval_seconds");
        set => WithProperty("target_interval_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsIvsRecordingConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ivs_recording_configuration resource.
/// </summary>
public class AwsIvsRecordingConfiguration : TerraformResource
{
    public AwsIvsRecordingConfiguration(string name) : base("aws_ivs_recording_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("state");
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
    /// The recording_reconnect_window_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RecordingReconnectWindowSeconds
    {
        get => GetProperty<TerraformProperty<double>>("recording_reconnect_window_seconds");
        set => this.WithProperty("recording_reconnect_window_seconds", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfiguration block(s) allowed")]
    public List<AwsIvsRecordingConfigurationDestinationConfigurationBlock>? DestinationConfiguration
    {
        get => GetProperty<List<AwsIvsRecordingConfigurationDestinationConfigurationBlock>>("destination_configuration");
        set => this.WithProperty("destination_configuration", value);
    }

    /// <summary>
    /// Block for thumbnail_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfiguration block(s) allowed")]
    public List<AwsIvsRecordingConfigurationThumbnailConfigurationBlock>? ThumbnailConfiguration
    {
        get => GetProperty<List<AwsIvsRecordingConfigurationThumbnailConfigurationBlock>>("thumbnail_configuration");
        set => this.WithProperty("thumbnail_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsIvsRecordingConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsIvsRecordingConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
