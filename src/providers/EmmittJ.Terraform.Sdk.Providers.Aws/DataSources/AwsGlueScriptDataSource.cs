using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dag_edge in .
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagEdgeBlock : TerraformBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// The target_parameter attribute.
    /// </summary>
    public TerraformProperty<string>? TargetParameter
    {
        set => SetProperty("target_parameter", value);
    }

}

/// <summary>
/// Block type for dag_node in .
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagNodeBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The line_number attribute.
    /// </summary>
    public TerraformProperty<double>? LineNumber
    {
        set => SetProperty("line_number", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        set => SetProperty("node_type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_glue_script.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueScriptDataSource : TerraformDataSource
{
    public AwsGlueScriptDataSource(string name) : base("aws_glue_script", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("python_script");
        SetOutput("scala_code");
        SetOutput("id");
        SetOutput("language");
        SetOutput("region");
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
    /// The language attribute.
    /// </summary>
    public TerraformProperty<string> Language
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language");
        set => SetProperty("language", value);
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
    /// Block for dag_edge.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagEdge is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagEdge block(s) required")]
    public List<AwsGlueScriptDataSourceDagEdgeBlock>? DagEdge
    {
        set => SetProperty("dag_edge", value);
    }

    /// <summary>
    /// Block for dag_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagNode block(s) required")]
    public List<AwsGlueScriptDataSourceDagNodeBlock>? DagNode
    {
        set => SetProperty("dag_node", value);
    }

    /// <summary>
    /// The python_script attribute.
    /// </summary>
    public TerraformExpression PythonScript => this["python_script"];

    /// <summary>
    /// The scala_code attribute.
    /// </summary>
    public TerraformExpression ScalaCode => this["scala_code"];

}
