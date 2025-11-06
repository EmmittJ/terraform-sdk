using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_app_engine_service_iam_policy resource.
/// </summary>
public class GoogleIapAppEngineServiceIamPolicy : TerraformResource
{
    public GoogleIapAppEngineServiceIamPolicy(string name) : base("google_iap_app_engine_service_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_data attribute.
    /// </summary>
    public string? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data")?.Value;
        set => this.WithProperty("policy_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
