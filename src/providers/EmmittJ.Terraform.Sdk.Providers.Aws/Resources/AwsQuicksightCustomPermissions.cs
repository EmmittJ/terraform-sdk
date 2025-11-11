using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capabilities in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightCustomPermissionsCapabilitiesBlock
{
    /// <summary>
    /// The add_or_run_anomaly_detection_for_analyses attribute.
    /// </summary>
    [TerraformPropertyName("add_or_run_anomaly_detection_for_analyses")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AddOrRunAnomalyDetectionForAnalyses { get; set; }

    /// <summary>
    /// The create_and_update_dashboard_email_reports attribute.
    /// </summary>
    [TerraformPropertyName("create_and_update_dashboard_email_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAndUpdateDashboardEmailReports { get; set; }

    /// <summary>
    /// The create_and_update_data_sources attribute.
    /// </summary>
    [TerraformPropertyName("create_and_update_data_sources")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAndUpdateDataSources { get; set; }

    /// <summary>
    /// The create_and_update_datasets attribute.
    /// </summary>
    [TerraformPropertyName("create_and_update_datasets")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAndUpdateDatasets { get; set; }

    /// <summary>
    /// The create_and_update_themes attribute.
    /// </summary>
    [TerraformPropertyName("create_and_update_themes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAndUpdateThemes { get; set; }

    /// <summary>
    /// The create_and_update_threshold_alerts attribute.
    /// </summary>
    [TerraformPropertyName("create_and_update_threshold_alerts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAndUpdateThresholdAlerts { get; set; }

    /// <summary>
    /// The create_shared_folders attribute.
    /// </summary>
    [TerraformPropertyName("create_shared_folders")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateSharedFolders { get; set; }

    /// <summary>
    /// The create_spice_dataset attribute.
    /// </summary>
    [TerraformPropertyName("create_spice_dataset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateSpiceDataset { get; set; }

    /// <summary>
    /// The export_to_csv attribute.
    /// </summary>
    [TerraformPropertyName("export_to_csv")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToCsv { get; set; }

    /// <summary>
    /// The export_to_csv_in_scheduled_reports attribute.
    /// </summary>
    [TerraformPropertyName("export_to_csv_in_scheduled_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToCsvInScheduledReports { get; set; }

    /// <summary>
    /// The export_to_excel attribute.
    /// </summary>
    [TerraformPropertyName("export_to_excel")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToExcel { get; set; }

    /// <summary>
    /// The export_to_excel_in_scheduled_reports attribute.
    /// </summary>
    [TerraformPropertyName("export_to_excel_in_scheduled_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToExcelInScheduledReports { get; set; }

    /// <summary>
    /// The export_to_pdf attribute.
    /// </summary>
    [TerraformPropertyName("export_to_pdf")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToPdf { get; set; }

    /// <summary>
    /// The export_to_pdf_in_scheduled_reports attribute.
    /// </summary>
    [TerraformPropertyName("export_to_pdf_in_scheduled_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportToPdfInScheduledReports { get; set; }

    /// <summary>
    /// The include_content_in_scheduled_reports_email attribute.
    /// </summary>
    [TerraformPropertyName("include_content_in_scheduled_reports_email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IncludeContentInScheduledReportsEmail { get; set; }

    /// <summary>
    /// The print_reports attribute.
    /// </summary>
    [TerraformPropertyName("print_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrintReports { get; set; }

    /// <summary>
    /// The rename_shared_folders attribute.
    /// </summary>
    [TerraformPropertyName("rename_shared_folders")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RenameSharedFolders { get; set; }

    /// <summary>
    /// The share_analyses attribute.
    /// </summary>
    [TerraformPropertyName("share_analyses")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShareAnalyses { get; set; }

    /// <summary>
    /// The share_dashboards attribute.
    /// </summary>
    [TerraformPropertyName("share_dashboards")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShareDashboards { get; set; }

    /// <summary>
    /// The share_data_sources attribute.
    /// </summary>
    [TerraformPropertyName("share_data_sources")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShareDataSources { get; set; }

    /// <summary>
    /// The share_datasets attribute.
    /// </summary>
    [TerraformPropertyName("share_datasets")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShareDatasets { get; set; }

    /// <summary>
    /// The subscribe_dashboard_email_reports attribute.
    /// </summary>
    [TerraformPropertyName("subscribe_dashboard_email_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubscribeDashboardEmailReports { get; set; }

    /// <summary>
    /// The view_account_spice_capacity attribute.
    /// </summary>
    [TerraformPropertyName("view_account_spice_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ViewAccountSpiceCapacity { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_custom_permissions resource.
/// </summary>
public class AwsQuicksightCustomPermissions : TerraformResource
{
    public AwsQuicksightCustomPermissions(string name) : base("aws_quicksight_custom_permissions", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    [TerraformPropertyName("custom_permissions_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomPermissionsName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("capabilities")]
    public TerraformList<TerraformBlock<AwsQuicksightCustomPermissionsCapabilitiesBlock>>? Capabilities { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
