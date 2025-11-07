using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gemini_repository_group_iam_policy resource.
/// </summary>
public class GoogleGeminiRepositoryGroupIamPolicy : TerraformResource
{
    public GoogleGeminiRepositoryGroupIamPolicy(string name) : base("google_gemini_repository_group_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CodeRepositoryIndex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("code_repository_index");
        set => this.WithProperty("code_repository_index", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_group_id");
        set => this.WithProperty("repository_group_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
