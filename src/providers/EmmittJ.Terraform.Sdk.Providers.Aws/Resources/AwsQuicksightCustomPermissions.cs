using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capabilities in AwsQuicksightCustomPermissions.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightCustomPermissionsCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capabilities";

    /// <summary>
    /// The add_or_run_anomaly_detection_for_analyses attribute.
    /// </summary>
    public TerraformValue<string>? AddOrRunAnomalyDetectionForAnalyses
    {
        get => GetArgument<TerraformValue<string>>("add_or_run_anomaly_detection_for_analyses");
        set => SetArgument("add_or_run_anomaly_detection_for_analyses", value);
    }

    /// <summary>
    /// The create_and_update_dashboard_email_reports attribute.
    /// </summary>
    public TerraformValue<string>? CreateAndUpdateDashboardEmailReports
    {
        get => GetArgument<TerraformValue<string>>("create_and_update_dashboard_email_reports");
        set => SetArgument("create_and_update_dashboard_email_reports", value);
    }

    /// <summary>
    /// The create_and_update_data_sources attribute.
    /// </summary>
    public TerraformValue<string>? CreateAndUpdateDataSources
    {
        get => GetArgument<TerraformValue<string>>("create_and_update_data_sources");
        set => SetArgument("create_and_update_data_sources", value);
    }

    /// <summary>
    /// The create_and_update_datasets attribute.
    /// </summary>
    public TerraformValue<string>? CreateAndUpdateDatasets
    {
        get => GetArgument<TerraformValue<string>>("create_and_update_datasets");
        set => SetArgument("create_and_update_datasets", value);
    }

    /// <summary>
    /// The create_and_update_themes attribute.
    /// </summary>
    public TerraformValue<string>? CreateAndUpdateThemes
    {
        get => GetArgument<TerraformValue<string>>("create_and_update_themes");
        set => SetArgument("create_and_update_themes", value);
    }

    /// <summary>
    /// The create_and_update_threshold_alerts attribute.
    /// </summary>
    public TerraformValue<string>? CreateAndUpdateThresholdAlerts
    {
        get => GetArgument<TerraformValue<string>>("create_and_update_threshold_alerts");
        set => SetArgument("create_and_update_threshold_alerts", value);
    }

    /// <summary>
    /// The create_shared_folders attribute.
    /// </summary>
    public TerraformValue<string>? CreateSharedFolders
    {
        get => GetArgument<TerraformValue<string>>("create_shared_folders");
        set => SetArgument("create_shared_folders", value);
    }

    /// <summary>
    /// The create_spice_dataset attribute.
    /// </summary>
    public TerraformValue<string>? CreateSpiceDataset
    {
        get => GetArgument<TerraformValue<string>>("create_spice_dataset");
        set => SetArgument("create_spice_dataset", value);
    }

    /// <summary>
    /// The export_to_csv attribute.
    /// </summary>
    public TerraformValue<string>? ExportToCsv
    {
        get => GetArgument<TerraformValue<string>>("export_to_csv");
        set => SetArgument("export_to_csv", value);
    }

    /// <summary>
    /// The export_to_csv_in_scheduled_reports attribute.
    /// </summary>
    public TerraformValue<string>? ExportToCsvInScheduledReports
    {
        get => GetArgument<TerraformValue<string>>("export_to_csv_in_scheduled_reports");
        set => SetArgument("export_to_csv_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_excel attribute.
    /// </summary>
    public TerraformValue<string>? ExportToExcel
    {
        get => GetArgument<TerraformValue<string>>("export_to_excel");
        set => SetArgument("export_to_excel", value);
    }

    /// <summary>
    /// The export_to_excel_in_scheduled_reports attribute.
    /// </summary>
    public TerraformValue<string>? ExportToExcelInScheduledReports
    {
        get => GetArgument<TerraformValue<string>>("export_to_excel_in_scheduled_reports");
        set => SetArgument("export_to_excel_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_pdf attribute.
    /// </summary>
    public TerraformValue<string>? ExportToPdf
    {
        get => GetArgument<TerraformValue<string>>("export_to_pdf");
        set => SetArgument("export_to_pdf", value);
    }

    /// <summary>
    /// The export_to_pdf_in_scheduled_reports attribute.
    /// </summary>
    public TerraformValue<string>? ExportToPdfInScheduledReports
    {
        get => GetArgument<TerraformValue<string>>("export_to_pdf_in_scheduled_reports");
        set => SetArgument("export_to_pdf_in_scheduled_reports", value);
    }

    /// <summary>
    /// The include_content_in_scheduled_reports_email attribute.
    /// </summary>
    public TerraformValue<string>? IncludeContentInScheduledReportsEmail
    {
        get => GetArgument<TerraformValue<string>>("include_content_in_scheduled_reports_email");
        set => SetArgument("include_content_in_scheduled_reports_email", value);
    }

    /// <summary>
    /// The print_reports attribute.
    /// </summary>
    public TerraformValue<string>? PrintReports
    {
        get => GetArgument<TerraformValue<string>>("print_reports");
        set => SetArgument("print_reports", value);
    }

    /// <summary>
    /// The rename_shared_folders attribute.
    /// </summary>
    public TerraformValue<string>? RenameSharedFolders
    {
        get => GetArgument<TerraformValue<string>>("rename_shared_folders");
        set => SetArgument("rename_shared_folders", value);
    }

    /// <summary>
    /// The share_analyses attribute.
    /// </summary>
    public TerraformValue<string>? ShareAnalyses
    {
        get => GetArgument<TerraformValue<string>>("share_analyses");
        set => SetArgument("share_analyses", value);
    }

    /// <summary>
    /// The share_dashboards attribute.
    /// </summary>
    public TerraformValue<string>? ShareDashboards
    {
        get => GetArgument<TerraformValue<string>>("share_dashboards");
        set => SetArgument("share_dashboards", value);
    }

    /// <summary>
    /// The share_data_sources attribute.
    /// </summary>
    public TerraformValue<string>? ShareDataSources
    {
        get => GetArgument<TerraformValue<string>>("share_data_sources");
        set => SetArgument("share_data_sources", value);
    }

    /// <summary>
    /// The share_datasets attribute.
    /// </summary>
    public TerraformValue<string>? ShareDatasets
    {
        get => GetArgument<TerraformValue<string>>("share_datasets");
        set => SetArgument("share_datasets", value);
    }

    /// <summary>
    /// The subscribe_dashboard_email_reports attribute.
    /// </summary>
    public TerraformValue<string>? SubscribeDashboardEmailReports
    {
        get => GetArgument<TerraformValue<string>>("subscribe_dashboard_email_reports");
        set => SetArgument("subscribe_dashboard_email_reports", value);
    }

    /// <summary>
    /// The view_account_spice_capacity attribute.
    /// </summary>
    public TerraformValue<string>? ViewAccountSpiceCapacity
    {
        get => GetArgument<TerraformValue<string>>("view_account_spice_capacity");
        set => SetArgument("view_account_spice_capacity", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_custom_permissions Terraform resource.
/// Manages a aws_quicksight_custom_permissions resource.
/// </summary>
public partial class AwsQuicksightCustomPermissions(string name) : TerraformResource("aws_quicksight_custom_permissions", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    public required TerraformValue<string> CustomPermissionsName
    {
        get => GetArgument<TerraformValue<string>>("custom_permissions_name");
        set => SetArgument("custom_permissions_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Capabilities block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightCustomPermissionsCapabilitiesBlock>? Capabilities
    {
        get => GetArgument<TerraformList<AwsQuicksightCustomPermissionsCapabilitiesBlock>>("capabilities");
        set => SetArgument("capabilities", value);
    }

}
