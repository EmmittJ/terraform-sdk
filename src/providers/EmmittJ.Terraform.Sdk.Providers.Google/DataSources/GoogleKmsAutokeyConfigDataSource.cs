using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_autokey_config.
/// </summary>
public class GoogleKmsAutokeyConfigDataSource : TerraformDataSource
{
    public GoogleKmsAutokeyConfigDataSource(string name) : base("google_kms_autokey_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
        this.WithOutput("key_project");
    }

    /// <summary>
    /// The folder for which to retrieve config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetRequiredProperty<TerraformProperty<string>>("folder");
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
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression KeyProject => this["key_project"];

}
