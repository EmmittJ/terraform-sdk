using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_binary_authorization_attestor_iam_policy.
/// </summary>
public class GoogleBinaryAuthorizationAttestorIamPolicyDataSource : TerraformDataSource
{
    public GoogleBinaryAuthorizationAttestorIamPolicyDataSource(string name) : base("google_binary_authorization_attestor_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("attestor");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The attestor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attestor is required")]
    public required TerraformProperty<string> Attestor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attestor");
        set => SetProperty("attestor", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
