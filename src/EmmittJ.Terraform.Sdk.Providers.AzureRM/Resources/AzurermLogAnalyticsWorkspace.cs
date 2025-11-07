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
    public TerraformProperty<bool>? AllowResourceOnlyPermissions
    {
        get => GetProperty<TerraformProperty<bool>>("allow_resource_only_permissions");
        set => this.WithProperty("allow_resource_only_permissions", value);
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    public TerraformProperty<bool>? CmkForQueryForced
    {
        get => GetProperty<TerraformProperty<bool>>("cmk_for_query_forced");
        set => this.WithProperty("cmk_for_query_forced", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DailyQuotaGb
    {
        get => GetProperty<TerraformProperty<double>>("daily_quota_gb");
        set => this.WithProperty("daily_quota_gb", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataCollectionRuleId
    {
        get => GetProperty<TerraformProperty<string>>("data_collection_rule_id");
        set => this.WithProperty("data_collection_rule_id", value);
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
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImmediateDataPurgeOn30DaysEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("immediate_data_purge_on_30_days_enabled");
        set => this.WithProperty("immediate_data_purge_on_30_days_enabled", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetIngestionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_ingestion_enabled");
        set => this.WithProperty("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetQueryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_query_enabled");
        set => this.WithProperty("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_disabled");
        set => this.WithProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    public TerraformProperty<double>? ReservationCapacityInGbPerDay
    {
        get => GetProperty<TerraformProperty<double>>("reservation_capacity_in_gb_per_day");
        set => this.WithProperty("reservation_capacity_in_gb_per_day", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
