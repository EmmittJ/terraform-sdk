using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_catalog_encryption_settings in .
/// Nesting mode: list
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_glue_data_catalog_encryption_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueDataCatalogEncryptionSettings : TerraformResource
{
    public AwsGlueDataCatalogEncryptionSettings(string name) : base("aws_glue_data_catalog_encryption_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for data_catalog_encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataCatalogEncryptionSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCatalogEncryptionSettings block(s) allowed")]
    public List<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock>? DataCatalogEncryptionSettings
    {
        get => GetProperty<List<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock>>("data_catalog_encryption_settings");
        set => this.WithProperty("data_catalog_encryption_settings", value);
    }

}
