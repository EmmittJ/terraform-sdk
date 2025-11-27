using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_data_catalog_encryption_settings Terraform data source.
/// Retrieves information about a aws_glue_data_catalog_encryption_settings.
/// </summary>
public partial class AwsGlueDataCatalogEncryptionSettingsDataSource(string name) : TerraformDataSource("aws_glue_data_catalog_encryption_settings", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The data_catalog_encryption_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataCatalogEncryptionSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_catalog_encryption_settings").ResolveNodes(ctx));
    }

}
