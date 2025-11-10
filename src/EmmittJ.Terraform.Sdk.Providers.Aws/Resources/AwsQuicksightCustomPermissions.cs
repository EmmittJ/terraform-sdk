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
        get => GetProperty<TerraformProperty<string>>("add_or_run_anomaly_detection_for_analyses");
        set => WithProperty("add_or_run_anomaly_detection_for_analyses", value);
    }

    /// <summary>
    /// The create_and_update_dashboard_email_reports attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDashboardEmailReports
    {
        get => GetProperty<TerraformProperty<string>>("create_and_update_dashboard_email_reports");
        set => WithProperty("create_and_update_dashboard_email_reports", value);
    }

    /// <summary>
    /// The create_and_update_data_sources attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDataSources
    {
        get => GetProperty<TerraformProperty<string>>("create_and_update_data_sources");
        set => WithProperty("create_and_update_data_sources", value);
    }

    /// <summary>
    /// The create_and_update_datasets attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateDatasets
    {
        get => GetProperty<TerraformProperty<string>>("create_and_update_datasets");
        set => WithProperty("create_and_update_datasets", value);
    }

    /// <summary>
    /// The create_and_update_themes attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateThemes
    {
        get => GetProperty<TerraformProperty<string>>("create_and_update_themes");
        set => WithProperty("create_and_update_themes", value);
    }

    /// <summary>
    /// The create_and_update_threshold_alerts attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAndUpdateThresholdAlerts
    {
        get => GetProperty<TerraformProperty<string>>("create_and_update_threshold_alerts");
        set => WithProperty("create_and_update_threshold_alerts", value);
    }

    /// <summary>
    /// The create_shared_folders attribute.
    /// </summary>
    public TerraformProperty<string>? CreateSharedFolders
    {
        get => GetProperty<TerraformProperty<string>>("create_shared_folders");
        set => WithProperty("create_shared_folders", value);
    }

    /// <summary>
    /// The create_spice_dataset attribute.
    /// </summary>
    public TerraformProperty<string>? CreateSpiceDataset
    {
        get => GetProperty<TerraformProperty<string>>("create_spice_dataset");
        set => WithProperty("create_spice_dataset", value);
    }

    /// <summary>
    /// The export_to_csv attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToCsv
    {
        get => GetProperty<TerraformProperty<string>>("export_to_csv");
        set => WithProperty("export_to_csv", value);
    }

    /// <summary>
    /// The export_to_csv_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToCsvInScheduledReports
    {
        get => GetProperty<TerraformProperty<string>>("export_to_csv_in_scheduled_reports");
        set => WithProperty("export_to_csv_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_excel attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToExcel
    {
        get => GetProperty<TerraformProperty<string>>("export_to_excel");
        set => WithProperty("export_to_excel", value);
    }

    /// <summary>
    /// The export_to_excel_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToExcelInScheduledReports
    {
        get => GetProperty<TerraformProperty<string>>("export_to_excel_in_scheduled_reports");
        set => WithProperty("export_to_excel_in_scheduled_reports", value);
    }

    /// <summary>
    /// The export_to_pdf attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToPdf
    {
        get => GetProperty<TerraformProperty<string>>("export_to_pdf");
        set => WithProperty("export_to_pdf", value);
    }

    /// <summary>
    /// The export_to_pdf_in_scheduled_reports attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToPdfInScheduledReports
    {
        get => GetProperty<TerraformProperty<string>>("export_to_pdf_in_scheduled_reports");
        set => WithProperty("export_to_pdf_in_scheduled_reports", value);
    }

    /// <summary>
    /// The include_content_in_scheduled_reports_email attribute.
    /// </summary>
    public TerraformProperty<string>? IncludeContentInScheduledReportsEmail
    {
        get => GetProperty<TerraformProperty<string>>("include_content_in_scheduled_reports_email");
        set => WithProperty("include_content_in_scheduled_reports_email", value);
    }

    /// <summary>
    /// The print_reports attribute.
    /// </summary>
    public TerraformProperty<string>? PrintReports
    {
        get => GetProperty<TerraformProperty<string>>("print_reports");
        set => WithProperty("print_reports", value);
    }

    /// <summary>
    /// The rename_shared_folders attribute.
    /// </summary>
    public TerraformProperty<string>? RenameSharedFolders
    {
        get => GetProperty<TerraformProperty<string>>("rename_shared_folders");
        set => WithProperty("rename_shared_folders", value);
    }

    /// <summary>
    /// The share_analyses attribute.
    /// </summary>
    public TerraformProperty<string>? ShareAnalyses
    {
        get => GetProperty<TerraformProperty<string>>("share_analyses");
        set => WithProperty("share_analyses", value);
    }

    /// <summary>
    /// The share_dashboards attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDashboards
    {
        get => GetProperty<TerraformProperty<string>>("share_dashboards");
        set => WithProperty("share_dashboards", value);
    }

    /// <summary>
    /// The share_data_sources attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDataSources
    {
        get => GetProperty<TerraformProperty<string>>("share_data_sources");
        set => WithProperty("share_data_sources", value);
    }

    /// <summary>
    /// The share_datasets attribute.
    /// </summary>
    public TerraformProperty<string>? ShareDatasets
    {
        get => GetProperty<TerraformProperty<string>>("share_datasets");
        set => WithProperty("share_datasets", value);
    }

    /// <summary>
    /// The subscribe_dashboard_email_reports attribute.
    /// </summary>
    public TerraformProperty<string>? SubscribeDashboardEmailReports
    {
        get => GetProperty<TerraformProperty<string>>("subscribe_dashboard_email_reports");
        set => WithProperty("subscribe_dashboard_email_reports", value);
    }

    /// <summary>
    /// The view_account_spice_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? ViewAccountSpiceCapacity
    {
        get => GetProperty<TerraformProperty<string>>("view_account_spice_capacity");
        set => WithProperty("view_account_spice_capacity", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    public required TerraformProperty<string> CustomPermissionsName
    {
        get => GetProperty<TerraformProperty<string>>("custom_permissions_name");
        set => this.WithProperty("custom_permissions_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for capabilities.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQuicksightCustomPermissionsCapabilitiesBlock>? Capabilities
    {
        get => GetProperty<List<AwsQuicksightCustomPermissionsCapabilitiesBlock>>("capabilities");
        set => this.WithProperty("capabilities", value);
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
