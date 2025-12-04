using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_database_default_permissions in AwsLakeformationDataLakeSettings.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_database_default_permissions";

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformSet<string> Permissions
    {
        get => GetArgument<TerraformSet<string>>("permissions") ?? AsReference("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal") ?? AsReference("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for create_table_default_permissions in AwsLakeformationDataLakeSettings.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_table_default_permissions";

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformSet<string> Permissions
    {
        get => GetArgument<TerraformSet<string>>("permissions") ?? AsReference("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformValue<string> Principal
    {
        get => GetArgument<TerraformValue<string>>("principal") ?? AsReference("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Represents a aws_lakeformation_data_lake_settings Terraform resource.
/// Manages a aws_lakeformation_data_lake_settings resource.
/// </summary>
public partial class AwsLakeformationDataLakeSettings(string name) : TerraformResource("aws_lakeformation_data_lake_settings", name)
{
    /// <summary>
    /// The admins attribute.
    /// </summary>
    public TerraformSet<string> Admins
    {
        get => GetArgument<TerraformSet<string>>("admins") ?? AsReference("admins");
        set => SetArgument("admins", value);
    }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformValue<bool>? AllowExternalDataFiltering
    {
        get => GetArgument<TerraformValue<bool>>("allow_external_data_filtering");
        set => SetArgument("allow_external_data_filtering", value);
    }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformValue<bool>? AllowFullTableExternalDataAccess
    {
        get => GetArgument<TerraformValue<bool>>("allow_full_table_external_data_access");
        set => SetArgument("allow_full_table_external_data_access", value);
    }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public TerraformList<string> AuthorizedSessionTagValueList
    {
        get => GetArgument<TerraformList<string>>("authorized_session_tag_value_list") ?? AsReference("authorized_session_tag_value_list");
        set => SetArgument("authorized_session_tag_value_list", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public TerraformSet<string> ExternalDataFilteringAllowList
    {
        get => GetArgument<TerraformSet<string>>("external_data_filtering_allow_list") ?? AsReference("external_data_filtering_allow_list");
        set => SetArgument("external_data_filtering_allow_list", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters") ?? AsReference("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public TerraformSet<string> ReadOnlyAdmins
    {
        get => GetArgument<TerraformSet<string>>("read_only_admins") ?? AsReference("read_only_admins");
        set => SetArgument("read_only_admins", value);
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
    /// The trusted_resource_owners attribute.
    /// </summary>
    public TerraformList<string> TrustedResourceOwners
    {
        get => GetArgument<TerraformList<string>>("trusted_resource_owners") ?? AsReference("trusted_resource_owners");
        set => SetArgument("trusted_resource_owners", value);
    }

    /// <summary>
    /// CreateDatabaseDefaultPermissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateDatabaseDefaultPermissions block(s) allowed")]
    public TerraformList<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>? CreateDatabaseDefaultPermissions
    {
        get => GetArgument<TerraformList<AwsLakeformationDataLakeSettingsCreateDatabaseDefaultPermissionsBlock>>("create_database_default_permissions");
        set => SetArgument("create_database_default_permissions", value);
    }

    /// <summary>
    /// CreateTableDefaultPermissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 CreateTableDefaultPermissions block(s) allowed")]
    public TerraformList<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>? CreateTableDefaultPermissions
    {
        get => GetArgument<TerraformList<AwsLakeformationDataLakeSettingsCreateTableDefaultPermissionsBlock>>("create_table_default_permissions");
        set => SetArgument("create_table_default_permissions", value);
    }

}
