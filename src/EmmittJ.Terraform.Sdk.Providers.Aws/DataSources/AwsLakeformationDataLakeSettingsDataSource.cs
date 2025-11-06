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
        this.DeclareOutput("admins");
        this.DeclareOutput("allow_external_data_filtering");
        this.DeclareOutput("allow_full_table_external_data_access");
        this.DeclareOutput("authorized_session_tag_value_list");
        this.DeclareOutput("create_database_default_permissions");
        this.DeclareOutput("create_table_default_permissions");
        this.DeclareOutput("external_data_filtering_allow_list");
        this.DeclareOutput("parameters");
        this.DeclareOutput("read_only_admins");
        this.DeclareOutput("trusted_resource_owners");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
