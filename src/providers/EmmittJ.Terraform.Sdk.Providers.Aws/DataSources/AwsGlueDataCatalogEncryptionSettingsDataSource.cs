using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_data_catalog_encryption_settings.
/// </summary>
public partial class AwsGlueDataCatalogEncryptionSettingsDataSource : TerraformDataSource
{
    public AwsGlueDataCatalogEncryptionSettingsDataSource(string name) : base("aws_glue_data_catalog_encryption_settings", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformProperty("catalog_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The data_catalog_encryption_settings attribute.
    /// </summary>
    [TerraformProperty("data_catalog_encryption_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataCatalogEncryptionSettings { get; }

}
