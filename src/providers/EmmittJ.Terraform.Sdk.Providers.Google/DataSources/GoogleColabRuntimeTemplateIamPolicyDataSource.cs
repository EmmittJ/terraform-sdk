using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_colab_runtime_template_iam_policy.
/// </summary>
public class GoogleColabRuntimeTemplateIamPolicyDataSource : TerraformDataSource
{
    public GoogleColabRuntimeTemplateIamPolicyDataSource(string name) : base("google_colab_runtime_template_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("runtime_template");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The runtime_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeTemplate is required")]
    public required TerraformProperty<string> RuntimeTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_template");
        set => SetProperty("runtime_template", value);
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
