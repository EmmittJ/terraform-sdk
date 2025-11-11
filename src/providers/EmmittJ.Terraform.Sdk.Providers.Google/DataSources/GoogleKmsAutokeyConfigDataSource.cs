using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_autokey_config.
/// </summary>
public partial class GoogleKmsAutokeyConfigDataSource : TerraformDataSource
{
    public GoogleKmsAutokeyConfigDataSource(string name) : base("google_kms_autokey_config", name)
    {
    }

    /// <summary>
    /// The folder for which to retrieve config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformProperty("folder")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The etag of the AutokeyConfig for optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The target key project for a given folder where KMS Autokey will provision a
    /// CryptoKey for any new KeyHandle the Developer creates. Should have the form
    /// &#39;projects/&amp;lt;project_id_or_number&amp;gt;&#39;.
    /// </summary>
    [TerraformProperty("key_project")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyProject { get; }

}
