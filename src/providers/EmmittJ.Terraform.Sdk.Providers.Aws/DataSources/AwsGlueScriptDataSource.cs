using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dag_edge in .
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagEdgeBlock : ITerraformBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Target { get; set; }

    /// <summary>
    /// The target_parameter attribute.
    /// </summary>
    [TerraformPropertyName("target_parameter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetParameter { get; set; }

}

/// <summary>
/// Block type for dag_node in .
/// Nesting mode: list
/// </summary>
public class AwsGlueScriptDataSourceDagNodeBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The line_number attribute.
    /// </summary>
    [TerraformPropertyName("line_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? LineNumber { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeType { get; set; }

}

/// <summary>
/// Retrieves information about a aws_glue_script.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueScriptDataSource : TerraformDataSource
{
    public AwsGlueScriptDataSource(string name) : base("aws_glue_script", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Language { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for dag_edge.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagEdge is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagEdge block(s) required")]
    [TerraformPropertyName("dag_edge")]
    public TerraformList<TerraformBlock<AwsGlueScriptDataSourceDagEdgeBlock>>? DagEdge { get; set; } = new();

    /// <summary>
    /// Block for dag_node.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DagNode block(s) required")]
    [TerraformPropertyName("dag_node")]
    public TerraformList<TerraformBlock<AwsGlueScriptDataSourceDagNodeBlock>>? DagNode { get; set; } = new();

    /// <summary>
    /// The python_script attribute.
    /// </summary>
    [TerraformPropertyName("python_script")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PythonScript => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "python_script");

    /// <summary>
    /// The scala_code attribute.
    /// </summary>
    [TerraformPropertyName("scala_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScalaCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scala_code");

}
