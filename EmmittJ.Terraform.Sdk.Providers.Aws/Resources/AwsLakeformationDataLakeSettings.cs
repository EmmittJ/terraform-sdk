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
    public HashSet<string>? Admins
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("admins")?.Value;
        set => this.WithProperty("admins", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The allow_external_data_filtering attribute.
    /// </summary>
    public bool? AllowExternalDataFiltering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_external_data_filtering")?.Value;
        set => this.WithProperty("allow_external_data_filtering", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_full_table_external_data_access attribute.
    /// </summary>
    public bool? AllowFullTableExternalDataAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_full_table_external_data_access")?.Value;
        set => this.WithProperty("allow_full_table_external_data_access", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The authorized_session_tag_value_list attribute.
    /// </summary>
    public List<string>? AuthorizedSessionTagValueList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authorized_session_tag_value_list")?.Value;
        set => this.WithProperty("authorized_session_tag_value_list", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The external_data_filtering_allow_list attribute.
    /// </summary>
    public HashSet<string>? ExternalDataFilteringAllowList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("external_data_filtering_allow_list")?.Value;
        set => this.WithProperty("external_data_filtering_allow_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The read_only_admins attribute.
    /// </summary>
    public HashSet<string>? ReadOnlyAdmins
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("read_only_admins")?.Value;
        set => this.WithProperty("read_only_admins", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The trusted_resource_owners attribute.
    /// </summary>
    public List<string>? TrustedResourceOwners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("trusted_resource_owners")?.Value;
        set => this.WithProperty("trusted_resource_owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
