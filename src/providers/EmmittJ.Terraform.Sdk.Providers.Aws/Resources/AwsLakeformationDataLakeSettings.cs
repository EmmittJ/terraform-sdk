using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_database_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Permissions { get; set; } = default!;

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Principal { get; set; } = default!;

}

/// <summary>
/// Block type for create_table_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Permissions { get; set; } = default!;

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Principal { get; set; } = default!;

}

/// <summary>
/// Manages a aws_lakeformation_data_lake_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLakeformationDataLakeSettings : TerraformResource
{
    public AwsLakeformationDataLakeSettings(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    [TerraformPropertyName("admins")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Admins { get; set; } = default!;

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformPropertyName("allow_external_data_filtering")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowExternalDataFiltering { get; set; }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_full_table_external_data_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformPropertyName("authorized_session_tag_value_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> AuthorizedSessionTagValueList { get; set; } = default!;

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformPropertyName("external_data_filtering_allow_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ExternalDataFilteringAllowList { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Parameters { get; set; } = default!;

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformPropertyName("read_only_admins")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ReadOnlyAdmins { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformPropertyName("trusted_resource_owners")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> TrustedResourceOwners { get; set; } = default!;

    /// <summary>
    /// Block for create_database_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    [TerraformPropertyName("create_database_default_permissions")]
    public TerraformList<TerraformBlock<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>>? CreateDatabaseDefaultPermissions { get; set; }

    /// <summary>
    /// Block for create_table_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    [TerraformPropertyName("create_table_default_permissions")]
    public TerraformList<TerraformBlock<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>>? CreateTableDefaultPermissions { get; set; }

}
