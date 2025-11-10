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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<bool> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The queryable attribute.
    /// </summary>
    public TerraformProperty<bool>? Queryable
    {
        set => SetProperty("queryable", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformProperty<bool> Required
    {
        set => SetProperty("required", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<bool> Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformProperty<double> MinimumCount
    {
        set => SetProperty("minimum_count", value);
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
        set => SetProperty("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformProperty<double> MinimumCount
    {
        set => SetProperty("minimum_count", value);
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
        set => SetProperty("entity_url_template", value);
    }

    /// <summary>
    /// The execution_url_template attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionUrlTemplate
    {
        set => SetProperty("execution_url_template", value);
    }

    /// <summary>
    /// The revision_url_template attribute.
    /// </summary>
    public TerraformProperty<string>? RevisionUrlTemplate
    {
        set => SetProperty("revision_url_template", value);
    }

    /// <summary>
    /// The third_party_configuration_url attribute.
    /// </summary>
    public TerraformProperty<string>? ThirdPartyConfigurationUrl
    {
        set => SetProperty("third_party_configuration_url", value);
    }

}

/// <summary>
/// Manages a aws_codepipeline_custom_action_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodepipelineCustomActionType : TerraformResource
{
    public AwsCodepipelineCustomActionType(string name) : base("aws_codepipeline_custom_action_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("owner");
        SetOutput("category");
        SetOutput("id");
        SetOutput("provider_name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version");
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredOutput<TerraformProperty<string>>("category");
        set => SetProperty("category", value);
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
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformProperty<string> ProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provider_name");
        set => SetProperty("provider_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for configuration_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ConfigurationProperty block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>? ConfigurationProperty
    {
        set => SetProperty("configuration_property", value);
    }

    /// <summary>
    /// Block for input_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputArtifactDetails block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>? InputArtifactDetails
    {
        set => SetProperty("input_artifact_details", value);
    }

    /// <summary>
    /// Block for output_artifact_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputArtifactDetails block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>? OutputArtifactDetails
    {
        set => SetProperty("output_artifact_details", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<AwsCodepipelineCustomActionTypeSettingsBlock>? Settings
    {
        set => SetProperty("settings", value);
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
