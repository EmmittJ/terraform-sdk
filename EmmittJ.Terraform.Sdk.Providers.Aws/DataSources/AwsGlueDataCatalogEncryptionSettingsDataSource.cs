using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_data_catalog_encryption_settings.
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataSource : TerraformDataSource
{
    public AwsGlueDataCatalogEncryptionSettingsDataSource(string name) : base("aws_glue_data_catalog_encryption_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("data_catalog_encryption_settings");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The data_catalog_encryption_settings attribute.
    /// </summary>
    public TerraformExpression DataCatalogEncryptionSettings => this["data_catalog_encryption_settings"];

}
