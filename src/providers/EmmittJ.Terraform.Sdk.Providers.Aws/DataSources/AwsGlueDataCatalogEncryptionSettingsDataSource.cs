using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_data_catalog_encryption_settings.
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataSource : TerraformDataSource
{
    public AwsGlueDataCatalogEncryptionSettingsDataSource(string name) : base("aws_glue_data_catalog_encryption_settings", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformPropertyName("catalog_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The data_catalog_encryption_settings attribute.
    /// </summary>
    [TerraformPropertyName("data_catalog_encryption_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataCatalogEncryptionSettings => new TerraformReference(this, "data_catalog_encryption_settings");

}
