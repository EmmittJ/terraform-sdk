using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_endpoints_service_consumers_iam_member resource.
/// </summary>
public class GoogleEndpointsServiceConsumersIamMember : TerraformResource
{
    public GoogleEndpointsServiceConsumersIamMember(string name) : base("google_endpoints_service_consumers_iam_member", name)
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
    /// The member attribute.
    /// </summary>
    public string? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member")?.Value;
        set => this.WithProperty("member", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
