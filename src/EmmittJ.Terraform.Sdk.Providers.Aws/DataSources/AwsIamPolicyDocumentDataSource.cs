using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("json");
        this.DeclareOutput("minified_json");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The override_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<string>? OverrideJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("override_json");
        set => this.WithProperty("override_json", value);
    }

    /// <summary>
    /// The override_policy_documents attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? OverridePolicyDocuments
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("override_policy_documents");
        set => this.WithProperty("override_policy_documents", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
    }

    /// <summary>
    /// The source_json attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<string>? SourceJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_json");
        set => this.WithProperty("source_json", value);
    }

    /// <summary>
    /// The source_policy_documents attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SourcePolicyDocuments
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("source_policy_documents");
        set => this.WithProperty("source_policy_documents", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
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
