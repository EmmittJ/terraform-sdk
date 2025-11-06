using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_gemini_repository_group_iam_policy.
/// </summary>
public class GoogleGeminiRepositoryGroupIamPolicyDataSource : TerraformDataSource
{
    public GoogleGeminiRepositoryGroupIamPolicyDataSource(string name) : base("google_gemini_repository_group_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    public string? CodeRepositoryIndex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code_repository_index")?.Value;
        set => this.WithProperty("code_repository_index", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    public string? RepositoryGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_group_id")?.Value;
        set => this.WithProperty("repository_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
