using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_data_lake_settings.
/// </summary>
public class AwsLakeformationDataLakeSettingsDataSource : TerraformDataSource
{
    public AwsLakeformationDataLakeSettingsDataSource(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The admins attribute.
    /// </summary>
    [TerraformPropertyName("admins")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Admins => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "admins");

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformPropertyName("allow_external_data_filtering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowExternalDataFiltering => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_external_data_filtering");

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_full_table_external_data_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowFullTableExternalDataAccess => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_full_table_external_data_access");

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformPropertyName("authorized_session_tag_value_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AuthorizedSessionTagValueList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "authorized_session_tag_value_list");

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    [TerraformPropertyName("create_database_default_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CreateDatabaseDefaultPermissions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "create_database_default_permissions");

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    [TerraformPropertyName("create_table_default_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CreateTableDefaultPermissions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "create_table_default_permissions");

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformPropertyName("external_data_filtering_allow_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExternalDataFilteringAllowList => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "external_data_filtering_allow_list");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformPropertyName("read_only_admins")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ReadOnlyAdmins => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "read_only_admins");

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformPropertyName("trusted_resource_owners")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> TrustedResourceOwners => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "trusted_resource_owners");

}
