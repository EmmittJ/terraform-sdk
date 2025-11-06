using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_folder_iam_audit_config resource.
/// </summary>
public class GoogleFolderIamAuditConfig : TerraformResource
{
    public GoogleFolderIamAuditConfig(string name) : base("google_folder_iam_audit_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Service which will be enabled for audit logging. The special value allServices covers all services.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag of iam policy
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
