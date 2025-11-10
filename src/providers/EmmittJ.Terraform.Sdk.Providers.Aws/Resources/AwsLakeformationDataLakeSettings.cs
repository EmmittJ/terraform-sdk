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
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        set => SetProperty("principal", value);
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
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        set => SetProperty("principal", value);
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
        SetOutput("admins");
        SetOutput("allow_external_data_filtering");
        SetOutput("allow_full_table_external_data_access");
        SetOutput("authorized_session_tag_value_list");
        SetOutput("catalog_id");
        SetOutput("external_data_filtering_allow_list");
        SetOutput("id");
        SetOutput("parameters");
        SetOutput("read_only_admins");
        SetOutput("region");
        SetOutput("trusted_resource_owners");
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Admins
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("admins");
        set => SetProperty("admins", value);
    }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformProperty<bool> AllowExternalDataFiltering
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_external_data_filtering");
        set => SetProperty("allow_external_data_filtering", value);
    }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformProperty<bool> AllowFullTableExternalDataAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_full_table_external_data_access");
        set => SetProperty("allow_full_table_external_data_access", value);
    }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public List<TerraformProperty<string>> AuthorizedSessionTagValueList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("authorized_session_tag_value_list");
        set => SetProperty("authorized_session_tag_value_list", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExternalDataFilteringAllowList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("external_data_filtering_allow_list");
        set => SetProperty("external_data_filtering_allow_list", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ReadOnlyAdmins
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("read_only_admins");
        set => SetProperty("read_only_admins", value);
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
    /// The trusted_resource_owners attribute.
    /// </summary>
    public List<TerraformProperty<string>> TrustedResourceOwners
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("trusted_resource_owners");
        set => SetProperty("trusted_resource_owners", value);
    }

    /// <summary>
    /// Block for create_database_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    public List<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>? CreateDatabaseDefaultPermissions
    {
        set => SetProperty("create_database_default_permissions", value);
    }

    /// <summary>
    /// Block for create_table_default_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    public List<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>? CreateTableDefaultPermissions
    {
        set => SetProperty("create_table_default_permissions", value);
    }

}
