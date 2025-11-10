using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_web_backend_service_iam_policy resource.
/// </summary>
public class GoogleIapWebBackendServiceIamPolicy : TerraformResource
{
    public GoogleIapWebBackendServiceIamPolicy(string name) : base("google_iap_web_backend_service_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("id");
        SetOutput("policy_data");
        SetOutput("project");
        SetOutput("web_backend_service");
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
    /// The web_backend_service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebBackendService is required")]
    public required TerraformProperty<string> WebBackendService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_backend_service");
        set => SetProperty("web_backend_service", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
