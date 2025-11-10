using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_property in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeConfigurationPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<bool> Key
    {
        get => GetProperty<TerraformProperty<bool>>("key");
        set => WithProperty("key", value);
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
    /// The queryable attribute.
    /// </summary>
    public TerraformProperty<bool>? Queryable
    {
        get => GetProperty<TerraformProperty<bool>>("queryable");
        set => WithProperty("queryable", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformProperty<bool> Required
    {
        get => GetProperty<TerraformProperty<bool>>("required");
        set => WithProperty("required", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<bool> Secret
    {
        get => GetProperty<TerraformProperty<bool>>("secret");
        set => WithProperty("secret", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for input_artifact_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    public required TerraformProperty<double> MaximumCount
    {
        get => GetProperty<TerraformProperty<double>>("maximum_count");
        set => WithProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformProperty<double> MinimumCount
    {
        get => GetProperty<TerraformProperty<double>>("minimum_count");
        set => WithProperty("minimum_count", value);
    }

}

/// <summary>
/// Block type for output_artifact_details in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    public required TerraformProperty<double> MaximumCount
    {
        get => GetProperty<TerraformProperty<double>>("maximum_count");
        set => WithProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformProperty<double> MinimumCount
    {
        get => GetProperty<TerraformProperty<double>>("minimum_count");
        set => WithProperty("minimum_count", value);
    }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The entity_url_template attribute.
    /// </summary>
    public TerraformProperty<string>? EntityUrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("entity_url_template");
        set => WithProperty("entity_url_template", value);
    }

    /// <summary>
    /// The execution_url_template attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionUrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("execution_url_template");
        set => WithProperty("execution_url_template", value);
    }

    /// <summary>
    /// The revision_url_template attribute.
    /// </summary>
    public TerraformProperty<string>? RevisionUrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("revision_url_template");
        set => WithProperty("revision_url_template", value);
    }

    /// <summary>
    /// The third_party_configuration_url attribute.
    /// </summary>
    public TerraformProperty<string>? ThirdPartyConfigurationUrl
    {
        get => GetProperty<TerraformProperty<string>>("third_party_configuration_url");
        set => WithProperty("third_party_configuration_url", value);
    }

}

/// <summary>
/// Manages a aws_codepipeline_custom_action_type resource.
/// </summary>
public class AwsCodepipelineCustomActionType : TerraformResource
{
    public AwsCodepipelineCustomActionType(string name) : base("aws_codepipeline_custom_action_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner");
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetProperty<TerraformProperty<string>>("category");
        set => this.WithProperty("category", value);
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
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformProperty<string> ProviderName
    {
        get => GetProperty<TerraformProperty<string>>("provider_name");
        set => this.WithProperty("provider_name", value);
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
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for configuration_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ConfigurationProperty block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>? ConfigurationProperty
    {
        get => GetProperty<List<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>>("configuration_property");
        set => this.WithProperty("configuration_property", value);
    }

    /// <summary>
    /// Block for input_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputArtifactDetails block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>? InputArtifactDetails
    {
        get => GetProperty<List<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>>("input_artifact_details");
        set => this.WithProperty("input_artifact_details", value);
    }

    /// <summary>
    /// Block for output_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputArtifactDetails block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>? OutputArtifactDetails
    {
        get => GetProperty<List<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>>("output_artifact_details");
        set => this.WithProperty("output_artifact_details", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeSettingsBlock>? Settings
    {
        get => GetProperty<List<AwsCodepipelineCustomActionTypeSettingsBlock>>("settings");
        set => this.WithProperty("settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

}
