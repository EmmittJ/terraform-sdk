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
        get => new TerraformReference<bool>(this, "enable_batching");
        set => SetArgument("enable_batching", value);
    }

    /// <summary>
    /// The send_after attribute.
    /// </summary>
    public TerraformValue<string>? SendAfter
    {
        get => new TerraformReference<string>(this, "send_after");
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
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The identity_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityToken is required")]
    public required TerraformValue<string> IdentityToken
    {
        get => new TerraformReference<string>(this, "identity_token");
        set => SetArgument("identity_token", value);
    }

    /// <summary>
    /// The service_account_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
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
        get => new TerraformReference<string>(this, "access_approval_custom_endpoint");
        set => SetArgument("access_approval_custom_endpoint", value);
    }


    /// <summary>
    /// The access_context_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AccessContextManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "access_context_manager_custom_endpoint");
        set => SetArgument("access_context_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => new TerraformReference<string>(this, "access_token");
        set => SetArgument("access_token", value);
    }


    /// <summary>
    /// The active_directory_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryCustomEndpoint
    {
        get => new TerraformReference<string>(this, "active_directory_custom_endpoint");
        set => SetArgument("active_directory_custom_endpoint", value);
    }


    /// <summary>
    /// The add_terraform_attribution_label attribute.
    /// </summary>
    public TerraformValue<bool>? AddTerraformAttributionLabel
    {
        get => new TerraformReference<bool>(this, "add_terraform_attribution_label");
        set => SetArgument("add_terraform_attribution_label", value);
    }


    /// <summary>
    /// The alloydb_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AlloydbCustomEndpoint
    {
        get => new TerraformReference<string>(this, "alloydb_custom_endpoint");
        set => SetArgument("alloydb_custom_endpoint", value);
    }


    /// <summary>
    /// The apigee_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApigeeCustomEndpoint
    {
        get => new TerraformReference<string>(this, "apigee_custom_endpoint");
        set => SetArgument("apigee_custom_endpoint", value);
    }


    /// <summary>
    /// The apihub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApihubCustomEndpoint
    {
        get => new TerraformReference<string>(this, "apihub_custom_endpoint");
        set => SetArgument("apihub_custom_endpoint", value);
    }


    /// <summary>
    /// The apikeys_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApikeysCustomEndpoint
    {
        get => new TerraformReference<string>(this, "apikeys_custom_endpoint");
        set => SetArgument("apikeys_custom_endpoint", value);
    }


    /// <summary>
    /// The app_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AppEngineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "app_engine_custom_endpoint");
        set => SetArgument("app_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The apphub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ApphubCustomEndpoint
    {
        get => new TerraformReference<string>(this, "apphub_custom_endpoint");
        set => SetArgument("apphub_custom_endpoint", value);
    }


    /// <summary>
    /// The artifact_registry_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ArtifactRegistryCustomEndpoint
    {
        get => new TerraformReference<string>(this, "artifact_registry_custom_endpoint");
        set => SetArgument("artifact_registry_custom_endpoint", value);
    }


    /// <summary>
    /// The assured_workloads_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AssuredWorkloadsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "assured_workloads_custom_endpoint");
        set => SetArgument("assured_workloads_custom_endpoint", value);
    }


    /// <summary>
    /// The backup_dr_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BackupDrCustomEndpoint
    {
        get => new TerraformReference<string>(this, "backup_dr_custom_endpoint");
        set => SetArgument("backup_dr_custom_endpoint", value);
    }


    /// <summary>
    /// The beyondcorp_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BeyondcorpCustomEndpoint
    {
        get => new TerraformReference<string>(this, "beyondcorp_custom_endpoint");
        set => SetArgument("beyondcorp_custom_endpoint", value);
    }


    /// <summary>
    /// The big_query_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigQueryCustomEndpoint
    {
        get => new TerraformReference<string>(this, "big_query_custom_endpoint");
        set => SetArgument("big_query_custom_endpoint", value);
    }


    /// <summary>
    /// The biglake_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BiglakeCustomEndpoint
    {
        get => new TerraformReference<string>(this, "biglake_custom_endpoint");
        set => SetArgument("biglake_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryAnalyticsHubCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_analytics_hub_custom_endpoint");
        set => SetArgument("bigquery_analytics_hub_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_connection_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryConnectionCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_connection_custom_endpoint");
        set => SetArgument("bigquery_connection_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDataTransferCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_data_transfer_custom_endpoint");
        set => SetArgument("bigquery_data_transfer_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_datapolicy_custom_endpoint");
        set => SetArgument("bigquery_datapolicy_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyv2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_datapolicyv2_custom_endpoint");
        set => SetArgument("bigquery_datapolicyv2_custom_endpoint", value);
    }


    /// <summary>
    /// The bigquery_reservation_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigqueryReservationCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigquery_reservation_custom_endpoint");
        set => SetArgument("bigquery_reservation_custom_endpoint", value);
    }


    /// <summary>
    /// The bigtable_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BigtableCustomEndpoint
    {
        get => new TerraformReference<string>(this, "bigtable_custom_endpoint");
        set => SetArgument("bigtable_custom_endpoint", value);
    }


    /// <summary>
    /// The billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BillingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "billing_custom_endpoint");
        set => SetArgument("billing_custom_endpoint", value);
    }


    /// <summary>
    /// The billing_project attribute.
    /// </summary>
    public TerraformValue<string>? BillingProject
    {
        get => new TerraformReference<string>(this, "billing_project");
        set => SetArgument("billing_project", value);
    }


    /// <summary>
    /// The binary_authorization_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BinaryAuthorizationCustomEndpoint
    {
        get => new TerraformReference<string>(this, "binary_authorization_custom_endpoint");
        set => SetArgument("binary_authorization_custom_endpoint", value);
    }


    /// <summary>
    /// The blockchain_node_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BlockchainNodeEngineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "blockchain_node_engine_custom_endpoint");
        set => SetArgument("blockchain_node_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The certificate_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CertificateManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "certificate_manager_custom_endpoint");
        set => SetArgument("certificate_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The ces_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CesCustomEndpoint
    {
        get => new TerraformReference<string>(this, "ces_custom_endpoint");
        set => SetArgument("ces_custom_endpoint", value);
    }


    /// <summary>
    /// The chronicle_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ChronicleCustomEndpoint
    {
        get => new TerraformReference<string>(this, "chronicle_custom_endpoint");
        set => SetArgument("chronicle_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_asset_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudAssetCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_asset_custom_endpoint");
        set => SetArgument("cloud_asset_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudBillingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_billing_custom_endpoint");
        set => SetArgument("cloud_billing_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_build_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudBuildCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_build_custom_endpoint");
        set => SetArgument("cloud_build_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_functions_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudFunctionsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_functions_custom_endpoint");
        set => SetArgument("cloud_functions_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_identity_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudIdentityCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_identity_custom_endpoint");
        set => SetArgument("cloud_identity_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_ids_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudIdsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_ids_custom_endpoint");
        set => SetArgument("cloud_ids_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_quotas_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudQuotasCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_quotas_custom_endpoint");
        set => SetArgument("cloud_quotas_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_resource_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudResourceManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_resource_manager_custom_endpoint");
        set => SetArgument("cloud_resource_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_run_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudRunCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_run_custom_endpoint");
        set => SetArgument("cloud_run_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_run_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudRunV2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_run_v2_custom_endpoint");
        set => SetArgument("cloud_run_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_scheduler_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudSchedulerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_scheduler_custom_endpoint");
        set => SetArgument("cloud_scheduler_custom_endpoint", value);
    }


    /// <summary>
    /// The cloud_tasks_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CloudTasksCustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloud_tasks_custom_endpoint");
        set => SetArgument("cloud_tasks_custom_endpoint", value);
    }


    /// <summary>
    /// The cloudbuildv2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Cloudbuildv2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloudbuildv2_custom_endpoint");
        set => SetArgument("cloudbuildv2_custom_endpoint", value);
    }


    /// <summary>
    /// The clouddeploy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClouddeployCustomEndpoint
    {
        get => new TerraformReference<string>(this, "clouddeploy_custom_endpoint");
        set => SetArgument("clouddeploy_custom_endpoint", value);
    }


    /// <summary>
    /// The clouddomains_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClouddomainsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "clouddomains_custom_endpoint");
        set => SetArgument("clouddomains_custom_endpoint", value);
    }


    /// <summary>
    /// The cloudfunctions2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Cloudfunctions2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "cloudfunctions2_custom_endpoint");
        set => SetArgument("cloudfunctions2_custom_endpoint", value);
    }


    /// <summary>
    /// The colab_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ColabCustomEndpoint
    {
        get => new TerraformReference<string>(this, "colab_custom_endpoint");
        set => SetArgument("colab_custom_endpoint", value);
    }


    /// <summary>
    /// The composer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ComposerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "composer_custom_endpoint");
        set => SetArgument("composer_custom_endpoint", value);
    }


    /// <summary>
    /// The compute_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ComputeCustomEndpoint
    {
        get => new TerraformReference<string>(this, "compute_custom_endpoint");
        set => SetArgument("compute_custom_endpoint", value);
    }


    /// <summary>
    /// The contact_center_insights_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContactCenterInsightsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "contact_center_insights_custom_endpoint");
        set => SetArgument("contact_center_insights_custom_endpoint", value);
    }


    /// <summary>
    /// The container_analysis_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAnalysisCustomEndpoint
    {
        get => new TerraformReference<string>(this, "container_analysis_custom_endpoint");
        set => SetArgument("container_analysis_custom_endpoint", value);
    }


    /// <summary>
    /// The container_attached_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAttachedCustomEndpoint
    {
        get => new TerraformReference<string>(this, "container_attached_custom_endpoint");
        set => SetArgument("container_attached_custom_endpoint", value);
    }


    /// <summary>
    /// The container_aws_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAwsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "container_aws_custom_endpoint");
        set => SetArgument("container_aws_custom_endpoint", value);
    }


    /// <summary>
    /// The container_azure_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAzureCustomEndpoint
    {
        get => new TerraformReference<string>(this, "container_azure_custom_endpoint");
        set => SetArgument("container_azure_custom_endpoint", value);
    }


    /// <summary>
    /// The container_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ContainerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "container_custom_endpoint");
        set => SetArgument("container_custom_endpoint", value);
    }


    /// <summary>
    /// The core_billing_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CoreBillingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "core_billing_custom_endpoint");
        set => SetArgument("core_billing_custom_endpoint", value);
    }


    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => new TerraformReference<string>(this, "credentials");
        set => SetArgument("credentials", value);
    }


    /// <summary>
    /// The data_catalog_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataCatalogCustomEndpoint
    {
        get => new TerraformReference<string>(this, "data_catalog_custom_endpoint");
        set => SetArgument("data_catalog_custom_endpoint", value);
    }


    /// <summary>
    /// The data_fusion_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataFusionCustomEndpoint
    {
        get => new TerraformReference<string>(this, "data_fusion_custom_endpoint");
        set => SetArgument("data_fusion_custom_endpoint", value);
    }


    /// <summary>
    /// The data_loss_prevention_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataLossPreventionCustomEndpoint
    {
        get => new TerraformReference<string>(this, "data_loss_prevention_custom_endpoint");
        set => SetArgument("data_loss_prevention_custom_endpoint", value);
    }


    /// <summary>
    /// The data_pipeline_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataPipelineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "data_pipeline_custom_endpoint");
        set => SetArgument("data_pipeline_custom_endpoint", value);
    }


    /// <summary>
    /// The database_migration_service_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseMigrationServiceCustomEndpoint
    {
        get => new TerraformReference<string>(this, "database_migration_service_custom_endpoint");
        set => SetArgument("database_migration_service_custom_endpoint", value);
    }


    /// <summary>
    /// The dataflow_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataflowCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dataflow_custom_endpoint");
        set => SetArgument("dataflow_custom_endpoint", value);
    }


    /// <summary>
    /// The dataplex_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataplexCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dataplex_custom_endpoint");
        set => SetArgument("dataplex_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dataproc_custom_endpoint");
        set => SetArgument("dataproc_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_gdc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocGdcCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dataproc_gdc_custom_endpoint");
        set => SetArgument("dataproc_gdc_custom_endpoint", value);
    }


    /// <summary>
    /// The dataproc_metastore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DataprocMetastoreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dataproc_metastore_custom_endpoint");
        set => SetArgument("dataproc_metastore_custom_endpoint", value);
    }


    /// <summary>
    /// The datastream_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DatastreamCustomEndpoint
    {
        get => new TerraformReference<string>(this, "datastream_custom_endpoint");
        set => SetArgument("datastream_custom_endpoint", value);
    }


    /// <summary>
    /// The default_labels attribute.
    /// </summary>
    public TerraformMap<string>? DefaultLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "default_labels").ResolveNodes(ctx));
        set => SetArgument("default_labels", value);
    }


    /// <summary>
    /// The deployment_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "deployment_manager_custom_endpoint");
        set => SetArgument("deployment_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The developer_connect_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperConnectCustomEndpoint
    {
        get => new TerraformReference<string>(this, "developer_connect_custom_endpoint");
        set => SetArgument("developer_connect_custom_endpoint", value);
    }


    /// <summary>
    /// The dialogflow_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DialogflowCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dialogflow_custom_endpoint");
        set => SetArgument("dialogflow_custom_endpoint", value);
    }


    /// <summary>
    /// The dialogflow_cx_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DialogflowCxCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dialogflow_cx_custom_endpoint");
        set => SetArgument("dialogflow_cx_custom_endpoint", value);
    }


    /// <summary>
    /// The discovery_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DiscoveryEngineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "discovery_engine_custom_endpoint");
        set => SetArgument("discovery_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The dns_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DnsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "dns_custom_endpoint");
        set => SetArgument("dns_custom_endpoint", value);
    }


    /// <summary>
    /// The document_ai_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DocumentAiCustomEndpoint
    {
        get => new TerraformReference<string>(this, "document_ai_custom_endpoint");
        set => SetArgument("document_ai_custom_endpoint", value);
    }


    /// <summary>
    /// The document_ai_warehouse_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? DocumentAiWarehouseCustomEndpoint
    {
        get => new TerraformReference<string>(this, "document_ai_warehouse_custom_endpoint");
        set => SetArgument("document_ai_warehouse_custom_endpoint", value);
    }


    /// <summary>
    /// The edgecontainer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EdgecontainerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "edgecontainer_custom_endpoint");
        set => SetArgument("edgecontainer_custom_endpoint", value);
    }


    /// <summary>
    /// The edgenetwork_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EdgenetworkCustomEndpoint
    {
        get => new TerraformReference<string>(this, "edgenetwork_custom_endpoint");
        set => SetArgument("edgenetwork_custom_endpoint", value);
    }


    /// <summary>
    /// The essential_contacts_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EssentialContactsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "essential_contacts_custom_endpoint");
        set => SetArgument("essential_contacts_custom_endpoint", value);
    }


    /// <summary>
    /// The eventarc_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? EventarcCustomEndpoint
    {
        get => new TerraformReference<string>(this, "eventarc_custom_endpoint");
        set => SetArgument("eventarc_custom_endpoint", value);
    }


    /// <summary>
    /// The filestore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FilestoreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "filestore_custom_endpoint");
        set => SetArgument("filestore_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_app_check_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseAppCheckCustomEndpoint
    {
        get => new TerraformReference<string>(this, "firebase_app_check_custom_endpoint");
        set => SetArgument("firebase_app_check_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_app_hosting_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseAppHostingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "firebase_app_hosting_custom_endpoint");
        set => SetArgument("firebase_app_hosting_custom_endpoint", value);
    }


    /// <summary>
    /// The firebase_data_connect_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaseDataConnectCustomEndpoint
    {
        get => new TerraformReference<string>(this, "firebase_data_connect_custom_endpoint");
        set => SetArgument("firebase_data_connect_custom_endpoint", value);
    }


    /// <summary>
    /// The firebaserules_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirebaserulesCustomEndpoint
    {
        get => new TerraformReference<string>(this, "firebaserules_custom_endpoint");
        set => SetArgument("firebaserules_custom_endpoint", value);
    }


    /// <summary>
    /// The firestore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? FirestoreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "firestore_custom_endpoint");
        set => SetArgument("firestore_custom_endpoint", value);
    }


    /// <summary>
    /// The gemini_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GeminiCustomEndpoint
    {
        get => new TerraformReference<string>(this, "gemini_custom_endpoint");
        set => SetArgument("gemini_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_backup_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeBackupCustomEndpoint
    {
        get => new TerraformReference<string>(this, "gke_backup_custom_endpoint");
        set => SetArgument("gke_backup_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_hub2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeHub2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "gke_hub2_custom_endpoint");
        set => SetArgument("gke_hub2_custom_endpoint", value);
    }


    /// <summary>
    /// The gke_hub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeHubCustomEndpoint
    {
        get => new TerraformReference<string>(this, "gke_hub_custom_endpoint");
        set => SetArgument("gke_hub_custom_endpoint", value);
    }


    /// <summary>
    /// The gkeonprem_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GkeonpremCustomEndpoint
    {
        get => new TerraformReference<string>(this, "gkeonprem_custom_endpoint");
        set => SetArgument("gkeonprem_custom_endpoint", value);
    }


    /// <summary>
    /// The healthcare_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? HealthcareCustomEndpoint
    {
        get => new TerraformReference<string>(this, "healthcare_custom_endpoint");
        set => SetArgument("healthcare_custom_endpoint", value);
    }


    /// <summary>
    /// The iam2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Iam2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam2_custom_endpoint");
        set => SetArgument("iam2_custom_endpoint", value);
    }


    /// <summary>
    /// The iam3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Iam3CustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam3_custom_endpoint");
        set => SetArgument("iam3_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_beta_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamBetaCustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam_beta_custom_endpoint");
        set => SetArgument("iam_beta_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_credentials_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamCredentialsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam_credentials_custom_endpoint");
        set => SetArgument("iam_credentials_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamCustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam_custom_endpoint");
        set => SetArgument("iam_custom_endpoint", value);
    }


    /// <summary>
    /// The iam_workforce_pool_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IamWorkforcePoolCustomEndpoint
    {
        get => new TerraformReference<string>(this, "iam_workforce_pool_custom_endpoint");
        set => SetArgument("iam_workforce_pool_custom_endpoint", value);
    }


    /// <summary>
    /// The iap_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IapCustomEndpoint
    {
        get => new TerraformReference<string>(this, "iap_custom_endpoint");
        set => SetArgument("iap_custom_endpoint", value);
    }


    /// <summary>
    /// The identity_platform_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IdentityPlatformCustomEndpoint
    {
        get => new TerraformReference<string>(this, "identity_platform_custom_endpoint");
        set => SetArgument("identity_platform_custom_endpoint", value);
    }


    /// <summary>
    /// The impersonate_service_account attribute.
    /// </summary>
    public TerraformValue<string>? ImpersonateServiceAccount
    {
        get => new TerraformReference<string>(this, "impersonate_service_account");
        set => SetArgument("impersonate_service_account", value);
    }


    /// <summary>
    /// The impersonate_service_account_delegates attribute.
    /// </summary>
    public TerraformList<string>? ImpersonateServiceAccountDelegates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "impersonate_service_account_delegates").ResolveNodes(ctx));
        set => SetArgument("impersonate_service_account_delegates", value);
    }


    /// <summary>
    /// The integration_connectors_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationConnectorsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "integration_connectors_custom_endpoint");
        set => SetArgument("integration_connectors_custom_endpoint", value);
    }


    /// <summary>
    /// The integrations_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "integrations_custom_endpoint");
        set => SetArgument("integrations_custom_endpoint", value);
    }


    /// <summary>
    /// The kms_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? KmsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "kms_custom_endpoint");
        set => SetArgument("kms_custom_endpoint", value);
    }


    /// <summary>
    /// The logging_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LoggingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "logging_custom_endpoint");
        set => SetArgument("logging_custom_endpoint", value);
    }


    /// <summary>
    /// The looker_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LookerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "looker_custom_endpoint");
        set => SetArgument("looker_custom_endpoint", value);
    }


    /// <summary>
    /// The lustre_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? LustreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "lustre_custom_endpoint");
        set => SetArgument("lustre_custom_endpoint", value);
    }


    /// <summary>
    /// The managed_kafka_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ManagedKafkaCustomEndpoint
    {
        get => new TerraformReference<string>(this, "managed_kafka_custom_endpoint");
        set => SetArgument("managed_kafka_custom_endpoint", value);
    }


    /// <summary>
    /// The memcache_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MemcacheCustomEndpoint
    {
        get => new TerraformReference<string>(this, "memcache_custom_endpoint");
        set => SetArgument("memcache_custom_endpoint", value);
    }


    /// <summary>
    /// The memorystore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MemorystoreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "memorystore_custom_endpoint");
        set => SetArgument("memorystore_custom_endpoint", value);
    }


    /// <summary>
    /// The migration_center_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MigrationCenterCustomEndpoint
    {
        get => new TerraformReference<string>(this, "migration_center_custom_endpoint");
        set => SetArgument("migration_center_custom_endpoint", value);
    }


    /// <summary>
    /// The ml_engine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MlEngineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "ml_engine_custom_endpoint");
        set => SetArgument("ml_engine_custom_endpoint", value);
    }


    /// <summary>
    /// The model_armor_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ModelArmorCustomEndpoint
    {
        get => new TerraformReference<string>(this, "model_armor_custom_endpoint");
        set => SetArgument("model_armor_custom_endpoint", value);
    }


    /// <summary>
    /// The model_armor_global_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ModelArmorGlobalCustomEndpoint
    {
        get => new TerraformReference<string>(this, "model_armor_global_custom_endpoint");
        set => SetArgument("model_armor_global_custom_endpoint", value);
    }


    /// <summary>
    /// The monitoring_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? MonitoringCustomEndpoint
    {
        get => new TerraformReference<string>(this, "monitoring_custom_endpoint");
        set => SetArgument("monitoring_custom_endpoint", value);
    }


    /// <summary>
    /// The netapp_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetappCustomEndpoint
    {
        get => new TerraformReference<string>(this, "netapp_custom_endpoint");
        set => SetArgument("netapp_custom_endpoint", value);
    }


    /// <summary>
    /// The network_connectivity_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityCustomEndpoint
    {
        get => new TerraformReference<string>(this, "network_connectivity_custom_endpoint");
        set => SetArgument("network_connectivity_custom_endpoint", value);
    }


    /// <summary>
    /// The network_connectivityv1_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityv1CustomEndpoint
    {
        get => new TerraformReference<string>(this, "network_connectivityv1_custom_endpoint");
        set => SetArgument("network_connectivityv1_custom_endpoint", value);
    }


    /// <summary>
    /// The network_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkManagementCustomEndpoint
    {
        get => new TerraformReference<string>(this, "network_management_custom_endpoint");
        set => SetArgument("network_management_custom_endpoint", value);
    }


    /// <summary>
    /// The network_security_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityCustomEndpoint
    {
        get => new TerraformReference<string>(this, "network_security_custom_endpoint");
        set => SetArgument("network_security_custom_endpoint", value);
    }


    /// <summary>
    /// The network_services_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NetworkServicesCustomEndpoint
    {
        get => new TerraformReference<string>(this, "network_services_custom_endpoint");
        set => SetArgument("network_services_custom_endpoint", value);
    }


    /// <summary>
    /// The notebooks_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? NotebooksCustomEndpoint
    {
        get => new TerraformReference<string>(this, "notebooks_custom_endpoint");
        set => SetArgument("notebooks_custom_endpoint", value);
    }


    /// <summary>
    /// The observability_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ObservabilityCustomEndpoint
    {
        get => new TerraformReference<string>(this, "observability_custom_endpoint");
        set => SetArgument("observability_custom_endpoint", value);
    }


    /// <summary>
    /// The oracle_database_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OracleDatabaseCustomEndpoint
    {
        get => new TerraformReference<string>(this, "oracle_database_custom_endpoint");
        set => SetArgument("oracle_database_custom_endpoint", value);
    }


    /// <summary>
    /// The org_policy_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OrgPolicyCustomEndpoint
    {
        get => new TerraformReference<string>(this, "org_policy_custom_endpoint");
        set => SetArgument("org_policy_custom_endpoint", value);
    }


    /// <summary>
    /// The os_config_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsConfigCustomEndpoint
    {
        get => new TerraformReference<string>(this, "os_config_custom_endpoint");
        set => SetArgument("os_config_custom_endpoint", value);
    }


    /// <summary>
    /// The os_config_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsConfigV2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "os_config_v2_custom_endpoint");
        set => SetArgument("os_config_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The os_login_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? OsLoginCustomEndpoint
    {
        get => new TerraformReference<string>(this, "os_login_custom_endpoint");
        set => SetArgument("os_login_custom_endpoint", value);
    }


    /// <summary>
    /// The parallelstore_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParallelstoreCustomEndpoint
    {
        get => new TerraformReference<string>(this, "parallelstore_custom_endpoint");
        set => SetArgument("parallelstore_custom_endpoint", value);
    }


    /// <summary>
    /// The parameter_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParameterManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "parameter_manager_custom_endpoint");
        set => SetArgument("parameter_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The parameter_manager_regional_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ParameterManagerRegionalCustomEndpoint
    {
        get => new TerraformReference<string>(this, "parameter_manager_regional_custom_endpoint");
        set => SetArgument("parameter_manager_regional_custom_endpoint", value);
    }


    /// <summary>
    /// The privateca_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PrivatecaCustomEndpoint
    {
        get => new TerraformReference<string>(this, "privateca_custom_endpoint");
        set => SetArgument("privateca_custom_endpoint", value);
    }


    /// <summary>
    /// The privileged_access_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PrivilegedAccessManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "privileged_access_manager_custom_endpoint");
        set => SetArgument("privileged_access_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }


    /// <summary>
    /// The public_ca_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PublicCaCustomEndpoint
    {
        get => new TerraformReference<string>(this, "public_ca_custom_endpoint");
        set => SetArgument("public_ca_custom_endpoint", value);
    }


    /// <summary>
    /// The pubsub_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PubsubCustomEndpoint
    {
        get => new TerraformReference<string>(this, "pubsub_custom_endpoint");
        set => SetArgument("pubsub_custom_endpoint", value);
    }


    /// <summary>
    /// The pubsub_lite_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PubsubLiteCustomEndpoint
    {
        get => new TerraformReference<string>(this, "pubsub_lite_custom_endpoint");
        set => SetArgument("pubsub_lite_custom_endpoint", value);
    }


    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? RecaptchaEnterpriseCustomEndpoint
    {
        get => new TerraformReference<string>(this, "recaptcha_enterprise_custom_endpoint");
        set => SetArgument("recaptcha_enterprise_custom_endpoint", value);
    }


    /// <summary>
    /// The redis_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? RedisCustomEndpoint
    {
        get => new TerraformReference<string>(this, "redis_custom_endpoint");
        set => SetArgument("redis_custom_endpoint", value);
    }


    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }


    /// <summary>
    /// The request_reason attribute.
    /// </summary>
    public TerraformValue<string>? RequestReason
    {
        get => new TerraformReference<string>(this, "request_reason");
        set => SetArgument("request_reason", value);
    }


    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformValue<string>? RequestTimeout
    {
        get => new TerraformReference<string>(this, "request_timeout");
        set => SetArgument("request_timeout", value);
    }


    /// <summary>
    /// The resource_manager3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManager3CustomEndpoint
    {
        get => new TerraformReference<string>(this, "resource_manager3_custom_endpoint");
        set => SetArgument("resource_manager3_custom_endpoint", value);
    }


    /// <summary>
    /// The resource_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "resource_manager_custom_endpoint");
        set => SetArgument("resource_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The resource_manager_v3_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ResourceManagerV3CustomEndpoint
    {
        get => new TerraformReference<string>(this, "resource_manager_v3_custom_endpoint");
        set => SetArgument("resource_manager_v3_custom_endpoint", value);
    }


    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }


    /// <summary>
    /// The secret_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecretManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "secret_manager_custom_endpoint");
        set => SetArgument("secret_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The secret_manager_regional_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecretManagerRegionalCustomEndpoint
    {
        get => new TerraformReference<string>(this, "secret_manager_regional_custom_endpoint");
        set => SetArgument("secret_manager_regional_custom_endpoint", value);
    }


    /// <summary>
    /// The secure_source_manager_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecureSourceManagerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "secure_source_manager_custom_endpoint");
        set => SetArgument("secure_source_manager_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterCustomEndpoint
    {
        get => new TerraformReference<string>(this, "security_center_custom_endpoint");
        set => SetArgument("security_center_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterManagementCustomEndpoint
    {
        get => new TerraformReference<string>(this, "security_center_management_custom_endpoint");
        set => SetArgument("security_center_management_custom_endpoint", value);
    }


    /// <summary>
    /// The security_center_v2_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecurityCenterV2CustomEndpoint
    {
        get => new TerraformReference<string>(this, "security_center_v2_custom_endpoint");
        set => SetArgument("security_center_v2_custom_endpoint", value);
    }


    /// <summary>
    /// The securityposture_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SecuritypostureCustomEndpoint
    {
        get => new TerraformReference<string>(this, "securityposture_custom_endpoint");
        set => SetArgument("securityposture_custom_endpoint", value);
    }


    /// <summary>
    /// The service_management_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceManagementCustomEndpoint
    {
        get => new TerraformReference<string>(this, "service_management_custom_endpoint");
        set => SetArgument("service_management_custom_endpoint", value);
    }


    /// <summary>
    /// The service_networking_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceNetworkingCustomEndpoint
    {
        get => new TerraformReference<string>(this, "service_networking_custom_endpoint");
        set => SetArgument("service_networking_custom_endpoint", value);
    }


    /// <summary>
    /// The service_usage_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ServiceUsageCustomEndpoint
    {
        get => new TerraformReference<string>(this, "service_usage_custom_endpoint");
        set => SetArgument("service_usage_custom_endpoint", value);
    }


    /// <summary>
    /// The site_verification_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SiteVerificationCustomEndpoint
    {
        get => new TerraformReference<string>(this, "site_verification_custom_endpoint");
        set => SetArgument("site_verification_custom_endpoint", value);
    }


    /// <summary>
    /// The source_repo_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SourceRepoCustomEndpoint
    {
        get => new TerraformReference<string>(this, "source_repo_custom_endpoint");
        set => SetArgument("source_repo_custom_endpoint", value);
    }


    /// <summary>
    /// The spanner_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SpannerCustomEndpoint
    {
        get => new TerraformReference<string>(this, "spanner_custom_endpoint");
        set => SetArgument("spanner_custom_endpoint", value);
    }


    /// <summary>
    /// The sql_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? SqlCustomEndpoint
    {
        get => new TerraformReference<string>(this, "sql_custom_endpoint");
        set => SetArgument("sql_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_batch_operations_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageBatchOperationsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "storage_batch_operations_custom_endpoint");
        set => SetArgument("storage_batch_operations_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_control_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageControlCustomEndpoint
    {
        get => new TerraformReference<string>(this, "storage_control_custom_endpoint");
        set => SetArgument("storage_control_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageCustomEndpoint
    {
        get => new TerraformReference<string>(this, "storage_custom_endpoint");
        set => SetArgument("storage_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_insights_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageInsightsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "storage_insights_custom_endpoint");
        set => SetArgument("storage_insights_custom_endpoint", value);
    }


    /// <summary>
    /// The storage_transfer_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageTransferCustomEndpoint
    {
        get => new TerraformReference<string>(this, "storage_transfer_custom_endpoint");
        set => SetArgument("storage_transfer_custom_endpoint", value);
    }


    /// <summary>
    /// The tags_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TagsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "tags_custom_endpoint");
        set => SetArgument("tags_custom_endpoint", value);
    }


    /// <summary>
    /// The tags_location_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TagsLocationCustomEndpoint
    {
        get => new TerraformReference<string>(this, "tags_location_custom_endpoint");
        set => SetArgument("tags_location_custom_endpoint", value);
    }


    /// <summary>
    /// The terraform_attribution_label_addition_strategy attribute.
    /// </summary>
    public TerraformValue<string>? TerraformAttributionLabelAdditionStrategy
    {
        get => new TerraformReference<string>(this, "terraform_attribution_label_addition_strategy");
        set => SetArgument("terraform_attribution_label_addition_strategy", value);
    }


    /// <summary>
    /// The transcoder_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TranscoderCustomEndpoint
    {
        get => new TerraformReference<string>(this, "transcoder_custom_endpoint");
        set => SetArgument("transcoder_custom_endpoint", value);
    }


    /// <summary>
    /// The universe_domain attribute.
    /// </summary>
    public TerraformValue<string>? UniverseDomain
    {
        get => new TerraformReference<string>(this, "universe_domain");
        set => SetArgument("universe_domain", value);
    }


    /// <summary>
    /// The user_project_override attribute.
    /// </summary>
    public TerraformValue<bool>? UserProjectOverride
    {
        get => new TerraformReference<bool>(this, "user_project_override");
        set => SetArgument("user_project_override", value);
    }


    /// <summary>
    /// The vertex_ai_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VertexAiCustomEndpoint
    {
        get => new TerraformReference<string>(this, "vertex_ai_custom_endpoint");
        set => SetArgument("vertex_ai_custom_endpoint", value);
    }


    /// <summary>
    /// The vmwareengine_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VmwareengineCustomEndpoint
    {
        get => new TerraformReference<string>(this, "vmwareengine_custom_endpoint");
        set => SetArgument("vmwareengine_custom_endpoint", value);
    }


    /// <summary>
    /// The vpc_access_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? VpcAccessCustomEndpoint
    {
        get => new TerraformReference<string>(this, "vpc_access_custom_endpoint");
        set => SetArgument("vpc_access_custom_endpoint", value);
    }


    /// <summary>
    /// The workbench_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? WorkbenchCustomEndpoint
    {
        get => new TerraformReference<string>(this, "workbench_custom_endpoint");
        set => SetArgument("workbench_custom_endpoint", value);
    }


    /// <summary>
    /// The workflows_custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? WorkflowsCustomEndpoint
    {
        get => new TerraformReference<string>(this, "workflows_custom_endpoint");
        set => SetArgument("workflows_custom_endpoint", value);
    }


    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
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
