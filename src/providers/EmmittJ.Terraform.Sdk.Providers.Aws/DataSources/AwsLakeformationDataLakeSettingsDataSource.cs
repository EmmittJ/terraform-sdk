using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_data_lake_settings.
/// </summary>
public partial class AwsLakeformationDataLakeSettingsDataSource : TerraformDataSource
{
    public AwsLakeformationDataLakeSettingsDataSource(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    [TerraformProperty("admins")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Admins { get; }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformProperty("allow_external_data_filtering")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowExternalDataFiltering { get; }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformProperty("allow_full_table_external_data_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowFullTableExternalDataAccess { get; }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformProperty("authorized_session_tag_value_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AuthorizedSessionTagValueList { get; }

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    [TerraformProperty("create_database_default_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CreateDatabaseDefaultPermissions { get; }

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    [TerraformProperty("create_table_default_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CreateTableDefaultPermissions { get; }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformProperty("external_data_filtering_allow_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ExternalDataFilteringAllowList { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Parameters { get; }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformProperty("read_only_admins")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ReadOnlyAdmins { get; }

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformProperty("trusted_resource_owners")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> TrustedResourceOwners { get; }

}
