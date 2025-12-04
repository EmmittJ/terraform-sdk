using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for batching in GoogleProvider.
/// Nesting mode: list
/// </summary>
public class GoogleProviderBatchingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batching";

    /// <summary>
    /// The enable_batching attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBatching
    {
        get => GetArgument<TerraformValue<bool>>("enable_batching");
        set => SetArgument("enable_batching", value);
    }

    /// <summary>
    /// The send_after attribute.
    /// </summary>
    public TerraformValue<string>? SendAfter
    {
        get => GetArgument<TerraformValue<string>>("send_after");
        set => SetArgument("send_after", value);
    }

}


/// <summary>
/// Block type for external_credentials in GoogleProvider.
/// Nesting mode: list
/// </summary>
public class GoogleProviderExternalCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_credentials";

    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    public required TerraformValue<string> Audience
    {
        get => GetArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The identity_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityToken is required")]
    public required TerraformValue<string> IdentityToken
    {
        get => GetArgument<TerraformValue<string>>("identity_token");
        set => SetArgument("identity_token", value);
    }

    /// <summary>
    /// The service_account_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

}


/// <summary>
/// Represents the google Terraform provider.
/// Version: ~&gt; 7.0
/// Resources: 1125
/// Data Sources: 387
/// </summary>
public partial class GoogleProvider(string name = "google") : TerraformProvider(name)
{
    /// <summary>
    /// The access_approval_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AccessApprovalCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("access_approval_custom_endpoint");
        set => SetArgument("access_approval_custom_endpoint", value);
    }


    /// <summary>
    /// The access_context_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AccessContextManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("access_context_manager_custom_endpoint");
        set => SetArgument("access_context_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }


    /// <summary>
    /// The active_directory_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("active_directory_custom_endpoint");
        set => SetArgument("active_directory_custom_endpoint", value);
    }


    /// <summary>
    /// The add_terraform_attribution_label attribute.
    /// </summary>
    public TerraformValue<bool>? AddTerraformAttributionLabel
    {
        get => GetArgument<TerraformValue<bool>>("add_terraform_attribution_label");
        set => SetArgument("add_terraform_attribution_label", value);
    }


    /// <summary>
    /// The alloydb_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AlloydbCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("alloydb_custom_endpoint");
        set => SetArgument("alloydb_custom_endpoint", value);
    }


    /// <summary>
    /// The apigee_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApigeeCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("apigee_custom_endpoint");
        set => SetArgument("apigee_custom_endpoint", value);
    }


    /// <summary>
    /// The apihub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApihubCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("apihub_custom_endpoint");
        set => SetArgument("apihub_custom_endpoint", value);
    }


    /// <summary>
    /// The apikeys_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApikeysCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("apikeys_custom_endpoint");
        set => SetArgument("apikeys_custom_endpoint", value);
    }


    /// <summary>
    /// The app_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AppEngineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("app_engine_custom_endpoint");
        set => SetArgument("app_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The apphub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApphubCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("apphub_custom_endpoint");
        set => SetArgument("apphub_custom_endpoint", value);
    }


    /// <summary>
    /// The artifact_registry_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ArtifactRegistryCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("artifact_registry_custom_endpoint");
        set => SetArgument("artifact_registry_custom_endpoint", value);
    }


    /// <summary>
    /// The assured_workloads_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AssuredWorkloadsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("assured_workloads_custom_endpoint");
        set => SetArgument("assured_workloads_custom_endpoint", value);
    }


    /// <summary>
    /// The backup_dr_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BackupDrCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("backup_dr_custom_endpoint");
        set => SetArgument("backup_dr_custom_endpoint", value);
    }


    /// <summary>
    /// The beyondcorp_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BeyondcorpCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("beyondcorp_custom_endpoint");
        set => SetArgument("beyondcorp_custom_endpoint", value);
    }


    /// <summary>
    /// The big_query_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigQueryCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("big_query_custom_endpoint");
        set => SetArgument("big_query_custom_endpoint", value);
    }


    /// <summary>
    /// The biglake_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BiglakeCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("biglake_custom_endpoint");
        set => SetArgument("biglake_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryAnalyticsHubCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_analytics_hub_custom_endpoint");
        set => SetArgument("bigquery_analytics_hub_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_connection_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryConnectionCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_connection_custom_endpoint");
        set => SetArgument("bigquery_connection_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDataTransferCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_data_transfer_custom_endpoint");
        set => SetArgument("bigquery_data_transfer_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_datapolicy_custom_endpoint");
        set => SetArgument("bigquery_datapolicy_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyv2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_datapolicyv2_custom_endpoint");
        set => SetArgument("bigquery_datapolicyv2_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_reservation_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryReservationCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigquery_reservation_custom_endpoint");
        set => SetArgument("bigquery_reservation_custom_endpoint", value);
    }


    /// <summary>
    /// The bigtable_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigtableCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("bigtable_custom_endpoint");
        set => SetArgument("bigtable_custom_endpoint", value);
    }


    /// <summary>
    /// The billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BillingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("billing_custom_endpoint");
        set => SetArgument("billing_custom_endpoint", value);
    }


    /// <summary>
    /// The billing_project attribute.
    /// </summary>
    public TerraformValue<string>? BillingProject
    {
        get => GetArgument<TerraformValue<string>>("billing_project");
        set => SetArgument("billing_project", value);
    }


    /// <summary>
    /// The binary_authorization_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BinaryAuthorizationCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("binary_authorization_custom_endpoint");
        set => SetArgument("binary_authorization_custom_endpoint", value);
    }


    /// <summary>
    /// The blockchain_node_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BlockchainNodeEngineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("blockchain_node_engine_custom_endpoint");
        set => SetArgument("blockchain_node_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The certificate_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CertificateManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("certificate_manager_custom_endpoint");
        set => SetArgument("certificate_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The ces_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CesCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("ces_custom_endpoint");
        set => SetArgument("ces_custom_endpoint", value);
    }


    /// <summary>
    /// The chronicle_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ChronicleCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("chronicle_custom_endpoint");
        set => SetArgument("chronicle_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_asset_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudAssetCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_asset_custom_endpoint");
        set => SetArgument("cloud_asset_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudBillingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_billing_custom_endpoint");
        set => SetArgument("cloud_billing_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_build_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudBuildCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_build_custom_endpoint");
        set => SetArgument("cloud_build_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_functions_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudFunctionsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_functions_custom_endpoint");
        set => SetArgument("cloud_functions_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_identity_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudIdentityCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_identity_custom_endpoint");
        set => SetArgument("cloud_identity_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_ids_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudIdsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_ids_custom_endpoint");
        set => SetArgument("cloud_ids_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_quotas_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudQuotasCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_quotas_custom_endpoint");
        set => SetArgument("cloud_quotas_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_resource_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudResourceManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_resource_manager_custom_endpoint");
        set => SetArgument("cloud_resource_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_run_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudRunCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_run_custom_endpoint");
        set => SetArgument("cloud_run_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_run_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudRunV2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_run_v2_custom_endpoint");
        set => SetArgument("cloud_run_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_scheduler_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudSchedulerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_scheduler_custom_endpoint");
        set => SetArgument("cloud_scheduler_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_tasks_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudTasksCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloud_tasks_custom_endpoint");
        set => SetArgument("cloud_tasks_custom_endpoint", value);
    }


    /// <summary>
    /// The cloudbuildv2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Cloudbuildv2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloudbuildv2_custom_endpoint");
        set => SetArgument("cloudbuildv2_custom_endpoint", value);
    }


    /// <summary>
    /// The clouddeploy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClouddeployCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("clouddeploy_custom_endpoint");
        set => SetArgument("clouddeploy_custom_endpoint", value);
    }


    /// <summary>
    /// The clouddomains_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClouddomainsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("clouddomains_custom_endpoint");
        set => SetArgument("clouddomains_custom_endpoint", value);
    }


    /// <summary>
    /// The cloudfunctions2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Cloudfunctions2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("cloudfunctions2_custom_endpoint");
        set => SetArgument("cloudfunctions2_custom_endpoint", value);
    }


    /// <summary>
    /// The colab_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ColabCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("colab_custom_endpoint");
        set => SetArgument("colab_custom_endpoint", value);
    }


    /// <summary>
    /// The composer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ComposerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("composer_custom_endpoint");
        set => SetArgument("composer_custom_endpoint", value);
    }


    /// <summary>
    /// The compute_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ComputeCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("compute_custom_endpoint");
        set => SetArgument("compute_custom_endpoint", value);
    }


    /// <summary>
    /// The contact_center_insights_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContactCenterInsightsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("contact_center_insights_custom_endpoint");
        set => SetArgument("contact_center_insights_custom_endpoint", value);
    }


    /// <summary>
    /// The container_analysis_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAnalysisCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("container_analysis_custom_endpoint");
        set => SetArgument("container_analysis_custom_endpoint", value);
    }


    /// <summary>
    /// The container_attached_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAttachedCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("container_attached_custom_endpoint");
        set => SetArgument("container_attached_custom_endpoint", value);
    }


    /// <summary>
    /// The container_aws_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAwsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("container_aws_custom_endpoint");
        set => SetArgument("container_aws_custom_endpoint", value);
    }


    /// <summary>
    /// The container_azure_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAzureCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("container_azure_custom_endpoint");
        set => SetArgument("container_azure_custom_endpoint", value);
    }


    /// <summary>
    /// The container_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("container_custom_endpoint");
        set => SetArgument("container_custom_endpoint", value);
    }


    /// <summary>
    /// The core_billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CoreBillingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("core_billing_custom_endpoint");
        set => SetArgument("core_billing_custom_endpoint", value);
    }


    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => GetArgument<TerraformValue<string>>("credentials");
        set => SetArgument("credentials", value);
    }


    /// <summary>
    /// The data_catalog_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataCatalogCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("data_catalog_custom_endpoint");
        set => SetArgument("data_catalog_custom_endpoint", value);
    }


    /// <summary>
    /// The data_fusion_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataFusionCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("data_fusion_custom_endpoint");
        set => SetArgument("data_fusion_custom_endpoint", value);
    }


    /// <summary>
    /// The data_loss_prevention_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataLossPreventionCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("data_loss_prevention_custom_endpoint");
        set => SetArgument("data_loss_prevention_custom_endpoint", value);
    }


    /// <summary>
    /// The data_pipeline_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataPipelineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("data_pipeline_custom_endpoint");
        set => SetArgument("data_pipeline_custom_endpoint", value);
    }


    /// <summary>
    /// The database_migration_service_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseMigrationServiceCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("database_migration_service_custom_endpoint");
        set => SetArgument("database_migration_service_custom_endpoint", value);
    }


    /// <summary>
    /// The dataflow_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataflowCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dataflow_custom_endpoint");
        set => SetArgument("dataflow_custom_endpoint", value);
    }


    /// <summary>
    /// The dataplex_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataplexCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dataplex_custom_endpoint");
        set => SetArgument("dataplex_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dataproc_custom_endpoint");
        set => SetArgument("dataproc_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_gdc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocGdcCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dataproc_gdc_custom_endpoint");
        set => SetArgument("dataproc_gdc_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_metastore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocMetastoreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dataproc_metastore_custom_endpoint");
        set => SetArgument("dataproc_metastore_custom_endpoint", value);
    }


    /// <summary>
    /// The datastream_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DatastreamCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("datastream_custom_endpoint");
        set => SetArgument("datastream_custom_endpoint", value);
    }


    /// <summary>
    /// The default_labels attribute.
    /// </summary>
    public TerraformMap<string>? DefaultLabels
    {
        get => GetArgument<TerraformMap<string>>("default_labels");
        set => SetArgument("default_labels", value);
    }


    /// <summary>
    /// The deployment_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("deployment_manager_custom_endpoint");
        set => SetArgument("deployment_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The developer_connect_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperConnectCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("developer_connect_custom_endpoint");
        set => SetArgument("developer_connect_custom_endpoint", value);
    }


    /// <summary>
    /// The dialogflow_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DialogflowCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dialogflow_custom_endpoint");
        set => SetArgument("dialogflow_custom_endpoint", value);
    }


    /// <summary>
    /// The dialogflow_cx_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DialogflowCxCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dialogflow_cx_custom_endpoint");
        set => SetArgument("dialogflow_cx_custom_endpoint", value);
    }


    /// <summary>
    /// The discovery_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DiscoveryEngineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("discovery_engine_custom_endpoint");
        set => SetArgument("discovery_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The dns_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DnsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("dns_custom_endpoint");
        set => SetArgument("dns_custom_endpoint", value);
    }


    /// <summary>
    /// The document_ai_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DocumentAiCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("document_ai_custom_endpoint");
        set => SetArgument("document_ai_custom_endpoint", value);
    }


    /// <summary>
    /// The document_ai_warehouse_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DocumentAiWarehouseCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("document_ai_warehouse_custom_endpoint");
        set => SetArgument("document_ai_warehouse_custom_endpoint", value);
    }


    /// <summary>
    /// The edgecontainer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EdgecontainerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("edgecontainer_custom_endpoint");
        set => SetArgument("edgecontainer_custom_endpoint", value);
    }


    /// <summary>
    /// The edgenetwork_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EdgenetworkCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("edgenetwork_custom_endpoint");
        set => SetArgument("edgenetwork_custom_endpoint", value);
    }


    /// <summary>
    /// The essential_contacts_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EssentialContactsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("essential_contacts_custom_endpoint");
        set => SetArgument("essential_contacts_custom_endpoint", value);
    }


    /// <summary>
    /// The eventarc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EventarcCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("eventarc_custom_endpoint");
        set => SetArgument("eventarc_custom_endpoint", value);
    }


    /// <summary>
    /// The filestore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FilestoreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("filestore_custom_endpoint");
        set => SetArgument("filestore_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_app_check_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseAppCheckCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("firebase_app_check_custom_endpoint");
        set => SetArgument("firebase_app_check_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_app_hosting_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseAppHostingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("firebase_app_hosting_custom_endpoint");
        set => SetArgument("firebase_app_hosting_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_data_connect_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseDataConnectCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("firebase_data_connect_custom_endpoint");
        set => SetArgument("firebase_data_connect_custom_endpoint", value);
    }


    /// <summary>
    /// The firebaserules_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaserulesCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("firebaserules_custom_endpoint");
        set => SetArgument("firebaserules_custom_endpoint", value);
    }


    /// <summary>
    /// The firestore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirestoreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("firestore_custom_endpoint");
        set => SetArgument("firestore_custom_endpoint", value);
    }


    /// <summary>
    /// The gemini_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GeminiCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gemini_custom_endpoint");
        set => SetArgument("gemini_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_backup_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeBackupCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gke_backup_custom_endpoint");
        set => SetArgument("gke_backup_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_hub2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeHub2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gke_hub2_custom_endpoint");
        set => SetArgument("gke_hub2_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_hub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeHubCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gke_hub_custom_endpoint");
        set => SetArgument("gke_hub_custom_endpoint", value);
    }


    /// <summary>
    /// The gkeonprem_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeonpremCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gkeonprem_custom_endpoint");
        set => SetArgument("gkeonprem_custom_endpoint", value);
    }


    /// <summary>
    /// The healthcare_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? HealthcareCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("healthcare_custom_endpoint");
        set => SetArgument("healthcare_custom_endpoint", value);
    }


    /// <summary>
    /// The iam2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Iam2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam2_custom_endpoint");
        set => SetArgument("iam2_custom_endpoint", value);
    }


    /// <summary>
    /// The iam3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Iam3CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam3_custom_endpoint");
        set => SetArgument("iam3_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_beta_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamBetaCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam_beta_custom_endpoint");
        set => SetArgument("iam_beta_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_credentials_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamCredentialsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam_credentials_custom_endpoint");
        set => SetArgument("iam_credentials_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam_custom_endpoint");
        set => SetArgument("iam_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_workforce_pool_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamWorkforcePoolCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iam_workforce_pool_custom_endpoint");
        set => SetArgument("iam_workforce_pool_custom_endpoint", value);
    }


    /// <summary>
    /// The iap_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IapCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("iap_custom_endpoint");
        set => SetArgument("iap_custom_endpoint", value);
    }


    /// <summary>
    /// The identity_platform_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IdentityPlatformCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("identity_platform_custom_endpoint");
        set => SetArgument("identity_platform_custom_endpoint", value);
    }


    /// <summary>
    /// The impersonate_service_account attribute.
    /// </summary>
    public TerraformValue<string>? ImpersonateServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("impersonate_service_account");
        set => SetArgument("impersonate_service_account", value);
    }


    /// <summary>
    /// The impersonate_service_account_delegates attribute.
    /// </summary>
    public TerraformList<string>? ImpersonateServiceAccountDelegates
    {
        get => GetArgument<TerraformList<string>>("impersonate_service_account_delegates");
        set => SetArgument("impersonate_service_account_delegates", value);
    }


    /// <summary>
    /// The integration_connectors_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationConnectorsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("integration_connectors_custom_endpoint");
        set => SetArgument("integration_connectors_custom_endpoint", value);
    }


    /// <summary>
    /// The integrations_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("integrations_custom_endpoint");
        set => SetArgument("integrations_custom_endpoint", value);
    }


    /// <summary>
    /// The kms_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? KmsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("kms_custom_endpoint");
        set => SetArgument("kms_custom_endpoint", value);
    }


    /// <summary>
    /// The logging_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LoggingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("logging_custom_endpoint");
        set => SetArgument("logging_custom_endpoint", value);
    }


    /// <summary>
    /// The looker_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LookerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("looker_custom_endpoint");
        set => SetArgument("looker_custom_endpoint", value);
    }


    /// <summary>
    /// The lustre_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LustreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("lustre_custom_endpoint");
        set => SetArgument("lustre_custom_endpoint", value);
    }


    /// <summary>
    /// The managed_kafka_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ManagedKafkaCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("managed_kafka_custom_endpoint");
        set => SetArgument("managed_kafka_custom_endpoint", value);
    }


    /// <summary>
    /// The memcache_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MemcacheCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("memcache_custom_endpoint");
        set => SetArgument("memcache_custom_endpoint", value);
    }


    /// <summary>
    /// The memorystore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MemorystoreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("memorystore_custom_endpoint");
        set => SetArgument("memorystore_custom_endpoint", value);
    }


    /// <summary>
    /// The migration_center_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MigrationCenterCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("migration_center_custom_endpoint");
        set => SetArgument("migration_center_custom_endpoint", value);
    }


    /// <summary>
    /// The ml_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MlEngineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("ml_engine_custom_endpoint");
        set => SetArgument("ml_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The model_armor_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ModelArmorCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("model_armor_custom_endpoint");
        set => SetArgument("model_armor_custom_endpoint", value);
    }


    /// <summary>
    /// The model_armor_global_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ModelArmorGlobalCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("model_armor_global_custom_endpoint");
        set => SetArgument("model_armor_global_custom_endpoint", value);
    }


    /// <summary>
    /// The monitoring_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MonitoringCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("monitoring_custom_endpoint");
        set => SetArgument("monitoring_custom_endpoint", value);
    }


    /// <summary>
    /// The netapp_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetappCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("netapp_custom_endpoint");
        set => SetArgument("netapp_custom_endpoint", value);
    }


    /// <summary>
    /// The network_connectivity_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("network_connectivity_custom_endpoint");
        set => SetArgument("network_connectivity_custom_endpoint", value);
    }


    /// <summary>
    /// The network_connectivityv1_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityv1CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("network_connectivityv1_custom_endpoint");
        set => SetArgument("network_connectivityv1_custom_endpoint", value);
    }


    /// <summary>
    /// The network_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkManagementCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("network_management_custom_endpoint");
        set => SetArgument("network_management_custom_endpoint", value);
    }


    /// <summary>
    /// The network_security_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("network_security_custom_endpoint");
        set => SetArgument("network_security_custom_endpoint", value);
    }


    /// <summary>
    /// The network_services_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkServicesCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("network_services_custom_endpoint");
        set => SetArgument("network_services_custom_endpoint", value);
    }


    /// <summary>
    /// The notebooks_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NotebooksCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("notebooks_custom_endpoint");
        set => SetArgument("notebooks_custom_endpoint", value);
    }


    /// <summary>
    /// The observability_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ObservabilityCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("observability_custom_endpoint");
        set => SetArgument("observability_custom_endpoint", value);
    }


    /// <summary>
    /// The oracle_database_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OracleDatabaseCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("oracle_database_custom_endpoint");
        set => SetArgument("oracle_database_custom_endpoint", value);
    }


    /// <summary>
    /// The org_policy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OrgPolicyCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("org_policy_custom_endpoint");
        set => SetArgument("org_policy_custom_endpoint", value);
    }


    /// <summary>
    /// The os_config_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsConfigCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("os_config_custom_endpoint");
        set => SetArgument("os_config_custom_endpoint", value);
    }


    /// <summary>
    /// The os_config_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsConfigV2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("os_config_v2_custom_endpoint");
        set => SetArgument("os_config_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The os_login_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsLoginCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("os_login_custom_endpoint");
        set => SetArgument("os_login_custom_endpoint", value);
    }


    /// <summary>
    /// The parallelstore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParallelstoreCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("parallelstore_custom_endpoint");
        set => SetArgument("parallelstore_custom_endpoint", value);
    }


    /// <summary>
    /// The parameter_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParameterManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("parameter_manager_custom_endpoint");
        set => SetArgument("parameter_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The parameter_manager_regional_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParameterManagerRegionalCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("parameter_manager_regional_custom_endpoint");
        set => SetArgument("parameter_manager_regional_custom_endpoint", value);
    }


    /// <summary>
    /// The privateca_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PrivatecaCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("privateca_custom_endpoint");
        set => SetArgument("privateca_custom_endpoint", value);
    }


    /// <summary>
    /// The privileged_access_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PrivilegedAccessManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("privileged_access_manager_custom_endpoint");
        set => SetArgument("privileged_access_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }


    /// <summary>
    /// The public_ca_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PublicCaCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("public_ca_custom_endpoint");
        set => SetArgument("public_ca_custom_endpoint", value);
    }


    /// <summary>
    /// The pubsub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PubsubCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("pubsub_custom_endpoint");
        set => SetArgument("pubsub_custom_endpoint", value);
    }


    /// <summary>
    /// The pubsub_lite_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PubsubLiteCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("pubsub_lite_custom_endpoint");
        set => SetArgument("pubsub_lite_custom_endpoint", value);
    }


    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? RecaptchaEnterpriseCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("recaptcha_enterprise_custom_endpoint");
        set => SetArgument("recaptcha_enterprise_custom_endpoint", value);
    }


    /// <summary>
    /// The redis_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? RedisCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("redis_custom_endpoint");
        set => SetArgument("redis_custom_endpoint", value);
    }


    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }


    /// <summary>
    /// The request_reason attribute.
    /// </summary>
    public TerraformValue<string>? RequestReason
    {
        get => GetArgument<TerraformValue<string>>("request_reason");
        set => SetArgument("request_reason", value);
    }


    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformValue<string>? RequestTimeout
    {
        get => GetArgument<TerraformValue<string>>("request_timeout");
        set => SetArgument("request_timeout", value);
    }


    /// <summary>
    /// The resource_manager3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManager3CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("resource_manager3_custom_endpoint");
        set => SetArgument("resource_manager3_custom_endpoint", value);
    }


    /// <summary>
    /// The resource_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("resource_manager_custom_endpoint");
        set => SetArgument("resource_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The resource_manager_v3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManagerV3CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("resource_manager_v3_custom_endpoint");
        set => SetArgument("resource_manager_v3_custom_endpoint", value);
    }


    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }


    /// <summary>
    /// The secret_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecretManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_custom_endpoint");
        set => SetArgument("secret_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The secret_manager_regional_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecretManagerRegionalCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_regional_custom_endpoint");
        set => SetArgument("secret_manager_regional_custom_endpoint", value);
    }


    /// <summary>
    /// The secure_source_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecureSourceManagerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("secure_source_manager_custom_endpoint");
        set => SetArgument("secure_source_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("security_center_custom_endpoint");
        set => SetArgument("security_center_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterManagementCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("security_center_management_custom_endpoint");
        set => SetArgument("security_center_management_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterV2CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("security_center_v2_custom_endpoint");
        set => SetArgument("security_center_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The securityposture_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecuritypostureCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("securityposture_custom_endpoint");
        set => SetArgument("securityposture_custom_endpoint", value);
    }


    /// <summary>
    /// The service_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceManagementCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("service_management_custom_endpoint");
        set => SetArgument("service_management_custom_endpoint", value);
    }


    /// <summary>
    /// The service_networking_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceNetworkingCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("service_networking_custom_endpoint");
        set => SetArgument("service_networking_custom_endpoint", value);
    }


    /// <summary>
    /// The service_usage_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceUsageCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("service_usage_custom_endpoint");
        set => SetArgument("service_usage_custom_endpoint", value);
    }


    /// <summary>
    /// The site_verification_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SiteVerificationCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("site_verification_custom_endpoint");
        set => SetArgument("site_verification_custom_endpoint", value);
    }


    /// <summary>
    /// The source_repo_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SourceRepoCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("source_repo_custom_endpoint");
        set => SetArgument("source_repo_custom_endpoint", value);
    }


    /// <summary>
    /// The spanner_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SpannerCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("spanner_custom_endpoint");
        set => SetArgument("spanner_custom_endpoint", value);
    }


    /// <summary>
    /// The sql_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SqlCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("sql_custom_endpoint");
        set => SetArgument("sql_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_batch_operations_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageBatchOperationsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_batch_operations_custom_endpoint");
        set => SetArgument("storage_batch_operations_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_control_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageControlCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_control_custom_endpoint");
        set => SetArgument("storage_control_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_custom_endpoint");
        set => SetArgument("storage_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_insights_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageInsightsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_insights_custom_endpoint");
        set => SetArgument("storage_insights_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_transfer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageTransferCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_transfer_custom_endpoint");
        set => SetArgument("storage_transfer_custom_endpoint", value);
    }


    /// <summary>
    /// The tags_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TagsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("tags_custom_endpoint");
        set => SetArgument("tags_custom_endpoint", value);
    }


    /// <summary>
    /// The tags_location_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TagsLocationCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("tags_location_custom_endpoint");
        set => SetArgument("tags_location_custom_endpoint", value);
    }


    /// <summary>
    /// The terraform_attribution_label_addition_strategy attribute.
    /// </summary>
    public TerraformValue<string>? TerraformAttributionLabelAdditionStrategy
    {
        get => GetArgument<TerraformValue<string>>("terraform_attribution_label_addition_strategy");
        set => SetArgument("terraform_attribution_label_addition_strategy", value);
    }


    /// <summary>
    /// The transcoder_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TranscoderCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("transcoder_custom_endpoint");
        set => SetArgument("transcoder_custom_endpoint", value);
    }


    /// <summary>
    /// The universe_domain attribute.
    /// </summary>
    public TerraformValue<string>? UniverseDomain
    {
        get => GetArgument<TerraformValue<string>>("universe_domain");
        set => SetArgument("universe_domain", value);
    }


    /// <summary>
    /// The user_project_override attribute.
    /// </summary>
    public TerraformValue<bool>? UserProjectOverride
    {
        get => GetArgument<TerraformValue<bool>>("user_project_override");
        set => SetArgument("user_project_override", value);
    }


    /// <summary>
    /// The vertex_ai_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VertexAiCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("vertex_ai_custom_endpoint");
        set => SetArgument("vertex_ai_custom_endpoint", value);
    }


    /// <summary>
    /// The vmwareengine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VmwareengineCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("vmwareengine_custom_endpoint");
        set => SetArgument("vmwareengine_custom_endpoint", value);
    }


    /// <summary>
    /// The vpc_access_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VpcAccessCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("vpc_access_custom_endpoint");
        set => SetArgument("vpc_access_custom_endpoint", value);
    }


    /// <summary>
    /// The workbench_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? WorkbenchCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("workbench_custom_endpoint");
        set => SetArgument("workbench_custom_endpoint", value);
    }


    /// <summary>
    /// The workflows_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? WorkflowsCustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("workflows_custom_endpoint");
        set => SetArgument("workflows_custom_endpoint", value);
    }


    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }


    /// <summary>
    /// Batching block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleProviderBatchingBlock>? Batching
    {
        get => GetArgument<TerraformList<GoogleProviderBatchingBlock>>("batching");
        set => SetArgument("batching", value);
    }

    /// <summary>
    /// ExternalCredentials block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleProviderExternalCredentialsBlock>? ExternalCredentials
    {
        get => GetArgument<TerraformList<GoogleProviderExternalCredentialsBlock>>("external_credentials");
        set => SetArgument("external_credentials", value);
    }

}
