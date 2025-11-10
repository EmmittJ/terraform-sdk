using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_endpoints_service_consumers_iam_policy.
/// </summary>
public class GoogleEndpointsServiceConsumersIamPolicyDataSource : TerraformDataSource
{
    public GoogleEndpointsServiceConsumersIamPolicyDataSource(string name) : base("google_endpoints_service_consumers_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("consumer_project");
        SetOutput("id");
        SetOutput("service_name");
    }

    /// <summary>
    /// The consumer_project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerProject is required")]
    public required TerraformProperty<string> ConsumerProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consumer_project");
        set => SetProperty("consumer_project", value);
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
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
