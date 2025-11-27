using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dag_edge in AwsGlueScriptDataSource.
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagEdgeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dag_edge";

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The target_parameter attribute.
    /// </summary>
    public TerraformValue<string>? TargetParameter
    {
        get => new TerraformReference<string>(this, "target_parameter");
        set => SetArgument("target_parameter", value);
    }

}


/// <summary>
/// Block type for dag_node in AwsGlueScriptDataSource.
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dag_node";

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
    /// The line_number attribute.
    /// </summary>
    public TerraformValue<double>? LineNumber
    {
        get => new TerraformReference<double>(this, "line_number");
        set => SetArgument("line_number", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// Args block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Args is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Args block(s) required")]
    public required TerraformList<AwsGlueScriptDataSourceDagNodeBlockArgsBlock> Args
    {
        get => GetRequiredArgument<TerraformList<AwsGlueScriptDataSourceDagNodeBlockArgsBlock>>("args");
        set => SetArgument("args", value);
    }

}

/// <summary>
/// Block type for args in AwsGlueScriptDataSourceDagNodeBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagNodeBlockArgsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "args";

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
    /// The param attribute.
    /// </summary>
    public TerraformValue<bool>? Param
    {
        get => new TerraformReference<bool>(this, "param");
        set => SetArgument("param", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_glue_script Terraform data source.
/// Retrieves information about a aws_glue_script.
/// </summary>
public partial class AwsGlueScriptDataSource(string name) : TerraformDataSource("aws_glue_script", name)
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
    /// The language attribute.
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
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
    /// The python_script attribute.
    /// </summary>
    public TerraformValue<string> PythonScript
    {
        get => new TerraformReference<string>(this, "python_script");
    }

    /// <summary>
    /// The scala_code attribute.
    /// </summary>
    public TerraformValue<string> ScalaCode
    {
        get => new TerraformReference<string>(this, "scala_code");
    }

    /// <summary>
    /// DagEdge block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagEdge is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagEdge block(s) required")]
    public required TerraformList<AwsGlueScriptDataSourceDagEdgeBlock> DagEdge
    {
        get => GetRequiredArgument<TerraformList<AwsGlueScriptDataSourceDagEdgeBlock>>("dag_edge");
        set => SetArgument("dag_edge", value);
    }

    /// <summary>
    /// DagNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagNode block(s) required")]
    public required TerraformList<AwsGlueScriptDataSourceDagNodeBlock> DagNode
    {
        get => GetRequiredArgument<TerraformList<AwsGlueScriptDataSourceDagNodeBlock>>("dag_node");
        set => SetArgument("dag_node", value);
    }

}
