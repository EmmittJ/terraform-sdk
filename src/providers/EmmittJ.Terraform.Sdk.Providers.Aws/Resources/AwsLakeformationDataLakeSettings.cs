using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_database_default_permissions in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock() : TerraformBlock("create_database_default_permissions")
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformProperty("principal")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for create_table_default_permissions in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock() : TerraformBlock("create_table_default_permissions")
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformProperty("principal")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Manages a aws_lakeformation_data_lake_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLakeformationDataLakeSettings : TerraformResource
{
    public AwsLakeformationDataLakeSettings(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    [TerraformProperty("admins")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Admins { get; set; }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformProperty("allow_external_data_filtering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowExternalDataFiltering { get; set; }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformProperty("allow_full_table_external_data_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformProperty("authorized_session_tag_value_list")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> AuthorizedSessionTagValueList { get; set; }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformProperty("external_data_filtering_allow_list")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ExternalDataFilteringAllowList { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Parameters { get; set; }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformProperty("read_only_admins")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ReadOnlyAdmins { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformProperty("trusted_resource_owners")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> TrustedResourceOwners { get; set; }

    /// <summary>
    /// Block for create_database_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    [TerraformProperty("create_database_default_permissions")]
    public TerraformList<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock> CreateDatabaseDefaultPermissions { get; set; } = new();

    /// <summary>
    /// Block for create_table_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    [TerraformProperty("create_table_default_permissions")]
    public TerraformList<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock> CreateTableDefaultPermissions { get; set; } = new();

}
