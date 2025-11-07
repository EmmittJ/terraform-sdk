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
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
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

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
