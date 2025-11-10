using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightCustomPermissionsCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The add_or_run_anomaly_detection_for_analyses attribute.
    /// </summary>
    public TerraformProperty<string>? AddOrRunAnomalyDetectionForAnalyses
    {
        set => SetProperty("add_or_run_anomaly_detection_for_analyses", value);
    }

    /// <summary>
    /// The create_and_update_dashboard_email_reports attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDashboardEmailReports
    {
        set => SetProperty("create_and_update_dashboard_email_reports", value);
    }

    /// <summary>
    /// The create_and_update_data_sources attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDataSources
    {
        set => SetProperty("create_and_update_data_sources", value);
    }

    /// <summary>
    /// The create_and_update_datasets attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDatasets
    {
        set => SetProperty("create_and_update_datasets", value);
    }

    /// <summary>
    /// The create_and_update_themes attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateThemes
    {
        set => SetProperty("create_and_update_themes", value);
    }

    /// <summary>
    /// The create_and_update_threshold_alerts attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateThresholdAlerts
    {
        set => SetProperty("create_and_update_threshold_alerts", value);
    }

    /// <summary>
    /// The create_shared_folders attribute.
    /// </summary>
    public TerraformProperty<string>? CreateSharedFolders
    {
        set => SetProperty("create_shared_folders", value);
    }

    /// <summary>
    /// The create_spice_dataset attribute.
    /// </summary>
    public TerraformProperty<string>? CreateSpiceDataset
    {
        set => SetProperty("create_spice_dataset", value);
    }

    /// <summary>
    /// The export_to_csv attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToCsv
    {
        set => SetProperty("export_to_csv", value);
    }

    /// <summary>
    /// The export_to_csv_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToCsvInScheduledReports
    {
        set => SetProperty("export_to_csv_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_excel attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToExcel
    {
        set => SetProperty("export_to_excel", value);
    }

    /// <summary>
    /// The export_to_excel_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToExcelInScheduledReports
    {
        set => SetProperty("export_to_excel_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_pdf attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToPdf
    {
        set => SetProperty("export_to_pdf", value);
    }

    /// <summary>
    /// The export_to_pdf_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToPdfInScheduledReports
    {
        set => SetProperty("export_to_pdf_in_scheduled_reports", value);
    }

    /// <summary>
    /// The include_content_in_scheduled_reports_email attribute.
    /// </summary>
    public TerraformProperty<string>? IncludeContentInScheduledReportsEmail
    {
        set => SetProperty("include_content_in_scheduled_reports_email", value);
    }

    /// <summary>
    /// The print_reports attribute.
    /// </summary>
    public TerraformProperty<string>? PrintReports
    {
        set => SetProperty("print_reports", value);
    }

    /// <summary>
    /// The rename_shared_folders attribute.
    /// </summary>
    public TerraformProperty<string>? RenameSharedFolders
    {
        set => SetProperty("rename_shared_folders", value);
    }

    /// <summary>
    /// The share_analyses attribute.
    /// </summary>
    public TerraformProperty<string>? ShareAnalyses
    {
        set => SetProperty("share_analyses", value);
    }

    /// <summary>
    /// The share_dashboards attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDashboards
    {
        set => SetProperty("share_dashboards", value);
    }

    /// <summary>
    /// The share_data_sources attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDataSources
    {
        set => SetProperty("share_data_sources", value);
    }

    /// <summary>
    /// The share_datasets attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDatasets
    {
        set => SetProperty("share_datasets", value);
    }

    /// <summary>
    /// The subscribe_dashboard_email_reports attribute.
    /// </summary>
    public TerraformProperty<string>? SubscribeDashboardEmailReports
    {
        set => SetProperty("subscribe_dashboard_email_reports", value);
    }

    /// <summary>
    /// The view_account_spice_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? ViewAccountSpiceCapacity
    {
        set => SetProperty("view_account_spice_capacity", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_custom_permissions resource.
/// </summary>
public class AwsQuicksightCustomPermissions : TerraformResource
{
    public AwsQuicksightCustomPermissions(string name) : base("aws_quicksight_custom_permissions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("aws_account_id");
        SetOutput("custom_permissions_name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    public required TerraformProperty<string> CustomPermissionsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_permissions_name");
        set => SetProperty("custom_permissions_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQuicksightCustomPermissionsCapabilitiesBlock>? Capabilities
    {
        set => SetProperty("capabilities", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
