using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_app_engine_version_iam_policy.
/// </summary>
public class GoogleIapAppEngineVersionIamPolicyDataSource : TerraformDataSource
{
    public GoogleIapAppEngineVersionIamPolicyDataSource(string name) : base("google_iap_app_engine_version_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
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
