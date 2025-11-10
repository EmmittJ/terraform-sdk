using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_database_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Permissions { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "permissions");

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Principal { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "principal");

}

/// <summary>
/// Block type for create_table_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Permissions { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "permissions");

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Principal { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "principal");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Admins { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "admins");

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    [TerraformPropertyName("allow_external_data_filtering")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowExternalDataFiltering { get; set; }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_full_table_external_data_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowFullTableExternalDataAccess { get; set; }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    [TerraformPropertyName("authorized_session_tag_value_list")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AuthorizedSessionTagValueList { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "authorized_session_tag_value_list");

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CatalogId { get; set; }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    [TerraformPropertyName("external_data_filtering_allow_list")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExternalDataFilteringAllowList { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "external_data_filtering_allow_list");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    [TerraformPropertyName("read_only_admins")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ReadOnlyAdmins { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "read_only_admins");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    [TerraformPropertyName("trusted_resource_owners")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> TrustedResourceOwners { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "trusted_resource_owners");

    /// <summary>
    /// Block for create_database_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    [TerraformPropertyName("create_database_default_permissions")]
    public TerraformList<TerraformBlock<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>>? CreateDatabaseDefaultPermissions { get; set; } = new();

    /// <summary>
    /// Block for create_table_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    [TerraformPropertyName("create_table_default_permissions")]
    public TerraformList<TerraformBlock<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>>? CreateTableDefaultPermissions { get; set; } = new();

}
