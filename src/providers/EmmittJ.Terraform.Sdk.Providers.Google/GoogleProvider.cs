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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_approval_custom_endpoint");
        SetOutput("access_context_manager_custom_endpoint");
        SetOutput("access_token");
        SetOutput("active_directory_custom_endpoint");
        SetOutput("add_terraform_attribution_label");
        SetOutput("alloydb_custom_endpoint");
        SetOutput("apigee_custom_endpoint");
        SetOutput("apihub_custom_endpoint");
        SetOutput("apikeys_custom_endpoint");
        SetOutput("app_engine_custom_endpoint");
        SetOutput("apphub_custom_endpoint");
        SetOutput("artifact_registry_custom_endpoint");
        SetOutput("assured_workloads_custom_endpoint");
        SetOutput("backup_dr_custom_endpoint");
        SetOutput("beyondcorp_custom_endpoint");
        SetOutput("big_query_custom_endpoint");
        SetOutput("biglake_custom_endpoint");
        SetOutput("bigquery_analytics_hub_custom_endpoint");
        SetOutput("bigquery_connection_custom_endpoint");
        SetOutput("bigquery_data_transfer_custom_endpoint");
        SetOutput("bigquery_datapolicy_custom_endpoint");
        SetOutput("bigquery_datapolicyv2_custom_endpoint");
        SetOutput("bigquery_reservation_custom_endpoint");
        SetOutput("bigtable_custom_endpoint");
        SetOutput("billing_custom_endpoint");
        SetOutput("billing_project");
        SetOutput("binary_authorization_custom_endpoint");
        SetOutput("blockchain_node_engine_custom_endpoint");
        SetOutput("certificate_manager_custom_endpoint");
        SetOutput("ces_custom_endpoint");
        SetOutput("chronicle_custom_endpoint");
        SetOutput("cloud_asset_custom_endpoint");
        SetOutput("cloud_billing_custom_endpoint");
        SetOutput("cloud_build_custom_endpoint");
        SetOutput("cloud_functions_custom_endpoint");
        SetOutput("cloud_identity_custom_endpoint");
        SetOutput("cloud_ids_custom_endpoint");
        SetOutput("cloud_quotas_custom_endpoint");
        SetOutput("cloud_resource_manager_custom_endpoint");
        SetOutput("cloud_run_custom_endpoint");
        SetOutput("cloud_run_v2_custom_endpoint");
        SetOutput("cloud_scheduler_custom_endpoint");
        SetOutput("cloud_tasks_custom_endpoint");
        SetOutput("cloudbuildv2_custom_endpoint");
        SetOutput("clouddeploy_custom_endpoint");
        SetOutput("clouddomains_custom_endpoint");
        SetOutput("cloudfunctions2_custom_endpoint");
        SetOutput("colab_custom_endpoint");
        SetOutput("composer_custom_endpoint");
        SetOutput("compute_custom_endpoint");
        SetOutput("contact_center_insights_custom_endpoint");
        SetOutput("container_analysis_custom_endpoint");
        SetOutput("container_attached_custom_endpoint");
        SetOutput("container_aws_custom_endpoint");
        SetOutput("container_azure_custom_endpoint");
        SetOutput("container_custom_endpoint");
        SetOutput("core_billing_custom_endpoint");
        SetOutput("credentials");
        SetOutput("data_catalog_custom_endpoint");
        SetOutput("data_fusion_custom_endpoint");
        SetOutput("data_loss_prevention_custom_endpoint");
        SetOutput("data_pipeline_custom_endpoint");
        SetOutput("database_migration_service_custom_endpoint");
        SetOutput("dataflow_custom_endpoint");
        SetOutput("dataplex_custom_endpoint");
        SetOutput("dataproc_custom_endpoint");
        SetOutput("dataproc_gdc_custom_endpoint");
        SetOutput("dataproc_metastore_custom_endpoint");
        SetOutput("datastream_custom_endpoint");
        SetOutput("default_labels");
        SetOutput("deployment_manager_custom_endpoint");
        SetOutput("developer_connect_custom_endpoint");
        SetOutput("dialogflow_custom_endpoint");
        SetOutput("dialogflow_cx_custom_endpoint");
        SetOutput("discovery_engine_custom_endpoint");
        SetOutput("dns_custom_endpoint");
        SetOutput("document_ai_custom_endpoint");
        SetOutput("document_ai_warehouse_custom_endpoint");
        SetOutput("edgecontainer_custom_endpoint");
        SetOutput("edgenetwork_custom_endpoint");
        SetOutput("essential_contacts_custom_endpoint");
        SetOutput("eventarc_custom_endpoint");
        SetOutput("filestore_custom_endpoint");
        SetOutput("firebase_app_check_custom_endpoint");
        SetOutput("firebase_app_hosting_custom_endpoint");
        SetOutput("firebase_data_connect_custom_endpoint");
        SetOutput("firebaserules_custom_endpoint");
        SetOutput("firestore_custom_endpoint");
        SetOutput("gemini_custom_endpoint");
        SetOutput("gke_backup_custom_endpoint");
        SetOutput("gke_hub2_custom_endpoint");
        SetOutput("gke_hub_custom_endpoint");
        SetOutput("gkeonprem_custom_endpoint");
        SetOutput("healthcare_custom_endpoint");
        SetOutput("iam2_custom_endpoint");
        SetOutput("iam3_custom_endpoint");
        SetOutput("iam_beta_custom_endpoint");
        SetOutput("iam_credentials_custom_endpoint");
        SetOutput("iam_custom_endpoint");
        SetOutput("iam_workforce_pool_custom_endpoint");
        SetOutput("iap_custom_endpoint");
        SetOutput("identity_platform_custom_endpoint");
        SetOutput("impersonate_service_account");
        SetOutput("impersonate_service_account_delegates");
        SetOutput("integration_connectors_custom_endpoint");
        SetOutput("integrations_custom_endpoint");
        SetOutput("kms_custom_endpoint");
        SetOutput("logging_custom_endpoint");
        SetOutput("looker_custom_endpoint");
        SetOutput("lustre_custom_endpoint");
        SetOutput("managed_kafka_custom_endpoint");
        SetOutput("memcache_custom_endpoint");
        SetOutput("memorystore_custom_endpoint");
        SetOutput("migration_center_custom_endpoint");
        SetOutput("ml_engine_custom_endpoint");
        SetOutput("model_armor_custom_endpoint");
        SetOutput("model_armor_global_custom_endpoint");
        SetOutput("monitoring_custom_endpoint");
        SetOutput("netapp_custom_endpoint");
        SetOutput("network_connectivity_custom_endpoint");
        SetOutput("network_connectivityv1_custom_endpoint");
        SetOutput("network_management_custom_endpoint");
        SetOutput("network_security_custom_endpoint");
        SetOutput("network_services_custom_endpoint");
        SetOutput("notebooks_custom_endpoint");
        SetOutput("observability_custom_endpoint");
        SetOutput("oracle_database_custom_endpoint");
        SetOutput("org_policy_custom_endpoint");
        SetOutput("os_config_custom_endpoint");
        SetOutput("os_config_v2_custom_endpoint");
        SetOutput("os_login_custom_endpoint");
        SetOutput("parallelstore_custom_endpoint");
        SetOutput("parameter_manager_custom_endpoint");
        SetOutput("parameter_manager_regional_custom_endpoint");
        SetOutput("privateca_custom_endpoint");
        SetOutput("privileged_access_manager_custom_endpoint");
        SetOutput("project");
        SetOutput("public_ca_custom_endpoint");
        SetOutput("pubsub_custom_endpoint");
        SetOutput("pubsub_lite_custom_endpoint");
        SetOutput("recaptcha_enterprise_custom_endpoint");
        SetOutput("redis_custom_endpoint");
        SetOutput("region");
        SetOutput("request_reason");
        SetOutput("request_timeout");
        SetOutput("resource_manager3_custom_endpoint");
        SetOutput("resource_manager_custom_endpoint");
        SetOutput("resource_manager_v3_custom_endpoint");
        SetOutput("scopes");
        SetOutput("secret_manager_custom_endpoint");
        SetOutput("secret_manager_regional_custom_endpoint");
        SetOutput("secure_source_manager_custom_endpoint");
        SetOutput("security_center_custom_endpoint");
        SetOutput("security_center_management_custom_endpoint");
        SetOutput("security_center_v2_custom_endpoint");
        SetOutput("securityposture_custom_endpoint");
        SetOutput("service_management_custom_endpoint");
        SetOutput("service_networking_custom_endpoint");
        SetOutput("service_usage_custom_endpoint");
        SetOutput("site_verification_custom_endpoint");
        SetOutput("source_repo_custom_endpoint");
        SetOutput("spanner_custom_endpoint");
        SetOutput("sql_custom_endpoint");
        SetOutput("storage_batch_operations_custom_endpoint");
        SetOutput("storage_control_custom_endpoint");
        SetOutput("storage_custom_endpoint");
        SetOutput("storage_insights_custom_endpoint");
        SetOutput("storage_transfer_custom_endpoint");
        SetOutput("tags_custom_endpoint");
        SetOutput("tags_location_custom_endpoint");
        SetOutput("terraform_attribution_label_addition_strategy");
        SetOutput("transcoder_custom_endpoint");
        SetOutput("universe_domain");
        SetOutput("user_project_override");
        SetOutput("vertex_ai_custom_endpoint");
        SetOutput("vmwareengine_custom_endpoint");
        SetOutput("vpc_access_custom_endpoint");
        SetOutput("workbench_custom_endpoint");
        SetOutput("workflows_custom_endpoint");
        SetOutput("zone");
    }

    /// <summary>
    /// The access_approval_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AccessApprovalCustomEndpoint { get; set; }

    /// <summary>
    /// The access_context_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AccessContextManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The access_token configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AccessToken { get; set; }

    /// <summary>
    /// The active_directory_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryCustomEndpoint { get; set; }

    /// <summary>
    /// The add_terraform_attribution_label configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? AddTerraformAttributionLabel { get; set; }

    /// <summary>
    /// The alloydb_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AlloydbCustomEndpoint { get; set; }

    /// <summary>
    /// The apigee_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ApigeeCustomEndpoint { get; set; }

    /// <summary>
    /// The apihub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ApihubCustomEndpoint { get; set; }

    /// <summary>
    /// The apikeys_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ApikeysCustomEndpoint { get; set; }

    /// <summary>
    /// The app_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AppEngineCustomEndpoint { get; set; }

    /// <summary>
    /// The apphub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ApphubCustomEndpoint { get; set; }

    /// <summary>
    /// The artifact_registry_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ArtifactRegistryCustomEndpoint { get; set; }

    /// <summary>
    /// The assured_workloads_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? AssuredWorkloadsCustomEndpoint { get; set; }

    /// <summary>
    /// The backup_dr_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BackupDrCustomEndpoint { get; set; }

    /// <summary>
    /// The beyondcorp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BeyondcorpCustomEndpoint { get; set; }

    /// <summary>
    /// The big_query_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigQueryCustomEndpoint { get; set; }

    /// <summary>
    /// The biglake_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BiglakeCustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryAnalyticsHubCustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_connection_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryConnectionCustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryDataTransferCustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyCustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryDatapolicyv2CustomEndpoint { get; set; }

    /// <summary>
    /// The bigquery_reservation_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigqueryReservationCustomEndpoint { get; set; }

    /// <summary>
    /// The bigtable_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BigtableCustomEndpoint { get; set; }

    /// <summary>
    /// The billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BillingCustomEndpoint { get; set; }

    /// <summary>
    /// The billing_project configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BillingProject { get; set; }

    /// <summary>
    /// The binary_authorization_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BinaryAuthorizationCustomEndpoint { get; set; }

    /// <summary>
    /// The blockchain_node_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? BlockchainNodeEngineCustomEndpoint { get; set; }

    /// <summary>
    /// The certificate_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CertificateManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The ces_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CesCustomEndpoint { get; set; }

    /// <summary>
    /// The chronicle_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ChronicleCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_asset_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudAssetCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudBillingCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_build_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudBuildCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_functions_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudFunctionsCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_identity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudIdentityCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_ids_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudIdsCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_quotas_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudQuotasCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudResourceManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_run_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudRunCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_run_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudRunV2CustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_scheduler_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudSchedulerCustomEndpoint { get; set; }

    /// <summary>
    /// The cloud_tasks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CloudTasksCustomEndpoint { get; set; }

    /// <summary>
    /// The cloudbuildv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Cloudbuildv2CustomEndpoint { get; set; }

    /// <summary>
    /// The clouddeploy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClouddeployCustomEndpoint { get; set; }

    /// <summary>
    /// The clouddomains_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClouddomainsCustomEndpoint { get; set; }

    /// <summary>
    /// The cloudfunctions2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Cloudfunctions2CustomEndpoint { get; set; }

    /// <summary>
    /// The colab_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ColabCustomEndpoint { get; set; }

    /// <summary>
    /// The composer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ComposerCustomEndpoint { get; set; }

    /// <summary>
    /// The compute_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ComputeCustomEndpoint { get; set; }

    /// <summary>
    /// The contact_center_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContactCenterInsightsCustomEndpoint { get; set; }

    /// <summary>
    /// The container_analysis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContainerAnalysisCustomEndpoint { get; set; }

    /// <summary>
    /// The container_attached_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContainerAttachedCustomEndpoint { get; set; }

    /// <summary>
    /// The container_aws_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContainerAwsCustomEndpoint { get; set; }

    /// <summary>
    /// The container_azure_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContainerAzureCustomEndpoint { get; set; }

    /// <summary>
    /// The container_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ContainerCustomEndpoint { get; set; }

    /// <summary>
    /// The core_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? CoreBillingCustomEndpoint { get; set; }

    /// <summary>
    /// The credentials configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Credentials { get; set; }

    /// <summary>
    /// The data_catalog_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataCatalogCustomEndpoint { get; set; }

    /// <summary>
    /// The data_fusion_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataFusionCustomEndpoint { get; set; }

    /// <summary>
    /// The data_loss_prevention_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataLossPreventionCustomEndpoint { get; set; }

    /// <summary>
    /// The data_pipeline_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataPipelineCustomEndpoint { get; set; }

    /// <summary>
    /// The database_migration_service_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DatabaseMigrationServiceCustomEndpoint { get; set; }

    /// <summary>
    /// The dataflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataflowCustomEndpoint { get; set; }

    /// <summary>
    /// The dataplex_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataplexCustomEndpoint { get; set; }

    /// <summary>
    /// The dataproc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataprocCustomEndpoint { get; set; }

    /// <summary>
    /// The dataproc_gdc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataprocGdcCustomEndpoint { get; set; }

    /// <summary>
    /// The dataproc_metastore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DataprocMetastoreCustomEndpoint { get; set; }

    /// <summary>
    /// The datastream_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DatastreamCustomEndpoint { get; set; }

    /// <summary>
    /// The default_labels configuration.
    /// (Optional)
    /// </summary>
    public TerraformMap<string>? DefaultLabels { get; set; }

    /// <summary>
    /// The deployment_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DeploymentManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The developer_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DeveloperConnectCustomEndpoint { get; set; }

    /// <summary>
    /// The dialogflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DialogflowCustomEndpoint { get; set; }

    /// <summary>
    /// The dialogflow_cx_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DialogflowCxCustomEndpoint { get; set; }

    /// <summary>
    /// The discovery_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DiscoveryEngineCustomEndpoint { get; set; }

    /// <summary>
    /// The dns_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DnsCustomEndpoint { get; set; }

    /// <summary>
    /// The document_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DocumentAiCustomEndpoint { get; set; }

    /// <summary>
    /// The document_ai_warehouse_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? DocumentAiWarehouseCustomEndpoint { get; set; }

    /// <summary>
    /// The edgecontainer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? EdgecontainerCustomEndpoint { get; set; }

    /// <summary>
    /// The edgenetwork_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? EdgenetworkCustomEndpoint { get; set; }

    /// <summary>
    /// The essential_contacts_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? EssentialContactsCustomEndpoint { get; set; }

    /// <summary>
    /// The eventarc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? EventarcCustomEndpoint { get; set; }

    /// <summary>
    /// The filestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FilestoreCustomEndpoint { get; set; }

    /// <summary>
    /// The firebase_app_check_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FirebaseAppCheckCustomEndpoint { get; set; }

    /// <summary>
    /// The firebase_app_hosting_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FirebaseAppHostingCustomEndpoint { get; set; }

    /// <summary>
    /// The firebase_data_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FirebaseDataConnectCustomEndpoint { get; set; }

    /// <summary>
    /// The firebaserules_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FirebaserulesCustomEndpoint { get; set; }

    /// <summary>
    /// The firestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? FirestoreCustomEndpoint { get; set; }

    /// <summary>
    /// The gemini_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? GeminiCustomEndpoint { get; set; }

    /// <summary>
    /// The gke_backup_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? GkeBackupCustomEndpoint { get; set; }

    /// <summary>
    /// The gke_hub2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? GkeHub2CustomEndpoint { get; set; }

    /// <summary>
    /// The gke_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? GkeHubCustomEndpoint { get; set; }

    /// <summary>
    /// The gkeonprem_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? GkeonpremCustomEndpoint { get; set; }

    /// <summary>
    /// The healthcare_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? HealthcareCustomEndpoint { get; set; }

    /// <summary>
    /// The iam2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Iam2CustomEndpoint { get; set; }

    /// <summary>
    /// The iam3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Iam3CustomEndpoint { get; set; }

    /// <summary>
    /// The iam_beta_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IamBetaCustomEndpoint { get; set; }

    /// <summary>
    /// The iam_credentials_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IamCredentialsCustomEndpoint { get; set; }

    /// <summary>
    /// The iam_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IamCustomEndpoint { get; set; }

    /// <summary>
    /// The iam_workforce_pool_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IamWorkforcePoolCustomEndpoint { get; set; }

    /// <summary>
    /// The iap_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IapCustomEndpoint { get; set; }

    /// <summary>
    /// The identity_platform_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IdentityPlatformCustomEndpoint { get; set; }

    /// <summary>
    /// The impersonate_service_account configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ImpersonateServiceAccount { get; set; }

    /// <summary>
    /// The impersonate_service_account_delegates configuration.
    /// (Optional)
    /// </summary>
    public TerraformList<string>? ImpersonateServiceAccountDelegates { get; set; }

    /// <summary>
    /// The integration_connectors_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IntegrationConnectorsCustomEndpoint { get; set; }

    /// <summary>
    /// The integrations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? IntegrationsCustomEndpoint { get; set; }

    /// <summary>
    /// The kms_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? KmsCustomEndpoint { get; set; }

    /// <summary>
    /// The logging_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? LoggingCustomEndpoint { get; set; }

    /// <summary>
    /// The looker_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? LookerCustomEndpoint { get; set; }

    /// <summary>
    /// The lustre_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? LustreCustomEndpoint { get; set; }

    /// <summary>
    /// The managed_kafka_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ManagedKafkaCustomEndpoint { get; set; }

    /// <summary>
    /// The memcache_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MemcacheCustomEndpoint { get; set; }

    /// <summary>
    /// The memorystore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MemorystoreCustomEndpoint { get; set; }

    /// <summary>
    /// The migration_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MigrationCenterCustomEndpoint { get; set; }

    /// <summary>
    /// The ml_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MlEngineCustomEndpoint { get; set; }

    /// <summary>
    /// The model_armor_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ModelArmorCustomEndpoint { get; set; }

    /// <summary>
    /// The model_armor_global_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ModelArmorGlobalCustomEndpoint { get; set; }

    /// <summary>
    /// The monitoring_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MonitoringCustomEndpoint { get; set; }

    /// <summary>
    /// The netapp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetappCustomEndpoint { get; set; }

    /// <summary>
    /// The network_connectivity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityCustomEndpoint { get; set; }

    /// <summary>
    /// The network_connectivityv1_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetworkConnectivityv1CustomEndpoint { get; set; }

    /// <summary>
    /// The network_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetworkManagementCustomEndpoint { get; set; }

    /// <summary>
    /// The network_security_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetworkSecurityCustomEndpoint { get; set; }

    /// <summary>
    /// The network_services_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NetworkServicesCustomEndpoint { get; set; }

    /// <summary>
    /// The notebooks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? NotebooksCustomEndpoint { get; set; }

    /// <summary>
    /// The observability_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ObservabilityCustomEndpoint { get; set; }

    /// <summary>
    /// The oracle_database_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OracleDatabaseCustomEndpoint { get; set; }

    /// <summary>
    /// The org_policy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OrgPolicyCustomEndpoint { get; set; }

    /// <summary>
    /// The os_config_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OsConfigCustomEndpoint { get; set; }

    /// <summary>
    /// The os_config_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OsConfigV2CustomEndpoint { get; set; }

    /// <summary>
    /// The os_login_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OsLoginCustomEndpoint { get; set; }

    /// <summary>
    /// The parallelstore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ParallelstoreCustomEndpoint { get; set; }

    /// <summary>
    /// The parameter_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ParameterManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The parameter_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ParameterManagerRegionalCustomEndpoint { get; set; }

    /// <summary>
    /// The privateca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PrivatecaCustomEndpoint { get; set; }

    /// <summary>
    /// The privileged_access_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PrivilegedAccessManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The project configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The public_ca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PublicCaCustomEndpoint { get; set; }

    /// <summary>
    /// The pubsub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PubsubCustomEndpoint { get; set; }

    /// <summary>
    /// The pubsub_lite_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PubsubLiteCustomEndpoint { get; set; }

    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? RecaptchaEnterpriseCustomEndpoint { get; set; }

    /// <summary>
    /// The redis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? RedisCustomEndpoint { get; set; }

    /// <summary>
    /// The region configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The request_reason configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? RequestReason { get; set; }

    /// <summary>
    /// The request_timeout configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? RequestTimeout { get; set; }

    /// <summary>
    /// The resource_manager3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ResourceManager3CustomEndpoint { get; set; }

    /// <summary>
    /// The resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ResourceManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The resource_manager_v3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ResourceManagerV3CustomEndpoint { get; set; }

    /// <summary>
    /// The scopes configuration.
    /// (Optional)
    /// </summary>
    public TerraformList<string>? Scopes { get; set; }

    /// <summary>
    /// The secret_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecretManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The secret_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecretManagerRegionalCustomEndpoint { get; set; }

    /// <summary>
    /// The secure_source_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecureSourceManagerCustomEndpoint { get; set; }

    /// <summary>
    /// The security_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecurityCenterCustomEndpoint { get; set; }

    /// <summary>
    /// The security_center_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecurityCenterManagementCustomEndpoint { get; set; }

    /// <summary>
    /// The security_center_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecurityCenterV2CustomEndpoint { get; set; }

    /// <summary>
    /// The securityposture_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SecuritypostureCustomEndpoint { get; set; }

    /// <summary>
    /// The service_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ServiceManagementCustomEndpoint { get; set; }

    /// <summary>
    /// The service_networking_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ServiceNetworkingCustomEndpoint { get; set; }

    /// <summary>
    /// The service_usage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ServiceUsageCustomEndpoint { get; set; }

    /// <summary>
    /// The site_verification_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SiteVerificationCustomEndpoint { get; set; }

    /// <summary>
    /// The source_repo_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SourceRepoCustomEndpoint { get; set; }

    /// <summary>
    /// The spanner_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SpannerCustomEndpoint { get; set; }

    /// <summary>
    /// The sql_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? SqlCustomEndpoint { get; set; }

    /// <summary>
    /// The storage_batch_operations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StorageBatchOperationsCustomEndpoint { get; set; }

    /// <summary>
    /// The storage_control_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StorageControlCustomEndpoint { get; set; }

    /// <summary>
    /// The storage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StorageCustomEndpoint { get; set; }

    /// <summary>
    /// The storage_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StorageInsightsCustomEndpoint { get; set; }

    /// <summary>
    /// The storage_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? StorageTransferCustomEndpoint { get; set; }

    /// <summary>
    /// The tags_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? TagsCustomEndpoint { get; set; }

    /// <summary>
    /// The tags_location_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? TagsLocationCustomEndpoint { get; set; }

    /// <summary>
    /// The terraform_attribution_label_addition_strategy configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? TerraformAttributionLabelAdditionStrategy { get; set; }

    /// <summary>
    /// The transcoder_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? TranscoderCustomEndpoint { get; set; }

    /// <summary>
    /// The universe_domain configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? UniverseDomain { get; set; }

    /// <summary>
    /// The user_project_override configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UserProjectOverride { get; set; }

    /// <summary>
    /// The vertex_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? VertexAiCustomEndpoint { get; set; }

    /// <summary>
    /// The vmwareengine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? VmwareengineCustomEndpoint { get; set; }

    /// <summary>
    /// The vpc_access_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? VpcAccessCustomEndpoint { get; set; }

    /// <summary>
    /// The workbench_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? WorkbenchCustomEndpoint { get; set; }

    /// <summary>
    /// The workflows_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? WorkflowsCustomEndpoint { get; set; }

    /// <summary>
    /// The zone configuration.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Zone { get; set; }
}
