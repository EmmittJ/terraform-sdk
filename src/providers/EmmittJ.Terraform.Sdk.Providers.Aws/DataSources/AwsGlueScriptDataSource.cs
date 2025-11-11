using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dag_edge in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueScriptDataSourceDagEdgeBlock : TerraformBlockBase
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Target { get; set; }

    /// <summary>
    /// The target_parameter attribute.
    /// </summary>
    [TerraformProperty("target_parameter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetParameter { get; set; }

}

/// <summary>
/// Block type for dag_node in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueScriptDataSourceDagNodeBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The line_number attribute.
    /// </summary>
    [TerraformProperty("line_number")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? LineNumber { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeType { get; set; }

}

/// <summary>
/// Retrieves information about a aws_glue_script.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueScriptDataSource : TerraformDataSource
{
    public AwsGlueScriptDataSource(string name) : base("aws_glue_script", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Language { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for dag_edge.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagEdge is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagEdge block(s) required")]
    [TerraformProperty("dag_edge")]
    public TerraformList<TerraformBlock<AwsGlueScriptDataSourceDagEdgeBlock>>? DagEdge { get; set; }

    /// <summary>
    /// Block for dag_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagNode block(s) required")]
    [TerraformProperty("dag_node")]
    public TerraformList<TerraformBlock<AwsGlueScriptDataSourceDagNodeBlock>>? DagNode { get; set; }

    /// <summary>
    /// The python_script attribute.
    /// </summary>
    [TerraformProperty("python_script")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PythonScript { get; }

    /// <summary>
    /// The scala_code attribute.
    /// </summary>
    [TerraformProperty("scala_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScalaCode { get; }

}
