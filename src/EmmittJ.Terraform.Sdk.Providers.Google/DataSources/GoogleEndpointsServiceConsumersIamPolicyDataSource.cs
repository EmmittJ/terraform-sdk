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
    public string? ConsumerProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_project")?.Value;
        set => this.WithProperty("consumer_project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
