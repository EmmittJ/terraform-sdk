using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recording_group in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlock : TerraformBlock
{
    /// <summary>
    /// The all_supported attribute.
    /// </summary>
    public TerraformProperty<bool>? AllSupported
    {
        get => GetProperty<TerraformProperty<bool>>("all_supported");
        set => WithProperty("all_supported", value);
    }

    /// <summary>
    /// The include_global_resource_types attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeGlobalResourceTypes
    {
        get => GetProperty<TerraformProperty<bool>>("include_global_resource_types");
        set => WithProperty("include_global_resource_types", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_types");
        set => WithProperty("resource_types", value);
    }

}

/// <summary>
/// Block type for recording_mode in .
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingModeBlock : TerraformBlock
{
    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? RecordingFrequency
    {
        get => GetProperty<TerraformProperty<string>>("recording_frequency");
        set => WithProperty("recording_frequency", value);
    }

}

/// <summary>
/// Manages a aws_config_configuration_recorder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigConfigurationRecorder : TerraformResource
{
    public AwsConfigConfigurationRecorder(string name) : base("aws_config_configuration_recorder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// Block for recording_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingGroup block(s) allowed")]
    public List<AwsConfigConfigurationRecorderRecordingGroupBlock>? RecordingGroup
    {
        get => GetProperty<List<AwsConfigConfigurationRecorderRecordingGroupBlock>>("recording_group");
        set => this.WithProperty("recording_group", value);
    }

    /// <summary>
    /// Block for recording_mode.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingMode block(s) allowed")]
    public List<AwsConfigConfigurationRecorderRecordingModeBlock>? RecordingMode
    {
        get => GetProperty<List<AwsConfigConfigurationRecorderRecordingModeBlock>>("recording_mode");
        set => this.WithProperty("recording_mode", value);
    }

}
