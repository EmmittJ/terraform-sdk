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
    public TerraformProperty<string>? AccessApprovalCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("access_approval_custom_endpoint");
        set => this.WithProperty("access_approval_custom_endpoint", value);
    }

    /// <summary>
    /// The access_context_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AccessContextManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("access_context_manager_custom_endpoint");
        set => this.WithProperty("access_context_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The access_token configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The active_directory_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("active_directory_custom_endpoint");
        set => this.WithProperty("active_directory_custom_endpoint", value);
    }

    /// <summary>
    /// The add_terraform_attribution_label configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? AddTerraformAttributionLabel
    {
        get => GetProperty<TerraformProperty<bool>>("add_terraform_attribution_label");
        set => this.WithProperty("add_terraform_attribution_label", value);
    }

    /// <summary>
    /// The alloydb_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AlloydbCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("alloydb_custom_endpoint");
        set => this.WithProperty("alloydb_custom_endpoint", value);
    }

    /// <summary>
    /// The apigee_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ApigeeCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("apigee_custom_endpoint");
        set => this.WithProperty("apigee_custom_endpoint", value);
    }

    /// <summary>
    /// The apihub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ApihubCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("apihub_custom_endpoint");
        set => this.WithProperty("apihub_custom_endpoint", value);
    }

    /// <summary>
    /// The apikeys_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ApikeysCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("apikeys_custom_endpoint");
        set => this.WithProperty("apikeys_custom_endpoint", value);
    }

    /// <summary>
    /// The app_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AppEngineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("app_engine_custom_endpoint");
        set => this.WithProperty("app_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The apphub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ApphubCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("apphub_custom_endpoint");
        set => this.WithProperty("apphub_custom_endpoint", value);
    }

    /// <summary>
    /// The artifact_registry_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ArtifactRegistryCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("artifact_registry_custom_endpoint");
        set => this.WithProperty("artifact_registry_custom_endpoint", value);
    }

    /// <summary>
    /// The assured_workloads_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? AssuredWorkloadsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("assured_workloads_custom_endpoint");
        set => this.WithProperty("assured_workloads_custom_endpoint", value);
    }

    /// <summary>
    /// The backup_dr_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BackupDrCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("backup_dr_custom_endpoint");
        set => this.WithProperty("backup_dr_custom_endpoint", value);
    }

    /// <summary>
    /// The beyondcorp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BeyondcorpCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("beyondcorp_custom_endpoint");
        set => this.WithProperty("beyondcorp_custom_endpoint", value);
    }

    /// <summary>
    /// The big_query_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigQueryCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("big_query_custom_endpoint");
        set => this.WithProperty("big_query_custom_endpoint", value);
    }

    /// <summary>
    /// The biglake_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BiglakeCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("biglake_custom_endpoint");
        set => this.WithProperty("biglake_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryAnalyticsHubCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_analytics_hub_custom_endpoint");
        set => this.WithProperty("bigquery_analytics_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_connection_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryConnectionCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_connection_custom_endpoint");
        set => this.WithProperty("bigquery_connection_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryDataTransferCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_data_transfer_custom_endpoint");
        set => this.WithProperty("bigquery_data_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryDatapolicyCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_datapolicy_custom_endpoint");
        set => this.WithProperty("bigquery_datapolicy_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryDatapolicyv2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_datapolicyv2_custom_endpoint");
        set => this.WithProperty("bigquery_datapolicyv2_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_reservation_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigqueryReservationCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigquery_reservation_custom_endpoint");
        set => this.WithProperty("bigquery_reservation_custom_endpoint", value);
    }

    /// <summary>
    /// The bigtable_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BigtableCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("bigtable_custom_endpoint");
        set => this.WithProperty("bigtable_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BillingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("billing_custom_endpoint");
        set => this.WithProperty("billing_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_project configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BillingProject
    {
        get => GetProperty<TerraformProperty<string>>("billing_project");
        set => this.WithProperty("billing_project", value);
    }

    /// <summary>
    /// The binary_authorization_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BinaryAuthorizationCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("binary_authorization_custom_endpoint");
        set => this.WithProperty("binary_authorization_custom_endpoint", value);
    }

    /// <summary>
    /// The blockchain_node_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? BlockchainNodeEngineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("blockchain_node_engine_custom_endpoint");
        set => this.WithProperty("blockchain_node_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The certificate_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CertificateManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("certificate_manager_custom_endpoint");
        set => this.WithProperty("certificate_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The ces_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CesCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("ces_custom_endpoint");
        set => this.WithProperty("ces_custom_endpoint", value);
    }

    /// <summary>
    /// The chronicle_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ChronicleCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("chronicle_custom_endpoint");
        set => this.WithProperty("chronicle_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_asset_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudAssetCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_asset_custom_endpoint");
        set => this.WithProperty("cloud_asset_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudBillingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_billing_custom_endpoint");
        set => this.WithProperty("cloud_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_build_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudBuildCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_build_custom_endpoint");
        set => this.WithProperty("cloud_build_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_functions_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudFunctionsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_functions_custom_endpoint");
        set => this.WithProperty("cloud_functions_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_identity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudIdentityCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_identity_custom_endpoint");
        set => this.WithProperty("cloud_identity_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_ids_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudIdsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_ids_custom_endpoint");
        set => this.WithProperty("cloud_ids_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_quotas_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudQuotasCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_quotas_custom_endpoint");
        set => this.WithProperty("cloud_quotas_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudResourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_resource_manager_custom_endpoint");
        set => this.WithProperty("cloud_resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudRunCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_run_custom_endpoint");
        set => this.WithProperty("cloud_run_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudRunV2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_run_v2_custom_endpoint");
        set => this.WithProperty("cloud_run_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_scheduler_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudSchedulerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_scheduler_custom_endpoint");
        set => this.WithProperty("cloud_scheduler_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_tasks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CloudTasksCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloud_tasks_custom_endpoint");
        set => this.WithProperty("cloud_tasks_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudbuildv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Cloudbuildv2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloudbuildv2_custom_endpoint");
        set => this.WithProperty("cloudbuildv2_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddeploy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ClouddeployCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("clouddeploy_custom_endpoint");
        set => this.WithProperty("clouddeploy_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddomains_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ClouddomainsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("clouddomains_custom_endpoint");
        set => this.WithProperty("clouddomains_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudfunctions2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Cloudfunctions2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cloudfunctions2_custom_endpoint");
        set => this.WithProperty("cloudfunctions2_custom_endpoint", value);
    }

    /// <summary>
    /// The colab_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ColabCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("colab_custom_endpoint");
        set => this.WithProperty("colab_custom_endpoint", value);
    }

    /// <summary>
    /// The composer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ComposerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("composer_custom_endpoint");
        set => this.WithProperty("composer_custom_endpoint", value);
    }

    /// <summary>
    /// The compute_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ComputeCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("compute_custom_endpoint");
        set => this.WithProperty("compute_custom_endpoint", value);
    }

    /// <summary>
    /// The contact_center_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContactCenterInsightsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("contact_center_insights_custom_endpoint");
        set => this.WithProperty("contact_center_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The container_analysis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContainerAnalysisCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("container_analysis_custom_endpoint");
        set => this.WithProperty("container_analysis_custom_endpoint", value);
    }

    /// <summary>
    /// The container_attached_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContainerAttachedCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("container_attached_custom_endpoint");
        set => this.WithProperty("container_attached_custom_endpoint", value);
    }

    /// <summary>
    /// The container_aws_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContainerAwsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("container_aws_custom_endpoint");
        set => this.WithProperty("container_aws_custom_endpoint", value);
    }

    /// <summary>
    /// The container_azure_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContainerAzureCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("container_azure_custom_endpoint");
        set => this.WithProperty("container_azure_custom_endpoint", value);
    }

    /// <summary>
    /// The container_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ContainerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("container_custom_endpoint");
        set => this.WithProperty("container_custom_endpoint", value);
    }

    /// <summary>
    /// The core_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? CoreBillingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("core_billing_custom_endpoint");
        set => this.WithProperty("core_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The credentials configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Credentials
    {
        get => GetProperty<TerraformProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The data_catalog_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataCatalogCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("data_catalog_custom_endpoint");
        set => this.WithProperty("data_catalog_custom_endpoint", value);
    }

    /// <summary>
    /// The data_fusion_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataFusionCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("data_fusion_custom_endpoint");
        set => this.WithProperty("data_fusion_custom_endpoint", value);
    }

    /// <summary>
    /// The data_loss_prevention_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataLossPreventionCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("data_loss_prevention_custom_endpoint");
        set => this.WithProperty("data_loss_prevention_custom_endpoint", value);
    }

    /// <summary>
    /// The data_pipeline_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataPipelineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("data_pipeline_custom_endpoint");
        set => this.WithProperty("data_pipeline_custom_endpoint", value);
    }

    /// <summary>
    /// The database_migration_service_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DatabaseMigrationServiceCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("database_migration_service_custom_endpoint");
        set => this.WithProperty("database_migration_service_custom_endpoint", value);
    }

    /// <summary>
    /// The dataflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataflowCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dataflow_custom_endpoint");
        set => this.WithProperty("dataflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dataplex_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataplexCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dataplex_custom_endpoint");
        set => this.WithProperty("dataplex_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataprocCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dataproc_custom_endpoint");
        set => this.WithProperty("dataproc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_gdc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataprocGdcCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dataproc_gdc_custom_endpoint");
        set => this.WithProperty("dataproc_gdc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_metastore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DataprocMetastoreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dataproc_metastore_custom_endpoint");
        set => this.WithProperty("dataproc_metastore_custom_endpoint", value);
    }

    /// <summary>
    /// The datastream_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DatastreamCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("datastream_custom_endpoint");
        set => this.WithProperty("datastream_custom_endpoint", value);
    }

    /// <summary>
    /// The default_labels configuration.
    /// (Optional)
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? DefaultLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("default_labels");
        set => this.WithProperty("default_labels", value);
    }

    /// <summary>
    /// The deployment_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DeploymentManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("deployment_manager_custom_endpoint");
        set => this.WithProperty("deployment_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The developer_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DeveloperConnectCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("developer_connect_custom_endpoint");
        set => this.WithProperty("developer_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DialogflowCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dialogflow_custom_endpoint");
        set => this.WithProperty("dialogflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_cx_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DialogflowCxCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dialogflow_cx_custom_endpoint");
        set => this.WithProperty("dialogflow_cx_custom_endpoint", value);
    }

    /// <summary>
    /// The discovery_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DiscoveryEngineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("discovery_engine_custom_endpoint");
        set => this.WithProperty("discovery_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The dns_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DnsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("dns_custom_endpoint");
        set => this.WithProperty("dns_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DocumentAiCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("document_ai_custom_endpoint");
        set => this.WithProperty("document_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_warehouse_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? DocumentAiWarehouseCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("document_ai_warehouse_custom_endpoint");
        set => this.WithProperty("document_ai_warehouse_custom_endpoint", value);
    }

    /// <summary>
    /// The edgecontainer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? EdgecontainerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("edgecontainer_custom_endpoint");
        set => this.WithProperty("edgecontainer_custom_endpoint", value);
    }

    /// <summary>
    /// The edgenetwork_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? EdgenetworkCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("edgenetwork_custom_endpoint");
        set => this.WithProperty("edgenetwork_custom_endpoint", value);
    }

    /// <summary>
    /// The essential_contacts_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? EssentialContactsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("essential_contacts_custom_endpoint");
        set => this.WithProperty("essential_contacts_custom_endpoint", value);
    }

    /// <summary>
    /// The eventarc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? EventarcCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("eventarc_custom_endpoint");
        set => this.WithProperty("eventarc_custom_endpoint", value);
    }

    /// <summary>
    /// The filestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FilestoreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("filestore_custom_endpoint");
        set => this.WithProperty("filestore_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_check_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FirebaseAppCheckCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("firebase_app_check_custom_endpoint");
        set => this.WithProperty("firebase_app_check_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_hosting_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FirebaseAppHostingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("firebase_app_hosting_custom_endpoint");
        set => this.WithProperty("firebase_app_hosting_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_data_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FirebaseDataConnectCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("firebase_data_connect_custom_endpoint");
        set => this.WithProperty("firebase_data_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The firebaserules_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FirebaserulesCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("firebaserules_custom_endpoint");
        set => this.WithProperty("firebaserules_custom_endpoint", value);
    }

    /// <summary>
    /// The firestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? FirestoreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("firestore_custom_endpoint");
        set => this.WithProperty("firestore_custom_endpoint", value);
    }

    /// <summary>
    /// The gemini_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? GeminiCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gemini_custom_endpoint");
        set => this.WithProperty("gemini_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_backup_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? GkeBackupCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gke_backup_custom_endpoint");
        set => this.WithProperty("gke_backup_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? GkeHub2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gke_hub2_custom_endpoint");
        set => this.WithProperty("gke_hub2_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? GkeHubCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gke_hub_custom_endpoint");
        set => this.WithProperty("gke_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The gkeonprem_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? GkeonpremCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gkeonprem_custom_endpoint");
        set => this.WithProperty("gkeonprem_custom_endpoint", value);
    }

    /// <summary>
    /// The healthcare_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? HealthcareCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("healthcare_custom_endpoint");
        set => this.WithProperty("healthcare_custom_endpoint", value);
    }

    /// <summary>
    /// The iam2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Iam2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam2_custom_endpoint");
        set => this.WithProperty("iam2_custom_endpoint", value);
    }

    /// <summary>
    /// The iam3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Iam3CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam3_custom_endpoint");
        set => this.WithProperty("iam3_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_beta_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IamBetaCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam_beta_custom_endpoint");
        set => this.WithProperty("iam_beta_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_credentials_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IamCredentialsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam_credentials_custom_endpoint");
        set => this.WithProperty("iam_credentials_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IamCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam_custom_endpoint");
        set => this.WithProperty("iam_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_workforce_pool_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IamWorkforcePoolCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iam_workforce_pool_custom_endpoint");
        set => this.WithProperty("iam_workforce_pool_custom_endpoint", value);
    }

    /// <summary>
    /// The iap_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IapCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("iap_custom_endpoint");
        set => this.WithProperty("iap_custom_endpoint", value);
    }

    /// <summary>
    /// The identity_platform_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IdentityPlatformCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("identity_platform_custom_endpoint");
        set => this.WithProperty("identity_platform_custom_endpoint", value);
    }

    /// <summary>
    /// The impersonate_service_account configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ImpersonateServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("impersonate_service_account");
        set => this.WithProperty("impersonate_service_account", value);
    }

    /// <summary>
    /// The impersonate_service_account_delegates configuration.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>>? ImpersonateServiceAccountDelegates
    {
        get => GetProperty<List<TerraformProperty<string>>>("impersonate_service_account_delegates");
        set => this.WithProperty("impersonate_service_account_delegates", value);
    }

    /// <summary>
    /// The integration_connectors_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IntegrationConnectorsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("integration_connectors_custom_endpoint");
        set => this.WithProperty("integration_connectors_custom_endpoint", value);
    }

    /// <summary>
    /// The integrations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? IntegrationsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("integrations_custom_endpoint");
        set => this.WithProperty("integrations_custom_endpoint", value);
    }

    /// <summary>
    /// The kms_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? KmsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("kms_custom_endpoint");
        set => this.WithProperty("kms_custom_endpoint", value);
    }

    /// <summary>
    /// The logging_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? LoggingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("logging_custom_endpoint");
        set => this.WithProperty("logging_custom_endpoint", value);
    }

    /// <summary>
    /// The looker_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? LookerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("looker_custom_endpoint");
        set => this.WithProperty("looker_custom_endpoint", value);
    }

    /// <summary>
    /// The lustre_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? LustreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("lustre_custom_endpoint");
        set => this.WithProperty("lustre_custom_endpoint", value);
    }

    /// <summary>
    /// The managed_kafka_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ManagedKafkaCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("managed_kafka_custom_endpoint");
        set => this.WithProperty("managed_kafka_custom_endpoint", value);
    }

    /// <summary>
    /// The memcache_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? MemcacheCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("memcache_custom_endpoint");
        set => this.WithProperty("memcache_custom_endpoint", value);
    }

    /// <summary>
    /// The memorystore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? MemorystoreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("memorystore_custom_endpoint");
        set => this.WithProperty("memorystore_custom_endpoint", value);
    }

    /// <summary>
    /// The migration_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? MigrationCenterCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("migration_center_custom_endpoint");
        set => this.WithProperty("migration_center_custom_endpoint", value);
    }

    /// <summary>
    /// The ml_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? MlEngineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("ml_engine_custom_endpoint");
        set => this.WithProperty("ml_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ModelArmorCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("model_armor_custom_endpoint");
        set => this.WithProperty("model_armor_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_global_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ModelArmorGlobalCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("model_armor_global_custom_endpoint");
        set => this.WithProperty("model_armor_global_custom_endpoint", value);
    }

    /// <summary>
    /// The monitoring_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? MonitoringCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("monitoring_custom_endpoint");
        set => this.WithProperty("monitoring_custom_endpoint", value);
    }

    /// <summary>
    /// The netapp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetappCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("netapp_custom_endpoint");
        set => this.WithProperty("netapp_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetworkConnectivityCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("network_connectivity_custom_endpoint");
        set => this.WithProperty("network_connectivity_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivityv1_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetworkConnectivityv1CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("network_connectivityv1_custom_endpoint");
        set => this.WithProperty("network_connectivityv1_custom_endpoint", value);
    }

    /// <summary>
    /// The network_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetworkManagementCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("network_management_custom_endpoint");
        set => this.WithProperty("network_management_custom_endpoint", value);
    }

    /// <summary>
    /// The network_security_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("network_security_custom_endpoint");
        set => this.WithProperty("network_security_custom_endpoint", value);
    }

    /// <summary>
    /// The network_services_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NetworkServicesCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("network_services_custom_endpoint");
        set => this.WithProperty("network_services_custom_endpoint", value);
    }

    /// <summary>
    /// The notebooks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? NotebooksCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("notebooks_custom_endpoint");
        set => this.WithProperty("notebooks_custom_endpoint", value);
    }

    /// <summary>
    /// The observability_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ObservabilityCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("observability_custom_endpoint");
        set => this.WithProperty("observability_custom_endpoint", value);
    }

    /// <summary>
    /// The oracle_database_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? OracleDatabaseCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("oracle_database_custom_endpoint");
        set => this.WithProperty("oracle_database_custom_endpoint", value);
    }

    /// <summary>
    /// The org_policy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? OrgPolicyCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("org_policy_custom_endpoint");
        set => this.WithProperty("org_policy_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? OsConfigCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("os_config_custom_endpoint");
        set => this.WithProperty("os_config_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? OsConfigV2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("os_config_v2_custom_endpoint");
        set => this.WithProperty("os_config_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The os_login_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? OsLoginCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("os_login_custom_endpoint");
        set => this.WithProperty("os_login_custom_endpoint", value);
    }

    /// <summary>
    /// The parallelstore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ParallelstoreCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("parallelstore_custom_endpoint");
        set => this.WithProperty("parallelstore_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ParameterManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("parameter_manager_custom_endpoint");
        set => this.WithProperty("parameter_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ParameterManagerRegionalCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("parameter_manager_regional_custom_endpoint");
        set => this.WithProperty("parameter_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The privateca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? PrivatecaCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("privateca_custom_endpoint");
        set => this.WithProperty("privateca_custom_endpoint", value);
    }

    /// <summary>
    /// The privileged_access_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? PrivilegedAccessManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("privileged_access_manager_custom_endpoint");
        set => this.WithProperty("privileged_access_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The project configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The public_ca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? PublicCaCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("public_ca_custom_endpoint");
        set => this.WithProperty("public_ca_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? PubsubCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("pubsub_custom_endpoint");
        set => this.WithProperty("pubsub_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_lite_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? PubsubLiteCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("pubsub_lite_custom_endpoint");
        set => this.WithProperty("pubsub_lite_custom_endpoint", value);
    }

    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? RecaptchaEnterpriseCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("recaptcha_enterprise_custom_endpoint");
        set => this.WithProperty("recaptcha_enterprise_custom_endpoint", value);
    }

    /// <summary>
    /// The redis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? RedisCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("redis_custom_endpoint");
        set => this.WithProperty("redis_custom_endpoint", value);
    }

    /// <summary>
    /// The region configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_reason configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? RequestReason
    {
        get => GetProperty<TerraformProperty<string>>("request_reason");
        set => this.WithProperty("request_reason", value);
    }

    /// <summary>
    /// The request_timeout configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? RequestTimeout
    {
        get => GetProperty<TerraformProperty<string>>("request_timeout");
        set => this.WithProperty("request_timeout", value);
    }

    /// <summary>
    /// The resource_manager3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ResourceManager3CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("resource_manager3_custom_endpoint");
        set => this.WithProperty("resource_manager3_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ResourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("resource_manager_custom_endpoint");
        set => this.WithProperty("resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_v3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ResourceManagerV3CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("resource_manager_v3_custom_endpoint");
        set => this.WithProperty("resource_manager_v3_custom_endpoint", value);
    }

    /// <summary>
    /// The scopes configuration.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The secret_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecretManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_custom_endpoint");
        set => this.WithProperty("secret_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The secret_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecretManagerRegionalCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("secret_manager_regional_custom_endpoint");
        set => this.WithProperty("secret_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The secure_source_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecureSourceManagerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("secure_source_manager_custom_endpoint");
        set => this.WithProperty("secure_source_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecurityCenterCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("security_center_custom_endpoint");
        set => this.WithProperty("security_center_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecurityCenterManagementCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("security_center_management_custom_endpoint");
        set => this.WithProperty("security_center_management_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecurityCenterV2CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("security_center_v2_custom_endpoint");
        set => this.WithProperty("security_center_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The securityposture_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SecuritypostureCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("securityposture_custom_endpoint");
        set => this.WithProperty("securityposture_custom_endpoint", value);
    }

    /// <summary>
    /// The service_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ServiceManagementCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("service_management_custom_endpoint");
        set => this.WithProperty("service_management_custom_endpoint", value);
    }

    /// <summary>
    /// The service_networking_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ServiceNetworkingCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("service_networking_custom_endpoint");
        set => this.WithProperty("service_networking_custom_endpoint", value);
    }

    /// <summary>
    /// The service_usage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? ServiceUsageCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("service_usage_custom_endpoint");
        set => this.WithProperty("service_usage_custom_endpoint", value);
    }

    /// <summary>
    /// The site_verification_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SiteVerificationCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("site_verification_custom_endpoint");
        set => this.WithProperty("site_verification_custom_endpoint", value);
    }

    /// <summary>
    /// The source_repo_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SourceRepoCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("source_repo_custom_endpoint");
        set => this.WithProperty("source_repo_custom_endpoint", value);
    }

    /// <summary>
    /// The spanner_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SpannerCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("spanner_custom_endpoint");
        set => this.WithProperty("spanner_custom_endpoint", value);
    }

    /// <summary>
    /// The sql_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? SqlCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("sql_custom_endpoint");
        set => this.WithProperty("sql_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_batch_operations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StorageBatchOperationsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_batch_operations_custom_endpoint");
        set => this.WithProperty("storage_batch_operations_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_control_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StorageControlCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_control_custom_endpoint");
        set => this.WithProperty("storage_control_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StorageCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_custom_endpoint");
        set => this.WithProperty("storage_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StorageInsightsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_insights_custom_endpoint");
        set => this.WithProperty("storage_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? StorageTransferCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_transfer_custom_endpoint");
        set => this.WithProperty("storage_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? TagsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("tags_custom_endpoint");
        set => this.WithProperty("tags_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_location_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? TagsLocationCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("tags_location_custom_endpoint");
        set => this.WithProperty("tags_location_custom_endpoint", value);
    }

    /// <summary>
    /// The terraform_attribution_label_addition_strategy configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? TerraformAttributionLabelAdditionStrategy
    {
        get => GetProperty<TerraformProperty<string>>("terraform_attribution_label_addition_strategy");
        set => this.WithProperty("terraform_attribution_label_addition_strategy", value);
    }

    /// <summary>
    /// The transcoder_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? TranscoderCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("transcoder_custom_endpoint");
        set => this.WithProperty("transcoder_custom_endpoint", value);
    }

    /// <summary>
    /// The universe_domain configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? UniverseDomain
    {
        get => GetProperty<TerraformProperty<string>>("universe_domain");
        set => this.WithProperty("universe_domain", value);
    }

    /// <summary>
    /// The user_project_override configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool>? UserProjectOverride
    {
        get => GetProperty<TerraformProperty<bool>>("user_project_override");
        set => this.WithProperty("user_project_override", value);
    }

    /// <summary>
    /// The vertex_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? VertexAiCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("vertex_ai_custom_endpoint");
        set => this.WithProperty("vertex_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The vmwareengine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? VmwareengineCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("vmwareengine_custom_endpoint");
        set => this.WithProperty("vmwareengine_custom_endpoint", value);
    }

    /// <summary>
    /// The vpc_access_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? VpcAccessCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("vpc_access_custom_endpoint");
        set => this.WithProperty("vpc_access_custom_endpoint", value);
    }

    /// <summary>
    /// The workbench_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? WorkbenchCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("workbench_custom_endpoint");
        set => this.WithProperty("workbench_custom_endpoint", value);
    }

    /// <summary>
    /// The workflows_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? WorkflowsCustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("workflows_custom_endpoint");
        set => this.WithProperty("workflows_custom_endpoint", value);
    }

    /// <summary>
    /// The zone configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }
}
