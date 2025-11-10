using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetManagementGroupFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetManagementGroupNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactEmails is required")]
    public List<TerraformProperty<string>>? ContactEmails
    {
        get => GetProperty<List<TerraformProperty<string>>>("contact_emails");
        set => WithProperty("contact_emails", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        get => GetProperty<TerraformProperty<string>>("operator");
        set => WithProperty("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        get => GetProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    public TerraformProperty<string>? ThresholdType
    {
        get => GetProperty<TerraformProperty<string>>("threshold_type");
        set => WithProperty("threshold_type", value);
    }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetManagementGroupTimePeriodBlock : TerraformBlock
{
    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => WithProperty("end_date", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformProperty<string> StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => WithProperty("start_date", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetManagementGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_consumption_budget_management_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermConsumptionBudgetManagementGroup : TerraformResource
{
    public AzurermConsumptionBudgetManagementGroup(string name) : base("azurerm_consumption_budget_management_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<double> Amount
    {
        get => GetProperty<TerraformProperty<double>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformProperty<string>? TimeGrain
    {
        get => GetProperty<TerraformProperty<string>>("time_grain");
        set => this.WithProperty("time_grain", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AzurermConsumptionBudgetManagementGroupFilterBlock>? Filter
    {
        get => GetProperty<List<AzurermConsumptionBudgetManagementGroupFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    public HashSet<AzurermConsumptionBudgetManagementGroupNotificationBlock>? Notification
    {
        get => GetProperty<HashSet<AzurermConsumptionBudgetManagementGroupNotificationBlock>>("notification");
        set => this.WithProperty("notification", value);
    }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public List<AzurermConsumptionBudgetManagementGroupTimePeriodBlock>? TimePeriod
    {
        get => GetProperty<List<AzurermConsumptionBudgetManagementGroupTimePeriodBlock>>("time_period");
        set => this.WithProperty("time_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConsumptionBudgetManagementGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermConsumptionBudgetManagementGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
