using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_endpoints_service_consumers_iam_policy resource.
/// </summary>
public class GoogleEndpointsServiceConsumersIamPolicy : TerraformResource
{
    public GoogleEndpointsServiceConsumersIamPolicy(string name) : base("google_endpoints_service_consumers_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The consumer_project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConsumerProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_project");
        set => this.WithProperty("consumer_project", value);
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
    /// The policy_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
