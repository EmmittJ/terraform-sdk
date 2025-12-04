using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lakeformation_data_lake_settings Terraform data source.
/// Retrieves information about a aws_lakeformation_data_lake_settings.
/// </summary>
public partial class AwsLakeformationDataLakeSettingsDataSource(string name) : TerraformDataSource("aws_lakeformation_data_lake_settings", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    public TerraformSet<string> Admins
        => AsReference("admins");

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformValue<bool> AllowExternalDataFiltering
        => AsReference("allow_external_data_filtering");

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformValue<bool> AllowFullTableExternalDataAccess
        => AsReference("allow_full_table_external_data_access");

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public TerraformList<string> AuthorizedSessionTagValueList
        => AsReference("authorized_session_tag_value_list");

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreateDatabaseDefaultPermissions
        => AsReference("create_database_default_permissions");

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreateTableDefaultPermissions
        => AsReference("create_table_default_permissions");

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public TerraformSet<string> ExternalDataFilteringAllowList
        => AsReference("external_data_filtering_allow_list");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public TerraformSet<string> ReadOnlyAdmins
        => AsReference("read_only_admins");

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    public TerraformList<string> TrustedResourceOwners
        => AsReference("trusted_resource_owners");

}
