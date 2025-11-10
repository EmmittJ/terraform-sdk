using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_database_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => WithProperty("principal", value);
    }

}

/// <summary>
/// Block type for create_table_default_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => WithProperty("principal", value);
    }

}

/// <summary>
/// Manages a aws_lakeformation_data_lake_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLakeformationDataLakeSettings : TerraformResource
{
    public AwsLakeformationDataLakeSettings(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Admins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("admins");
        set => this.WithProperty("admins", value);
    }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowExternalDataFiltering
    {
        get => GetProperty<TerraformProperty<bool>>("allow_external_data_filtering");
        set => this.WithProperty("allow_external_data_filtering", value);
    }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowFullTableExternalDataAccess
    {
        get => GetProperty<TerraformProperty<bool>>("allow_full_table_external_data_access");
        set => this.WithProperty("allow_full_table_external_data_access", value);
    }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AuthorizedSessionTagValueList
    {
        get => GetProperty<List<TerraformProperty<string>>>("authorized_session_tag_value_list");
        set => this.WithProperty("authorized_session_tag_value_list", value);
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
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExternalDataFilteringAllowList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("external_data_filtering_allow_list");
        set => this.WithProperty("external_data_filtering_allow_list", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ReadOnlyAdmins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("read_only_admins");
        set => this.WithProperty("read_only_admins", value);
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
    /// The trusted_resource_owners attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedResourceOwners
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_resource_owners");
        set => this.WithProperty("trusted_resource_owners", value);
    }

    /// <summary>
    /// Block for create_database_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    public List<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>? CreateDatabaseDefaultPermissions
    {
        get => GetProperty<List<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>>("create_database_default_permissions");
        set => this.WithProperty("create_database_default_permissions", value);
    }

    /// <summary>
    /// Block for create_table_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    public List<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>? CreateTableDefaultPermissions
    {
        get => GetProperty<List<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>>("create_table_default_permissions");
        set => this.WithProperty("create_table_default_permissions", value);
    }

}
