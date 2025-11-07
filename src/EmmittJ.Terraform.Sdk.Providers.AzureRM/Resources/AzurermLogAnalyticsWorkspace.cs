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
    public TerraformLiteralProperty<bool>? AllowResourceOnlyPermissions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_resource_only_permissions");
        set => this.WithProperty("allow_resource_only_permissions", value);
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CmkForQueryForced
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cmk_for_query_forced");
        set => this.WithProperty("cmk_for_query_forced", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DailyQuotaGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("daily_quota_gb");
        set => this.WithProperty("daily_quota_gb", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataCollectionRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_collection_rule_id");
        set => this.WithProperty("data_collection_rule_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ImmediateDataPurgeOn30DaysEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("immediate_data_purge_on_30_days_enabled");
        set => this.WithProperty("immediate_data_purge_on_30_days_enabled", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InternetIngestionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_ingestion_enabled");
        set => this.WithProperty("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InternetQueryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_query_enabled");
        set => this.WithProperty("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<bool>? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_disabled");
        set => this.WithProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReservationCapacityInGbPerDay
    {
        get => GetProperty<TerraformLiteralProperty<double>>("reservation_capacity_in_gb_per_day");
        set => this.WithProperty("reservation_capacity_in_gb_per_day", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
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
