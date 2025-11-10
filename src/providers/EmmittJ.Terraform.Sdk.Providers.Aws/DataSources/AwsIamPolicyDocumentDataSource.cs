using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public class AwsIamPolicyDocumentDataSourceStatementBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Actions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
    }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    public TerraformProperty<string>? Effect
    {
        get => GetProperty<TerraformProperty<string>>("effect");
        set => WithProperty("effect", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("not_actions");
        set => WithProperty("not_actions", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotResources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("not_resources");
        set => WithProperty("not_resources", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformProperty<string>? Sid
    {
        get => GetProperty<TerraformProperty<string>>("sid");
        set => WithProperty("sid", value);
    }

}

/// <summary>
/// Retrieves information about a aws_iam_policy_document.
/// </summary>
public class AwsIamPolicyDocumentDataSource : TerraformDataSource
{
    public AwsIamPolicyDocumentDataSource(string name) : base("aws_iam_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("json");
        this.WithOutput("minified_json");
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
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? OverrideJson
    {
        get => GetProperty<TerraformProperty<string>>("override_json");
        set => this.WithProperty("override_json", value);
    }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>>? OverridePolicyDocuments
    {
        get => GetProperty<List<TerraformProperty<string>>>("override_policy_documents");
        set => this.WithProperty("override_policy_documents", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyId
    {
        get => GetProperty<TerraformProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
    }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? SourceJson
    {
        get => GetProperty<TerraformProperty<string>>("source_json");
        set => this.WithProperty("source_json", value);
    }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SourcePolicyDocuments
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_policy_documents");
        set => this.WithProperty("source_policy_documents", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    public List<AwsIamPolicyDocumentDataSourceStatementBlock>? Statement
    {
        get => GetProperty<List<AwsIamPolicyDocumentDataSourceStatementBlock>>("statement");
        set => this.WithProperty("statement", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

    /// <summary>
    /// The minified_json attribute.
    /// </summary>
    public TerraformExpression MinifiedJson => this["minified_json"];

}
