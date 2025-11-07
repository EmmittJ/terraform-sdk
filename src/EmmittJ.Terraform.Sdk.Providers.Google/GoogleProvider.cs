using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents the google Terraform provider.
/// 
/// Version: ~&gt; 7.0
/// Resources: 1125
/// Data Sources: 387
/// </summary>
public class GoogleProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "google".</param>
    public GoogleProvider(string name = "google") : base(name)
    {
    }

    /// <summary>
    /// The access_approval_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AccessApprovalCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_approval_custom_endpoint");
        set => this.WithProperty("access_approval_custom_endpoint", value);
    }

    /// <summary>
    /// The access_context_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AccessContextManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_context_manager_custom_endpoint");
        set => this.WithProperty("access_context_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The access_token configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AccessToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The active_directory_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ActiveDirectoryCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_directory_custom_endpoint");
        set => this.WithProperty("active_directory_custom_endpoint", value);
    }

    /// <summary>
    /// The add_terraform_attribution_label configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? AddTerraformAttributionLabel
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("add_terraform_attribution_label");
        set => this.WithProperty("add_terraform_attribution_label", value);
    }

    /// <summary>
    /// The alloydb_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AlloydbCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alloydb_custom_endpoint");
        set => this.WithProperty("alloydb_custom_endpoint", value);
    }

    /// <summary>
    /// The apigee_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ApigeeCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apigee_custom_endpoint");
        set => this.WithProperty("apigee_custom_endpoint", value);
    }

    /// <summary>
    /// The apihub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ApihubCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apihub_custom_endpoint");
        set => this.WithProperty("apihub_custom_endpoint", value);
    }

    /// <summary>
    /// The apikeys_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ApikeysCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apikeys_custom_endpoint");
        set => this.WithProperty("apikeys_custom_endpoint", value);
    }

    /// <summary>
    /// The app_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AppEngineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_engine_custom_endpoint");
        set => this.WithProperty("app_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The apphub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ApphubCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apphub_custom_endpoint");
        set => this.WithProperty("apphub_custom_endpoint", value);
    }

    /// <summary>
    /// The artifact_registry_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ArtifactRegistryCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_registry_custom_endpoint");
        set => this.WithProperty("artifact_registry_custom_endpoint", value);
    }

    /// <summary>
    /// The assured_workloads_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AssuredWorkloadsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assured_workloads_custom_endpoint");
        set => this.WithProperty("assured_workloads_custom_endpoint", value);
    }

    /// <summary>
    /// The backup_dr_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BackupDrCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_dr_custom_endpoint");
        set => this.WithProperty("backup_dr_custom_endpoint", value);
    }

    /// <summary>
    /// The beyondcorp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BeyondcorpCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("beyondcorp_custom_endpoint");
        set => this.WithProperty("beyondcorp_custom_endpoint", value);
    }

    /// <summary>
    /// The big_query_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigQueryCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("big_query_custom_endpoint");
        set => this.WithProperty("big_query_custom_endpoint", value);
    }

    /// <summary>
    /// The biglake_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BiglakeCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("biglake_custom_endpoint");
        set => this.WithProperty("biglake_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryAnalyticsHubCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_analytics_hub_custom_endpoint");
        set => this.WithProperty("bigquery_analytics_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_connection_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryConnectionCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_connection_custom_endpoint");
        set => this.WithProperty("bigquery_connection_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryDataTransferCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_data_transfer_custom_endpoint");
        set => this.WithProperty("bigquery_data_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryDatapolicyCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_datapolicy_custom_endpoint");
        set => this.WithProperty("bigquery_datapolicy_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryDatapolicyv2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_datapolicyv2_custom_endpoint");
        set => this.WithProperty("bigquery_datapolicyv2_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_reservation_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigqueryReservationCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigquery_reservation_custom_endpoint");
        set => this.WithProperty("bigquery_reservation_custom_endpoint", value);
    }

    /// <summary>
    /// The bigtable_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BigtableCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bigtable_custom_endpoint");
        set => this.WithProperty("bigtable_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BillingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_custom_endpoint");
        set => this.WithProperty("billing_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_project configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BillingProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_project");
        set => this.WithProperty("billing_project", value);
    }

    /// <summary>
    /// The binary_authorization_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BinaryAuthorizationCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("binary_authorization_custom_endpoint");
        set => this.WithProperty("binary_authorization_custom_endpoint", value);
    }

    /// <summary>
    /// The blockchain_node_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? BlockchainNodeEngineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blockchain_node_engine_custom_endpoint");
        set => this.WithProperty("blockchain_node_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The certificate_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_manager_custom_endpoint");
        set => this.WithProperty("certificate_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The ces_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CesCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ces_custom_endpoint");
        set => this.WithProperty("ces_custom_endpoint", value);
    }

    /// <summary>
    /// The chronicle_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ChronicleCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("chronicle_custom_endpoint");
        set => this.WithProperty("chronicle_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_asset_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudAssetCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_asset_custom_endpoint");
        set => this.WithProperty("cloud_asset_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudBillingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_billing_custom_endpoint");
        set => this.WithProperty("cloud_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_build_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudBuildCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_build_custom_endpoint");
        set => this.WithProperty("cloud_build_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_functions_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudFunctionsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_functions_custom_endpoint");
        set => this.WithProperty("cloud_functions_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_identity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudIdentityCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_identity_custom_endpoint");
        set => this.WithProperty("cloud_identity_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_ids_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudIdsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_ids_custom_endpoint");
        set => this.WithProperty("cloud_ids_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_quotas_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudQuotasCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_quotas_custom_endpoint");
        set => this.WithProperty("cloud_quotas_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudResourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_resource_manager_custom_endpoint");
        set => this.WithProperty("cloud_resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudRunCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_run_custom_endpoint");
        set => this.WithProperty("cloud_run_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudRunV2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_run_v2_custom_endpoint");
        set => this.WithProperty("cloud_run_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_scheduler_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudSchedulerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_scheduler_custom_endpoint");
        set => this.WithProperty("cloud_scheduler_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_tasks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CloudTasksCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_tasks_custom_endpoint");
        set => this.WithProperty("cloud_tasks_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudbuildv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Cloudbuildv2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudbuildv2_custom_endpoint");
        set => this.WithProperty("cloudbuildv2_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddeploy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClouddeployCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clouddeploy_custom_endpoint");
        set => this.WithProperty("clouddeploy_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddomains_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClouddomainsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clouddomains_custom_endpoint");
        set => this.WithProperty("clouddomains_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudfunctions2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Cloudfunctions2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudfunctions2_custom_endpoint");
        set => this.WithProperty("cloudfunctions2_custom_endpoint", value);
    }

    /// <summary>
    /// The colab_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ColabCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("colab_custom_endpoint");
        set => this.WithProperty("colab_custom_endpoint", value);
    }

    /// <summary>
    /// The composer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ComposerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("composer_custom_endpoint");
        set => this.WithProperty("composer_custom_endpoint", value);
    }

    /// <summary>
    /// The compute_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ComputeCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_custom_endpoint");
        set => this.WithProperty("compute_custom_endpoint", value);
    }

    /// <summary>
    /// The contact_center_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContactCenterInsightsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_center_insights_custom_endpoint");
        set => this.WithProperty("contact_center_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The container_analysis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAnalysisCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_analysis_custom_endpoint");
        set => this.WithProperty("container_analysis_custom_endpoint", value);
    }

    /// <summary>
    /// The container_attached_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAttachedCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_attached_custom_endpoint");
        set => this.WithProperty("container_attached_custom_endpoint", value);
    }

    /// <summary>
    /// The container_aws_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAwsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_aws_custom_endpoint");
        set => this.WithProperty("container_aws_custom_endpoint", value);
    }

    /// <summary>
    /// The container_azure_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerAzureCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_azure_custom_endpoint");
        set => this.WithProperty("container_azure_custom_endpoint", value);
    }

    /// <summary>
    /// The container_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_custom_endpoint");
        set => this.WithProperty("container_custom_endpoint", value);
    }

    /// <summary>
    /// The core_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? CoreBillingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_billing_custom_endpoint");
        set => this.WithProperty("core_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The credentials configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Credentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The data_catalog_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataCatalogCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_catalog_custom_endpoint");
        set => this.WithProperty("data_catalog_custom_endpoint", value);
    }

    /// <summary>
    /// The data_fusion_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataFusionCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_fusion_custom_endpoint");
        set => this.WithProperty("data_fusion_custom_endpoint", value);
    }

    /// <summary>
    /// The data_loss_prevention_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataLossPreventionCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_loss_prevention_custom_endpoint");
        set => this.WithProperty("data_loss_prevention_custom_endpoint", value);
    }

    /// <summary>
    /// The data_pipeline_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataPipelineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_pipeline_custom_endpoint");
        set => this.WithProperty("data_pipeline_custom_endpoint", value);
    }

    /// <summary>
    /// The database_migration_service_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseMigrationServiceCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_migration_service_custom_endpoint");
        set => this.WithProperty("database_migration_service_custom_endpoint", value);
    }

    /// <summary>
    /// The dataflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataflowCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataflow_custom_endpoint");
        set => this.WithProperty("dataflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dataplex_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataplexCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataplex_custom_endpoint");
        set => this.WithProperty("dataplex_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataprocCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataproc_custom_endpoint");
        set => this.WithProperty("dataproc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_gdc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataprocGdcCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataproc_gdc_custom_endpoint");
        set => this.WithProperty("dataproc_gdc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_metastore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DataprocMetastoreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataproc_metastore_custom_endpoint");
        set => this.WithProperty("dataproc_metastore_custom_endpoint", value);
    }

    /// <summary>
    /// The datastream_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DatastreamCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("datastream_custom_endpoint");
        set => this.WithProperty("datastream_custom_endpoint", value);
    }

    /// <summary>
    /// The default_labels configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? DefaultLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("default_labels");
        set => this.WithProperty("default_labels", value);
    }

    /// <summary>
    /// The deployment_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_manager_custom_endpoint");
        set => this.WithProperty("deployment_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The developer_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DeveloperConnectCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_connect_custom_endpoint");
        set => this.WithProperty("developer_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DialogflowCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dialogflow_custom_endpoint");
        set => this.WithProperty("dialogflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_cx_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DialogflowCxCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dialogflow_cx_custom_endpoint");
        set => this.WithProperty("dialogflow_cx_custom_endpoint", value);
    }

    /// <summary>
    /// The discovery_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DiscoveryEngineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("discovery_engine_custom_endpoint");
        set => this.WithProperty("discovery_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The dns_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DnsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_custom_endpoint");
        set => this.WithProperty("dns_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DocumentAiCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_ai_custom_endpoint");
        set => this.WithProperty("document_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_warehouse_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? DocumentAiWarehouseCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_ai_warehouse_custom_endpoint");
        set => this.WithProperty("document_ai_warehouse_custom_endpoint", value);
    }

    /// <summary>
    /// The edgecontainer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? EdgecontainerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edgecontainer_custom_endpoint");
        set => this.WithProperty("edgecontainer_custom_endpoint", value);
    }

    /// <summary>
    /// The edgenetwork_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? EdgenetworkCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edgenetwork_custom_endpoint");
        set => this.WithProperty("edgenetwork_custom_endpoint", value);
    }

    /// <summary>
    /// The essential_contacts_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? EssentialContactsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("essential_contacts_custom_endpoint");
        set => this.WithProperty("essential_contacts_custom_endpoint", value);
    }

    /// <summary>
    /// The eventarc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? EventarcCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventarc_custom_endpoint");
        set => this.WithProperty("eventarc_custom_endpoint", value);
    }

    /// <summary>
    /// The filestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FilestoreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filestore_custom_endpoint");
        set => this.WithProperty("filestore_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_check_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FirebaseAppCheckCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firebase_app_check_custom_endpoint");
        set => this.WithProperty("firebase_app_check_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_hosting_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FirebaseAppHostingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firebase_app_hosting_custom_endpoint");
        set => this.WithProperty("firebase_app_hosting_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_data_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FirebaseDataConnectCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firebase_data_connect_custom_endpoint");
        set => this.WithProperty("firebase_data_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The firebaserules_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FirebaserulesCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firebaserules_custom_endpoint");
        set => this.WithProperty("firebaserules_custom_endpoint", value);
    }

    /// <summary>
    /// The firestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? FirestoreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firestore_custom_endpoint");
        set => this.WithProperty("firestore_custom_endpoint", value);
    }

    /// <summary>
    /// The gemini_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? GeminiCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gemini_custom_endpoint");
        set => this.WithProperty("gemini_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_backup_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? GkeBackupCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gke_backup_custom_endpoint");
        set => this.WithProperty("gke_backup_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? GkeHub2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gke_hub2_custom_endpoint");
        set => this.WithProperty("gke_hub2_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? GkeHubCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gke_hub_custom_endpoint");
        set => this.WithProperty("gke_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The gkeonprem_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? GkeonpremCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gkeonprem_custom_endpoint");
        set => this.WithProperty("gkeonprem_custom_endpoint", value);
    }

    /// <summary>
    /// The healthcare_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? HealthcareCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("healthcare_custom_endpoint");
        set => this.WithProperty("healthcare_custom_endpoint", value);
    }

    /// <summary>
    /// The iam2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Iam2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam2_custom_endpoint");
        set => this.WithProperty("iam2_custom_endpoint", value);
    }

    /// <summary>
    /// The iam3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Iam3CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam3_custom_endpoint");
        set => this.WithProperty("iam3_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_beta_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IamBetaCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_beta_custom_endpoint");
        set => this.WithProperty("iam_beta_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_credentials_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IamCredentialsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_credentials_custom_endpoint");
        set => this.WithProperty("iam_credentials_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IamCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_custom_endpoint");
        set => this.WithProperty("iam_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_workforce_pool_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IamWorkforcePoolCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_workforce_pool_custom_endpoint");
        set => this.WithProperty("iam_workforce_pool_custom_endpoint", value);
    }

    /// <summary>
    /// The iap_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IapCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iap_custom_endpoint");
        set => this.WithProperty("iap_custom_endpoint", value);
    }

    /// <summary>
    /// The identity_platform_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityPlatformCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_platform_custom_endpoint");
        set => this.WithProperty("identity_platform_custom_endpoint", value);
    }

    /// <summary>
    /// The impersonate_service_account configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ImpersonateServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("impersonate_service_account");
        set => this.WithProperty("impersonate_service_account", value);
    }

    /// <summary>
    /// The impersonate_service_account_delegates configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ImpersonateServiceAccountDelegates
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("impersonate_service_account_delegates");
        set => this.WithProperty("impersonate_service_account_delegates", value);
    }

    /// <summary>
    /// The integration_connectors_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationConnectorsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_connectors_custom_endpoint");
        set => this.WithProperty("integration_connectors_custom_endpoint", value);
    }

    /// <summary>
    /// The integrations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integrations_custom_endpoint");
        set => this.WithProperty("integrations_custom_endpoint", value);
    }

    /// <summary>
    /// The kms_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? KmsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_custom_endpoint");
        set => this.WithProperty("kms_custom_endpoint", value);
    }

    /// <summary>
    /// The logging_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? LoggingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_custom_endpoint");
        set => this.WithProperty("logging_custom_endpoint", value);
    }

    /// <summary>
    /// The looker_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? LookerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("looker_custom_endpoint");
        set => this.WithProperty("looker_custom_endpoint", value);
    }

    /// <summary>
    /// The lustre_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? LustreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lustre_custom_endpoint");
        set => this.WithProperty("lustre_custom_endpoint", value);
    }

    /// <summary>
    /// The managed_kafka_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedKafkaCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_kafka_custom_endpoint");
        set => this.WithProperty("managed_kafka_custom_endpoint", value);
    }

    /// <summary>
    /// The memcache_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MemcacheCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memcache_custom_endpoint");
        set => this.WithProperty("memcache_custom_endpoint", value);
    }

    /// <summary>
    /// The memorystore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MemorystoreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memorystore_custom_endpoint");
        set => this.WithProperty("memorystore_custom_endpoint", value);
    }

    /// <summary>
    /// The migration_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MigrationCenterCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("migration_center_custom_endpoint");
        set => this.WithProperty("migration_center_custom_endpoint", value);
    }

    /// <summary>
    /// The ml_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MlEngineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ml_engine_custom_endpoint");
        set => this.WithProperty("ml_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ModelArmorCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_armor_custom_endpoint");
        set => this.WithProperty("model_armor_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_global_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ModelArmorGlobalCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_armor_global_custom_endpoint");
        set => this.WithProperty("model_armor_global_custom_endpoint", value);
    }

    /// <summary>
    /// The monitoring_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MonitoringCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitoring_custom_endpoint");
        set => this.WithProperty("monitoring_custom_endpoint", value);
    }

    /// <summary>
    /// The netapp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetappCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("netapp_custom_endpoint");
        set => this.WithProperty("netapp_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkConnectivityCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_connectivity_custom_endpoint");
        set => this.WithProperty("network_connectivity_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivityv1_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkConnectivityv1CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_connectivityv1_custom_endpoint");
        set => this.WithProperty("network_connectivityv1_custom_endpoint", value);
    }

    /// <summary>
    /// The network_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkManagementCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_management_custom_endpoint");
        set => this.WithProperty("network_management_custom_endpoint", value);
    }

    /// <summary>
    /// The network_security_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkSecurityCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_custom_endpoint");
        set => this.WithProperty("network_security_custom_endpoint", value);
    }

    /// <summary>
    /// The network_services_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkServicesCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_services_custom_endpoint");
        set => this.WithProperty("network_services_custom_endpoint", value);
    }

    /// <summary>
    /// The notebooks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? NotebooksCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notebooks_custom_endpoint");
        set => this.WithProperty("notebooks_custom_endpoint", value);
    }

    /// <summary>
    /// The observability_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ObservabilityCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("observability_custom_endpoint");
        set => this.WithProperty("observability_custom_endpoint", value);
    }

    /// <summary>
    /// The oracle_database_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OracleDatabaseCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oracle_database_custom_endpoint");
        set => this.WithProperty("oracle_database_custom_endpoint", value);
    }

    /// <summary>
    /// The org_policy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OrgPolicyCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_policy_custom_endpoint");
        set => this.WithProperty("org_policy_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OsConfigCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_config_custom_endpoint");
        set => this.WithProperty("os_config_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OsConfigV2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_config_v2_custom_endpoint");
        set => this.WithProperty("os_config_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The os_login_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OsLoginCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_login_custom_endpoint");
        set => this.WithProperty("os_login_custom_endpoint", value);
    }

    /// <summary>
    /// The parallelstore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ParallelstoreCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parallelstore_custom_endpoint");
        set => this.WithProperty("parallelstore_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ParameterManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_manager_custom_endpoint");
        set => this.WithProperty("parameter_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ParameterManagerRegionalCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_manager_regional_custom_endpoint");
        set => this.WithProperty("parameter_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The privateca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PrivatecaCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privateca_custom_endpoint");
        set => this.WithProperty("privateca_custom_endpoint", value);
    }

    /// <summary>
    /// The privileged_access_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PrivilegedAccessManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privileged_access_manager_custom_endpoint");
        set => this.WithProperty("privileged_access_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The project configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The public_ca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PublicCaCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ca_custom_endpoint");
        set => this.WithProperty("public_ca_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PubsubCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pubsub_custom_endpoint");
        set => this.WithProperty("pubsub_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_lite_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PubsubLiteCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pubsub_lite_custom_endpoint");
        set => this.WithProperty("pubsub_lite_custom_endpoint", value);
    }

    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? RecaptchaEnterpriseCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recaptcha_enterprise_custom_endpoint");
        set => this.WithProperty("recaptcha_enterprise_custom_endpoint", value);
    }

    /// <summary>
    /// The redis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? RedisCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_custom_endpoint");
        set => this.WithProperty("redis_custom_endpoint", value);
    }

    /// <summary>
    /// The region configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_reason configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? RequestReason
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_reason");
        set => this.WithProperty("request_reason", value);
    }

    /// <summary>
    /// The request_timeout configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? RequestTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_timeout");
        set => this.WithProperty("request_timeout", value);
    }

    /// <summary>
    /// The resource_manager3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceManager3CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_manager3_custom_endpoint");
        set => this.WithProperty("resource_manager3_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_manager_custom_endpoint");
        set => this.WithProperty("resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_v3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceManagerV3CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_manager_v3_custom_endpoint");
        set => this.WithProperty("resource_manager_v3_custom_endpoint", value);
    }

    /// <summary>
    /// The scopes configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The secret_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecretManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_manager_custom_endpoint");
        set => this.WithProperty("secret_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The secret_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecretManagerRegionalCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_manager_regional_custom_endpoint");
        set => this.WithProperty("secret_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The secure_source_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecureSourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secure_source_manager_custom_endpoint");
        set => this.WithProperty("secure_source_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityCenterCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_center_custom_endpoint");
        set => this.WithProperty("security_center_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityCenterManagementCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_center_management_custom_endpoint");
        set => this.WithProperty("security_center_management_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityCenterV2CustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_center_v2_custom_endpoint");
        set => this.WithProperty("security_center_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The securityposture_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SecuritypostureCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("securityposture_custom_endpoint");
        set => this.WithProperty("securityposture_custom_endpoint", value);
    }

    /// <summary>
    /// The service_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceManagementCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_management_custom_endpoint");
        set => this.WithProperty("service_management_custom_endpoint", value);
    }

    /// <summary>
    /// The service_networking_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceNetworkingCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_networking_custom_endpoint");
        set => this.WithProperty("service_networking_custom_endpoint", value);
    }

    /// <summary>
    /// The service_usage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceUsageCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_usage_custom_endpoint");
        set => this.WithProperty("service_usage_custom_endpoint", value);
    }

    /// <summary>
    /// The site_verification_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SiteVerificationCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("site_verification_custom_endpoint");
        set => this.WithProperty("site_verification_custom_endpoint", value);
    }

    /// <summary>
    /// The source_repo_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SourceRepoCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_repo_custom_endpoint");
        set => this.WithProperty("source_repo_custom_endpoint", value);
    }

    /// <summary>
    /// The spanner_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SpannerCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spanner_custom_endpoint");
        set => this.WithProperty("spanner_custom_endpoint", value);
    }

    /// <summary>
    /// The sql_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? SqlCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_custom_endpoint");
        set => this.WithProperty("sql_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_batch_operations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? StorageBatchOperationsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_batch_operations_custom_endpoint");
        set => this.WithProperty("storage_batch_operations_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_control_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? StorageControlCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_control_custom_endpoint");
        set => this.WithProperty("storage_control_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? StorageCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_custom_endpoint");
        set => this.WithProperty("storage_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? StorageInsightsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_insights_custom_endpoint");
        set => this.WithProperty("storage_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? StorageTransferCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_transfer_custom_endpoint");
        set => this.WithProperty("storage_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? TagsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tags_custom_endpoint");
        set => this.WithProperty("tags_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_location_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? TagsLocationCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tags_location_custom_endpoint");
        set => this.WithProperty("tags_location_custom_endpoint", value);
    }

    /// <summary>
    /// The terraform_attribution_label_addition_strategy configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? TerraformAttributionLabelAdditionStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terraform_attribution_label_addition_strategy");
        set => this.WithProperty("terraform_attribution_label_addition_strategy", value);
    }

    /// <summary>
    /// The transcoder_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? TranscoderCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transcoder_custom_endpoint");
        set => this.WithProperty("transcoder_custom_endpoint", value);
    }

    /// <summary>
    /// The universe_domain configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? UniverseDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("universe_domain");
        set => this.WithProperty("universe_domain", value);
    }

    /// <summary>
    /// The user_project_override configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? UserProjectOverride
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_project_override");
        set => this.WithProperty("user_project_override", value);
    }

    /// <summary>
    /// The vertex_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? VertexAiCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vertex_ai_custom_endpoint");
        set => this.WithProperty("vertex_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The vmwareengine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? VmwareengineCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmwareengine_custom_endpoint");
        set => this.WithProperty("vmwareengine_custom_endpoint", value);
    }

    /// <summary>
    /// The vpc_access_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? VpcAccessCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_access_custom_endpoint");
        set => this.WithProperty("vpc_access_custom_endpoint", value);
    }

    /// <summary>
    /// The workbench_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? WorkbenchCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workbench_custom_endpoint");
        set => this.WithProperty("workbench_custom_endpoint", value);
    }

    /// <summary>
    /// The workflows_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? WorkflowsCustomEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workflows_custom_endpoint");
        set => this.WithProperty("workflows_custom_endpoint", value);
    }

    /// <summary>
    /// The zone configuration.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }
}
