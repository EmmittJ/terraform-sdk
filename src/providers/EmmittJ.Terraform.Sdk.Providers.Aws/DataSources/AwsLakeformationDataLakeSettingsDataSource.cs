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
    public TerraformValue<string>? CatalogId { get; set; }

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
    /// The admins attribute.
    /// </summary>
    [TerraformPropertyName("admins")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Admins => new TerraformReference(this, "admins");

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformPropertyName("allow_external_data_filtering")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowExternalDataFiltering => new TerraformReference(this, "allow_external_data_filtering");

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_full_table_external_data_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowFullTableExternalDataAccess => new TerraformReference(this, "allow_full_table_external_data_access");

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformPropertyName("authorized_session_tag_value_list")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AuthorizedSessionTagValueList => new TerraformReference(this, "authorized_session_tag_value_list");

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    [TerraformPropertyName("create_database_default_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CreateDatabaseDefaultPermissions => new TerraformReference(this, "create_database_default_permissions");

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    [TerraformPropertyName("create_table_default_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CreateTableDefaultPermissions => new TerraformReference(this, "create_table_default_permissions");

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformPropertyName("external_data_filtering_allow_list")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ExternalDataFilteringAllowList => new TerraformReference(this, "external_data_filtering_allow_list");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Parameters => new TerraformReference(this, "parameters");

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformPropertyName("read_only_admins")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ReadOnlyAdmins => new TerraformReference(this, "read_only_admins");

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformPropertyName("trusted_resource_owners")]
    // Output-only attribute - read-only reference
    public TerraformList<string> TrustedResourceOwners => new TerraformReference(this, "trusted_resource_owners");

}
