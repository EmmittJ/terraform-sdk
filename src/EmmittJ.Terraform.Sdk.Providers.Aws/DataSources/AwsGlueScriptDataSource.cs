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
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

    /// <summary>
    /// The target_parameter attribute.
    /// </summary>
    public TerraformProperty<string>? TargetParameter
    {
        get => GetProperty<TerraformProperty<string>>("target_parameter");
        set => WithProperty("target_parameter", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The line_number attribute.
    /// </summary>
    public TerraformProperty<double>? LineNumber
    {
        get => GetProperty<TerraformProperty<double>>("line_number");
        set => WithProperty("line_number", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => WithProperty("node_type", value);
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
        this.DeclareOutput("python_script");
        this.DeclareOutput("scala_code");
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
    /// The language attribute.
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => this.WithProperty("language", value);
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
    /// Block for dag_edge.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagEdge block(s) required")]
    public List<AwsGlueScriptDataSourceDagEdgeBlock>? DagEdge
    {
        get => GetProperty<List<AwsGlueScriptDataSourceDagEdgeBlock>>("dag_edge");
        set => this.WithProperty("dag_edge", value);
    }

    /// <summary>
    /// Block for dag_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagNode block(s) required")]
    public List<AwsGlueScriptDataSourceDagNodeBlock>? DagNode
    {
        get => GetProperty<List<AwsGlueScriptDataSourceDagNodeBlock>>("dag_node");
        set => this.WithProperty("dag_node", value);
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
