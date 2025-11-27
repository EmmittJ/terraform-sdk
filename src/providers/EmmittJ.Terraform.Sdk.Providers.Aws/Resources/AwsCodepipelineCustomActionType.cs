using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_property in AwsCodepipelineCustomActionType.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeConfigurationPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration_property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<bool> Key
    {
        get => new TerraformReference<bool>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The queryable attribute.
    /// </summary>
    public TerraformValue<bool>? Queryable
    {
        get => new TerraformReference<bool>(this, "queryable");
        set => SetArgument("queryable", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<bool> Secret
    {
        get => new TerraformReference<bool>(this, "secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for input_artifact_details in AwsCodepipelineCustomActionType.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_artifact_details";

    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    public required TerraformValue<double> MaximumCount
    {
        get => new TerraformReference<double>(this, "maximum_count");
        set => SetArgument("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformValue<double> MinimumCount
    {
        get => new TerraformReference<double>(this, "minimum_count");
        set => SetArgument("minimum_count", value);
    }

}


/// <summary>
/// Block type for output_artifact_details in AwsCodepipelineCustomActionType.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_artifact_details";

    /// <summary>
    /// The maximum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCount is required")]
    public required TerraformValue<double> MaximumCount
    {
        get => new TerraformReference<double>(this, "maximum_count");
        set => SetArgument("maximum_count", value);
    }

    /// <summary>
    /// The minimum_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCount is required")]
    public required TerraformValue<double> MinimumCount
    {
        get => new TerraformReference<double>(this, "minimum_count");
        set => SetArgument("minimum_count", value);
    }

}


/// <summary>
/// Block type for settings in AwsCodepipelineCustomActionType.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineCustomActionTypeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// The entity_url_template attribute.
    /// </summary>
    public TerraformValue<string>? EntityUrlTemplate
    {
        get => new TerraformReference<string>(this, "entity_url_template");
        set => SetArgument("entity_url_template", value);
    }

    /// <summary>
    /// The execution_url_template attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionUrlTemplate
    {
        get => new TerraformReference<string>(this, "execution_url_template");
        set => SetArgument("execution_url_template", value);
    }

    /// <summary>
    /// The revision_url_template attribute.
    /// </summary>
    public TerraformValue<string>? RevisionUrlTemplate
    {
        get => new TerraformReference<string>(this, "revision_url_template");
        set => SetArgument("revision_url_template", value);
    }

    /// <summary>
    /// The third_party_configuration_url attribute.
    /// </summary>
    public TerraformValue<string>? ThirdPartyConfigurationUrl
    {
        get => new TerraformReference<string>(this, "third_party_configuration_url");
        set => SetArgument("third_party_configuration_url", value);
    }

}


/// <summary>
/// Represents a aws_codepipeline_custom_action_type Terraform resource.
/// Manages a aws_codepipeline_custom_action_type resource.
/// </summary>
public partial class AwsCodepipelineCustomActionType(string name) : TerraformResource("aws_codepipeline_custom_action_type", name)
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// ConfigurationProperty block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ConfigurationProperty block(s) allowed")]
    public TerraformList<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>? ConfigurationProperty
    {
        get => GetArgument<TerraformList<AwsCodepipelineCustomActionTypeConfigurationPropertyBlock>>("configuration_property");
        set => SetArgument("configuration_property", value);
    }

    /// <summary>
    /// InputArtifactDetails block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputArtifactDetails block(s) allowed")]
    public required TerraformList<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock> InputArtifactDetails
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineCustomActionTypeInputArtifactDetailsBlock>>("input_artifact_details");
        set => SetArgument("input_artifact_details", value);
    }

    /// <summary>
    /// OutputArtifactDetails block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputArtifactDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputArtifactDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputArtifactDetails block(s) allowed")]
    public required TerraformList<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock> OutputArtifactDetails
    {
        get => GetRequiredArgument<TerraformList<AwsCodepipelineCustomActionTypeOutputArtifactDetailsBlock>>("output_artifact_details");
        set => SetArgument("output_artifact_details", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public TerraformList<AwsCodepipelineCustomActionTypeSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<AwsCodepipelineCustomActionTypeSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}
