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
        SetOutput("data_catalog_encryption_settings");
        SetOutput("catalog_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The data_catalog_encryption_settings attribute.
    /// </summary>
    public TerraformExpression DataCatalogEncryptionSettings => this["data_catalog_encryption_settings"];

}
