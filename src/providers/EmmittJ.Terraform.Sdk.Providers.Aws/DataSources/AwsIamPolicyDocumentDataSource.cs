using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlock : ITerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformPropertyName("actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Actions { get; set; }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    [TerraformPropertyName("effect")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Effect { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformPropertyName("not_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NotActions { get; set; }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    [TerraformPropertyName("not_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NotResources { get; set; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Resources { get; set; }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformPropertyName("sid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sid { get; set; }

}

/// <summary>
/// Retrieves information about a aws_iam_policy_document.
/// </summary>
public class AwsIamPolicyDocumentDataSource : TerraformDataSource
{
    public AwsIamPolicyDocumentDataSource(string name) : base("aws_iam_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("override_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OverrideJson { get; set; }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    [TerraformPropertyName("override_policy_documents")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? OverridePolicyDocuments { get; set; }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyId { get; set; }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("source_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceJson { get; set; }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    [TerraformPropertyName("source_policy_documents")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SourcePolicyDocuments { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("statement")]
    public TerraformList<TerraformBlock<AwsIamPolicyDocumentDataSourceStatementBlock>>? Statement { get; set; } = new();

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Json => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "json");

    /// <summary>
    /// The minified_json attribute.
    /// </summary>
    [TerraformPropertyName("minified_json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinifiedJson => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minified_json");

}
