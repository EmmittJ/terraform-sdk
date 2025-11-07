using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_app_engine_version_iam_member resource.
/// </summary>
public class GoogleIapAppEngineVersionIamMember : TerraformResource
{
    public GoogleIapAppEngineVersionIamMember(string name) : base("google_iap_app_engine_version_iam_member", name)
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
    /// The member attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member");
        set => this.WithProperty("member", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
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

}
