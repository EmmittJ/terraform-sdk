using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_data_lake_settings.
/// </summary>
public class AwsLakeformationDataLakeSettingsDataSource : TerraformDataSource
{
    public AwsLakeformationDataLakeSettingsDataSource(string name) : base("aws_lakeformation_data_lake_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("admins");
        SetOutput("allow_external_data_filtering");
        SetOutput("allow_full_table_external_data_access");
        SetOutput("authorized_session_tag_value_list");
        SetOutput("create_database_default_permissions");
        SetOutput("create_table_default_permissions");
        SetOutput("external_data_filtering_allow_list");
        SetOutput("parameters");
        SetOutput("read_only_admins");
        SetOutput("trusted_resource_owners");
        SetOutput("catalog_id");
        SetOutput("id");
        SetOutput("region");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The admins attribute.
    /// </summary>
    public TerraformExpression Admins => this["admins"];

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public TerraformExpression AllowExternalDataFiltering => this["allow_external_data_filtering"];

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public TerraformExpression AllowFullTableExternalDataAccess => this["allow_full_table_external_data_access"];

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public TerraformExpression AuthorizedSessionTagValueList => this["authorized_session_tag_value_list"];

    /// <summary>
    /// The create_database_default_permissions attribute.
    /// </summary>
    public TerraformExpression CreateDatabaseDefaultPermissions => this["create_database_default_permissions"];

    /// <summary>
    /// The create_table_default_permissions attribute.
    /// </summary>
    public TerraformExpression CreateTableDefaultPermissions => this["create_table_default_permissions"];

    /// <summary>
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public TerraformExpression ExternalDataFilteringAllowList => this["external_data_filtering_allow_list"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public TerraformExpression ReadOnlyAdmins => this["read_only_admins"];

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    public TerraformExpression TrustedResourceOwners => this["trusted_resource_owners"];

}
