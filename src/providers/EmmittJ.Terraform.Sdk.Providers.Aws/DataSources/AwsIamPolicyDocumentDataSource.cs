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
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The effect attribute.
    /// </summary>
    public TerraformProperty<string>? Effect
    {
        set => SetProperty("effect", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotActions
    {
        set => SetProperty("not_actions", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotResources
    {
        set => SetProperty("not_resources", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        set => SetProperty("resources", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformProperty<string>? Sid
    {
        set => SetProperty("sid", value);
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
        SetOutput("json");
        SetOutput("minified_json");
        SetOutput("id");
        SetOutput("override_json");
        SetOutput("override_policy_documents");
        SetOutput("policy_id");
        SetOutput("source_json");
        SetOutput("source_policy_documents");
        SetOutput("version");
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
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> OverrideJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("override_json");
        set => SetProperty("override_json", value);
    }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>> OverridePolicyDocuments
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("override_policy_documents");
        set => SetProperty("override_policy_documents", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformProperty<string> PolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_id");
        set => SetProperty("policy_id", value);
    }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> SourceJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_json");
        set => SetProperty("source_json", value);
    }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>> SourcePolicyDocuments
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("source_policy_documents");
        set => SetProperty("source_policy_documents", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    public List<AwsIamPolicyDocumentDataSourceStatementBlock>? Statement
    {
        set => SetProperty("statement", value);
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
