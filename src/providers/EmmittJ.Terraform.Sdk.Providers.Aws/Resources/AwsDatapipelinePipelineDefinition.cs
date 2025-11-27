using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_object in AwsDatapipelinePipelineDefinition.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionParameterObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter_object";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Attribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatapipelinePipelineDefinitionParameterObjectBlockAttributeBlock>? Attribute
    {
        get => GetArgument<TerraformSet<AwsDatapipelinePipelineDefinitionParameterObjectBlockAttributeBlock>>("attribute");
        set => SetArgument("attribute", value);
    }

}

/// <summary>
/// Block type for attribute in AwsDatapipelinePipelineDefinitionParameterObjectBlock.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionParameterObjectBlockAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StringValue is required")]
    public required TerraformValue<string> StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

}


/// <summary>
/// Block type for parameter_value in AwsDatapipelinePipelineDefinition.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionParameterValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter_value";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StringValue is required")]
    public required TerraformValue<string> StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

}


/// <summary>
/// Block type for pipeline_object in AwsDatapipelinePipelineDefinition.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionPipelineObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_object";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Field block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlockFieldBlock>? Field
    {
        get => GetArgument<TerraformSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlockFieldBlock>>("field");
        set => SetArgument("field", value);
    }

}

/// <summary>
/// Block type for field in AwsDatapipelinePipelineDefinitionPipelineObjectBlock.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionPipelineObjectBlockFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The ref_value attribute.
    /// </summary>
    public TerraformValue<string>? RefValue
    {
        get => new TerraformReference<string>(this, "ref_value");
        set => SetArgument("ref_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => new TerraformReference<string>(this, "string_value");
        set => SetArgument("string_value", value);
    }

}


/// <summary>
/// Represents a aws_datapipeline_pipeline_definition Terraform resource.
/// Manages a aws_datapipeline_pipeline_definition resource.
/// </summary>
public partial class AwsDatapipelinePipelineDefinition(string name) : TerraformResource("aws_datapipeline_pipeline_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformValue<string> PipelineId
    {
        get => new TerraformReference<string>(this, "pipeline_id");
        set => SetArgument("pipeline_id", value);
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
    /// ParameterObject block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatapipelinePipelineDefinitionParameterObjectBlock>? ParameterObject
    {
        get => GetArgument<TerraformSet<AwsDatapipelinePipelineDefinitionParameterObjectBlock>>("parameter_object");
        set => SetArgument("parameter_object", value);
    }

    /// <summary>
    /// ParameterValue block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatapipelinePipelineDefinitionParameterValueBlock>? ParameterValue
    {
        get => GetArgument<TerraformSet<AwsDatapipelinePipelineDefinitionParameterValueBlock>>("parameter_value");
        set => SetArgument("parameter_value", value);
    }

    /// <summary>
    /// PipelineObject block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineObject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PipelineObject block(s) required")]
    public required TerraformSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlock> PipelineObject
    {
        get => GetRequiredArgument<TerraformSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlock>>("pipeline_object");
        set => SetArgument("pipeline_object", value);
    }

}
