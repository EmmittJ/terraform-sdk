using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_catalog_encryption_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_glue_data_catalog_encryption_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueDataCatalogEncryptionSettings : TerraformResource
{
    public AwsGlueDataCatalogEncryptionSettings(string name) : base("aws_glue_data_catalog_encryption_settings", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

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
    /// Block for data_catalog_encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataCatalogEncryptionSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataCatalogEncryptionSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCatalogEncryptionSettings block(s) allowed")]
    [TerraformProperty("data_catalog_encryption_settings")]
    public partial TerraformList<TerraformBlock<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock>>? DataCatalogEncryptionSettings { get; set; }

}
