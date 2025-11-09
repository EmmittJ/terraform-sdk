using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_data_lake_settings resource.
/// </summary>
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
    public TerraformProperty<HashSet<string>>? Admins
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("admins");
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
    public TerraformProperty<List<string>>? AuthorizedSessionTagValueList
    {
        get => GetProperty<TerraformProperty<List<string>>>("authorized_session_tag_value_list");
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
    public TerraformProperty<HashSet<string>>? ExternalDataFilteringAllowList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("external_data_filtering_allow_list");
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
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ReadOnlyAdmins
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("read_only_admins");
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
    public TerraformProperty<List<string>>? TrustedResourceOwners
    {
        get => GetProperty<TerraformProperty<List<string>>>("trusted_resource_owners");
        set => this.WithProperty("trusted_resource_owners", value);
    }

}
