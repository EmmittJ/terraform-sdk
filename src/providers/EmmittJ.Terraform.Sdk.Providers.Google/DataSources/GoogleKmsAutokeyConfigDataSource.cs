using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_autokey_config.
/// </summary>
public class GoogleKmsAutokeyConfigDataSource : TerraformDataSource
{
    public GoogleKmsAutokeyConfigDataSource(string name) : base("google_kms_autokey_config", name)
    {
    }

    /// <summary>
    /// The folder for which to retrieve config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformPropertyName("folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    [TerraformPropertyName("key_project")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyProject => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_project");

}
