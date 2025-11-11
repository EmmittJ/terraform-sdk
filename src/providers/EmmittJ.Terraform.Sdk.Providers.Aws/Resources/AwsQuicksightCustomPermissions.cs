using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightCustomPermissionsCapabilitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The add_or_run_anomaly_detection_for_analyses attribute.
    /// </summary>
    [TerraformProperty("add_or_run_anomaly_detection_for_analyses")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AddOrRunAnomalyDetectionForAnalyses { get; set; }

    /// <summary>
    /// The create_and_update_dashboard_email_reports attribute.
    /// </summary>
    [TerraformProperty("create_and_update_dashboard_email_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAndUpdateDashboardEmailReports { get; set; }

    /// <summary>
    /// The create_and_update_data_sources attribute.
    /// </summary>
    [TerraformProperty("create_and_update_data_sources")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAndUpdateDataSources { get; set; }

    /// <summary>
    /// The create_and_update_datasets attribute.
    /// </summary>
    [TerraformProperty("create_and_update_datasets")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAndUpdateDatasets { get; set; }

    /// <summary>
    /// The create_and_update_themes attribute.
    /// </summary>
    [TerraformProperty("create_and_update_themes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAndUpdateThemes { get; set; }

    /// <summary>
    /// The create_and_update_threshold_alerts attribute.
    /// </summary>
    [TerraformProperty("create_and_update_threshold_alerts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAndUpdateThresholdAlerts { get; set; }

    /// <summary>
    /// The create_shared_folders attribute.
    /// </summary>
    [TerraformProperty("create_shared_folders")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateSharedFolders { get; set; }

    /// <summary>
    /// The create_spice_dataset attribute.
    /// </summary>
    [TerraformProperty("create_spice_dataset")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateSpiceDataset { get; set; }

    /// <summary>
    /// The export_to_csv attribute.
    /// </summary>
    [TerraformProperty("export_to_csv")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToCsv { get; set; }

    /// <summary>
    /// The export_to_csv_in_scheduled_reports attribute.
    /// </summary>
    [TerraformProperty("export_to_csv_in_scheduled_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToCsvInScheduledReports { get; set; }

    /// <summary>
    /// The export_to_excel attribute.
    /// </summary>
    [TerraformProperty("export_to_excel")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToExcel { get; set; }

    /// <summary>
    /// The export_to_excel_in_scheduled_reports attribute.
    /// </summary>
    [TerraformProperty("export_to_excel_in_scheduled_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToExcelInScheduledReports { get; set; }

    /// <summary>
    /// The export_to_pdf attribute.
    /// </summary>
    [TerraformProperty("export_to_pdf")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToPdf { get; set; }

    /// <summary>
    /// The export_to_pdf_in_scheduled_reports attribute.
    /// </summary>
    [TerraformProperty("export_to_pdf_in_scheduled_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportToPdfInScheduledReports { get; set; }

    /// <summary>
    /// The include_content_in_scheduled_reports_email attribute.
    /// </summary>
    [TerraformProperty("include_content_in_scheduled_reports_email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IncludeContentInScheduledReportsEmail { get; set; }

    /// <summary>
    /// The print_reports attribute.
    /// </summary>
    [TerraformProperty("print_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrintReports { get; set; }

    /// <summary>
    /// The rename_shared_folders attribute.
    /// </summary>
    [TerraformProperty("rename_shared_folders")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RenameSharedFolders { get; set; }

    /// <summary>
    /// The share_analyses attribute.
    /// </summary>
    [TerraformProperty("share_analyses")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShareAnalyses { get; set; }

    /// <summary>
    /// The share_dashboards attribute.
    /// </summary>
    [TerraformProperty("share_dashboards")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShareDashboards { get; set; }

    /// <summary>
    /// The share_data_sources attribute.
    /// </summary>
    [TerraformProperty("share_data_sources")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShareDataSources { get; set; }

    /// <summary>
    /// The share_datasets attribute.
    /// </summary>
    [TerraformProperty("share_datasets")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShareDatasets { get; set; }

    /// <summary>
    /// The subscribe_dashboard_email_reports attribute.
    /// </summary>
    [TerraformProperty("subscribe_dashboard_email_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubscribeDashboardEmailReports { get; set; }

    /// <summary>
    /// The view_account_spice_capacity attribute.
    /// </summary>
    [TerraformProperty("view_account_spice_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ViewAccountSpiceCapacity { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_custom_permissions resource.
/// </summary>
public partial class AwsQuicksightCustomPermissions : TerraformResource
{
    public AwsQuicksightCustomPermissions(string name) : base("aws_quicksight_custom_permissions", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    [TerraformProperty("custom_permissions_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomPermissionsName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("capabilities")]
    public TerraformList<TerraformBlock<AwsQuicksightCustomPermissionsCapabilitiesBlock>>? Capabilities { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
