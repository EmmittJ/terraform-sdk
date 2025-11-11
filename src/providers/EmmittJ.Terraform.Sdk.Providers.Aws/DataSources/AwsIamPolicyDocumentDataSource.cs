using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public partial class AwsIamPolicyDocumentDataSourceStatementBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformProperty("actions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Actions { get; set; }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    [TerraformProperty("effect")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Effect { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformProperty("not_actions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? NotActions { get; set; }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    [TerraformProperty("not_resources")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? NotResources { get; set; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformProperty("sid")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Sid { get; set; }

}

/// <summary>
/// Retrieves information about a aws_iam_policy_document.
/// </summary>
public partial class AwsIamPolicyDocumentDataSource : TerraformDataSource
{
    public AwsIamPolicyDocumentDataSource(string name) : base("aws_iam_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("override_json")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OverrideJson { get; set; }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    [TerraformProperty("override_policy_documents")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? OverridePolicyDocuments { get; set; }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformProperty("policy_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PolicyId { get; set; }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("source_json")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceJson { get; set; }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    [TerraformProperty("source_policy_documents")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SourcePolicyDocuments { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("statement")]
    public TerraformList<TerraformBlock<AwsIamPolicyDocumentDataSourceStatementBlock>>? Statement { get; set; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Json { get; }

    /// <summary>
    /// The minified_json attribute.
    /// </summary>
    [TerraformProperty("minified_json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MinifiedJson { get; }

}
