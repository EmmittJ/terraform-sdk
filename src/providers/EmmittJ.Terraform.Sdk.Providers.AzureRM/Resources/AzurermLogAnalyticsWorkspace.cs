using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogAnalyticsWorkspaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogAnalyticsWorkspace : TerraformResource
{
    public AzurermLogAnalyticsWorkspace(string name) : base("azurerm_log_analytics_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_shared_key");
        SetOutput("secondary_shared_key");
        SetOutput("workspace_id");
        SetOutput("allow_resource_only_permissions");
        SetOutput("cmk_for_query_forced");
        SetOutput("daily_quota_gb");
        SetOutput("data_collection_rule_id");
        SetOutput("id");
        SetOutput("immediate_data_purge_on_30_days_enabled");
        SetOutput("internet_ingestion_enabled");
        SetOutput("internet_query_enabled");
        SetOutput("local_authentication_disabled");
        SetOutput("local_authentication_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("reservation_capacity_in_gb_per_day");
        SetOutput("resource_group_name");
        SetOutput("retention_in_days");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The allow_resource_only_permissions attribute.
    /// </summary>
    public TerraformProperty<bool> AllowResourceOnlyPermissions
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_resource_only_permissions");
        set => SetProperty("allow_resource_only_permissions", value);
    }

    /// <summary>
    /// The cmk_for_query_forced attribute.
    /// </summary>
    public TerraformProperty<bool> CmkForQueryForced
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cmk_for_query_forced");
        set => SetProperty("cmk_for_query_forced", value);
    }

    /// <summary>
    /// The daily_quota_gb attribute.
    /// </summary>
    public TerraformProperty<double> DailyQuotaGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("daily_quota_gb");
        set => SetProperty("daily_quota_gb", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformProperty<string> DataCollectionRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_collection_rule_id");
        set => SetProperty("data_collection_rule_id", value);
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
    /// The immediate_data_purge_on_30_days_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ImmediateDataPurgeOn30DaysEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("immediate_data_purge_on_30_days_enabled");
        set => SetProperty("immediate_data_purge_on_30_days_enabled", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetIngestionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_ingestion_enabled");
        set => SetProperty("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetQueryEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_query_enabled");
        set => SetProperty("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> LocalAuthenticationDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_disabled");
        set => SetProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_enabled");
        set => SetProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The reservation_capacity_in_gb_per_day attribute.
    /// </summary>
    public TerraformProperty<double> ReservationCapacityInGbPerDay
    {
        get => GetRequiredOutput<TerraformProperty<double>>("reservation_capacity_in_gb_per_day");
        set => SetProperty("reservation_capacity_in_gb_per_day", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_in_days");
        set => SetProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLogAnalyticsWorkspaceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
