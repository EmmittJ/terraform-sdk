using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_workspace resource.
/// </summary>
public class AzurermLogAnalyticsWorkspace : TerraformResource
{
    public AzurermLogAnalyticsWorkspace(string name) : base("azurerm_log_analytics_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_shared_key");
        this.DeclareOutput("secondary_shared_key");
        this.DeclareOutput("workspace_id");
    }

    /// <summary>
    /// The allow_resource_only_permissions attribute.
    /// </summary>
    public bool? AllowResourceOnlyPermissions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_resource_only_permissions")?.Value;
        set => this.WithProperty("allow_resource_only_permissions", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    public bool? CmkForQueryForced
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cmk_for_query_forced")?.Value;
        set => this.WithProperty("cmk_for_query_forced", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public double? DailyQuotaGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("daily_quota_gb")?.Value;
        set => this.WithProperty("daily_quota_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public string? DataCollectionRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_collection_rule_id")?.Value;
        set => this.WithProperty("data_collection_rule_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    public bool? ImmediateDataPurgeOn30DaysEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("immediate_data_purge_on_30_days_enabled")?.Value;
        set => this.WithProperty("immediate_data_purge_on_30_days_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public bool? InternetIngestionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_ingestion_enabled")?.Value;
        set => this.WithProperty("internet_ingestion_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public bool? InternetQueryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_query_enabled")?.Value;
        set => this.WithProperty("internet_query_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_disabled")?.Value;
        set => this.WithProperty("local_authentication_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public bool? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled")?.Value;
        set => this.WithProperty("local_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    public double? ReservationCapacityInGbPerDay
    {
        get => GetProperty<TerraformLiteralProperty<double>>("reservation_capacity_in_gb_per_day")?.Value;
        set => this.WithProperty("reservation_capacity_in_gb_per_day", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public double? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days")?.Value;
        set => this.WithProperty("retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The primary_shared_key attribute.
    /// </summary>
    public TerraformExpression PrimarySharedKey => this["primary_shared_key"];

    /// <summary>
    /// The secondary_shared_key attribute.
    /// </summary>
    public TerraformExpression SecondarySharedKey => this["secondary_shared_key"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

}
