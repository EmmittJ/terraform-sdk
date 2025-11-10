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
        SetOutput("etag");
        SetOutput("code_repository_index");
        SetOutput("id");
        SetOutput("location");
        SetOutput("policy_data");
        SetOutput("project");
        SetOutput("repository_group_id");
    }

    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    public required TerraformProperty<string> CodeRepositoryIndex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code_repository_index");
        set => SetProperty("code_repository_index", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_data");
        set => SetProperty("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    public required TerraformProperty<string> RepositoryGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_group_id");
        set => SetProperty("repository_group_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
