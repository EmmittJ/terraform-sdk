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
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The admins attribute.
    /// </summary>
    public TerraformSet<string> Admins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admins").ResolveNodes(ctx));
    }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformValue<bool> AllowExternalDataFiltering
    {
        get => new TerraformReference<bool>(this, "allow_external_data_filtering");
    }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformValue<bool> AllowFullTableExternalDataAccess
    {
        get => new TerraformReference<bool>(this, "allow_full_table_external_data_access");
    }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public TerraformList<string> AuthorizedSessionTagValueList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "authorized_session_tag_value_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreateDatabaseDefaultPermissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "create_database_default_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreateTableDefaultPermissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "create_table_default_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public TerraformSet<string> ExternalDataFilteringAllowList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "external_data_filtering_allow_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public TerraformSet<string> ReadOnlyAdmins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "read_only_admins").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    public TerraformList<string> TrustedResourceOwners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_resource_owners").ResolveNodes(ctx));
    }

}
