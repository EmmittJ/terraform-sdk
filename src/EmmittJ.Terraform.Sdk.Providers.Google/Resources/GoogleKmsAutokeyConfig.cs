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
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    public TerraformProperty<string>? KeyProject
    {
        get => GetProperty<TerraformProperty<string>>("key_project");
        set => this.WithProperty("key_project", value);
    }

    /// <summary>
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
