using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_autokey_config resource.
/// </summary>
public class GoogleKmsAutokeyConfig : TerraformResource
{
    public GoogleKmsAutokeyConfig(string name) : base("google_kms_autokey_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The folder for which to retrieve config.
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
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    public string? KeyProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_project")?.Value;
        set => this.WithProperty("key_project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
