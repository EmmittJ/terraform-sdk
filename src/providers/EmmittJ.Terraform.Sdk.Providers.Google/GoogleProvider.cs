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
    public TerraformProperty<string> AccessApprovalCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_approval_custom_endpoint");
        set => SetProperty("access_approval_custom_endpoint", value);
    }

    /// <summary>
    /// The access_context_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AccessContextManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_context_manager_custom_endpoint");
        set => SetProperty("access_context_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The access_token configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AccessToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_token");
        set => SetProperty("access_token", value);
    }

    /// <summary>
    /// The active_directory_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ActiveDirectoryCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("active_directory_custom_endpoint");
        set => SetProperty("active_directory_custom_endpoint", value);
    }

    /// <summary>
    /// The add_terraform_attribution_label configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> AddTerraformAttributionLabel
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("add_terraform_attribution_label");
        set => SetProperty("add_terraform_attribution_label", value);
    }

    /// <summary>
    /// The alloydb_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AlloydbCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alloydb_custom_endpoint");
        set => SetProperty("alloydb_custom_endpoint", value);
    }

    /// <summary>
    /// The apigee_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ApigeeCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apigee_custom_endpoint");
        set => SetProperty("apigee_custom_endpoint", value);
    }

    /// <summary>
    /// The apihub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ApihubCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apihub_custom_endpoint");
        set => SetProperty("apihub_custom_endpoint", value);
    }

    /// <summary>
    /// The apikeys_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ApikeysCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apikeys_custom_endpoint");
        set => SetProperty("apikeys_custom_endpoint", value);
    }

    /// <summary>
    /// The app_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AppEngineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_engine_custom_endpoint");
        set => SetProperty("app_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The apphub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ApphubCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apphub_custom_endpoint");
        set => SetProperty("apphub_custom_endpoint", value);
    }

    /// <summary>
    /// The artifact_registry_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ArtifactRegistryCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("artifact_registry_custom_endpoint");
        set => SetProperty("artifact_registry_custom_endpoint", value);
    }

    /// <summary>
    /// The assured_workloads_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AssuredWorkloadsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assured_workloads_custom_endpoint");
        set => SetProperty("assured_workloads_custom_endpoint", value);
    }

    /// <summary>
    /// The backup_dr_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BackupDrCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_dr_custom_endpoint");
        set => SetProperty("backup_dr_custom_endpoint", value);
    }

    /// <summary>
    /// The beyondcorp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BeyondcorpCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("beyondcorp_custom_endpoint");
        set => SetProperty("beyondcorp_custom_endpoint", value);
    }

    /// <summary>
    /// The big_query_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigQueryCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("big_query_custom_endpoint");
        set => SetProperty("big_query_custom_endpoint", value);
    }

    /// <summary>
    /// The biglake_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BiglakeCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("biglake_custom_endpoint");
        set => SetProperty("biglake_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_analytics_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryAnalyticsHubCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_analytics_hub_custom_endpoint");
        set => SetProperty("bigquery_analytics_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_connection_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryConnectionCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_connection_custom_endpoint");
        set => SetProperty("bigquery_connection_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_data_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryDataTransferCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_data_transfer_custom_endpoint");
        set => SetProperty("bigquery_data_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryDatapolicyCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_datapolicy_custom_endpoint");
        set => SetProperty("bigquery_datapolicy_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_datapolicyv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryDatapolicyv2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_datapolicyv2_custom_endpoint");
        set => SetProperty("bigquery_datapolicyv2_custom_endpoint", value);
    }

    /// <summary>
    /// The bigquery_reservation_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigqueryReservationCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigquery_reservation_custom_endpoint");
        set => SetProperty("bigquery_reservation_custom_endpoint", value);
    }

    /// <summary>
    /// The bigtable_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BigtableCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bigtable_custom_endpoint");
        set => SetProperty("bigtable_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BillingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_custom_endpoint");
        set => SetProperty("billing_custom_endpoint", value);
    }

    /// <summary>
    /// The billing_project configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BillingProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_project");
        set => SetProperty("billing_project", value);
    }

    /// <summary>
    /// The binary_authorization_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BinaryAuthorizationCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("binary_authorization_custom_endpoint");
        set => SetProperty("binary_authorization_custom_endpoint", value);
    }

    /// <summary>
    /// The blockchain_node_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> BlockchainNodeEngineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blockchain_node_engine_custom_endpoint");
        set => SetProperty("blockchain_node_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The certificate_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CertificateManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_manager_custom_endpoint");
        set => SetProperty("certificate_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The ces_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CesCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ces_custom_endpoint");
        set => SetProperty("ces_custom_endpoint", value);
    }

    /// <summary>
    /// The chronicle_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ChronicleCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("chronicle_custom_endpoint");
        set => SetProperty("chronicle_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_asset_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudAssetCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_asset_custom_endpoint");
        set => SetProperty("cloud_asset_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudBillingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_billing_custom_endpoint");
        set => SetProperty("cloud_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_build_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudBuildCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_build_custom_endpoint");
        set => SetProperty("cloud_build_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_functions_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudFunctionsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_functions_custom_endpoint");
        set => SetProperty("cloud_functions_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_identity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudIdentityCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_identity_custom_endpoint");
        set => SetProperty("cloud_identity_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_ids_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudIdsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_ids_custom_endpoint");
        set => SetProperty("cloud_ids_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_quotas_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudQuotasCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_quotas_custom_endpoint");
        set => SetProperty("cloud_quotas_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudResourceManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_resource_manager_custom_endpoint");
        set => SetProperty("cloud_resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudRunCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_run_custom_endpoint");
        set => SetProperty("cloud_run_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_run_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudRunV2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_run_v2_custom_endpoint");
        set => SetProperty("cloud_run_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_scheduler_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudSchedulerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_scheduler_custom_endpoint");
        set => SetProperty("cloud_scheduler_custom_endpoint", value);
    }

    /// <summary>
    /// The cloud_tasks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CloudTasksCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_tasks_custom_endpoint");
        set => SetProperty("cloud_tasks_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudbuildv2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Cloudbuildv2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudbuildv2_custom_endpoint");
        set => SetProperty("cloudbuildv2_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddeploy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClouddeployCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("clouddeploy_custom_endpoint");
        set => SetProperty("clouddeploy_custom_endpoint", value);
    }

    /// <summary>
    /// The clouddomains_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClouddomainsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("clouddomains_custom_endpoint");
        set => SetProperty("clouddomains_custom_endpoint", value);
    }

    /// <summary>
    /// The cloudfunctions2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Cloudfunctions2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudfunctions2_custom_endpoint");
        set => SetProperty("cloudfunctions2_custom_endpoint", value);
    }

    /// <summary>
    /// The colab_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ColabCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("colab_custom_endpoint");
        set => SetProperty("colab_custom_endpoint", value);
    }

    /// <summary>
    /// The composer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ComposerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("composer_custom_endpoint");
        set => SetProperty("composer_custom_endpoint", value);
    }

    /// <summary>
    /// The compute_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ComputeCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_custom_endpoint");
        set => SetProperty("compute_custom_endpoint", value);
    }

    /// <summary>
    /// The contact_center_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContactCenterInsightsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("contact_center_insights_custom_endpoint");
        set => SetProperty("contact_center_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The container_analysis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContainerAnalysisCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_analysis_custom_endpoint");
        set => SetProperty("container_analysis_custom_endpoint", value);
    }

    /// <summary>
    /// The container_attached_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContainerAttachedCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_attached_custom_endpoint");
        set => SetProperty("container_attached_custom_endpoint", value);
    }

    /// <summary>
    /// The container_aws_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContainerAwsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_aws_custom_endpoint");
        set => SetProperty("container_aws_custom_endpoint", value);
    }

    /// <summary>
    /// The container_azure_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContainerAzureCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_azure_custom_endpoint");
        set => SetProperty("container_azure_custom_endpoint", value);
    }

    /// <summary>
    /// The container_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ContainerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_custom_endpoint");
        set => SetProperty("container_custom_endpoint", value);
    }

    /// <summary>
    /// The core_billing_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> CoreBillingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("core_billing_custom_endpoint");
        set => SetProperty("core_billing_custom_endpoint", value);
    }

    /// <summary>
    /// The credentials configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Credentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credentials");
        set => SetProperty("credentials", value);
    }

    /// <summary>
    /// The data_catalog_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataCatalogCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_catalog_custom_endpoint");
        set => SetProperty("data_catalog_custom_endpoint", value);
    }

    /// <summary>
    /// The data_fusion_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataFusionCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_fusion_custom_endpoint");
        set => SetProperty("data_fusion_custom_endpoint", value);
    }

    /// <summary>
    /// The data_loss_prevention_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataLossPreventionCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_loss_prevention_custom_endpoint");
        set => SetProperty("data_loss_prevention_custom_endpoint", value);
    }

    /// <summary>
    /// The data_pipeline_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataPipelineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_pipeline_custom_endpoint");
        set => SetProperty("data_pipeline_custom_endpoint", value);
    }

    /// <summary>
    /// The database_migration_service_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DatabaseMigrationServiceCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_migration_service_custom_endpoint");
        set => SetProperty("database_migration_service_custom_endpoint", value);
    }

    /// <summary>
    /// The dataflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataflowCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataflow_custom_endpoint");
        set => SetProperty("dataflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dataplex_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataplexCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataplex_custom_endpoint");
        set => SetProperty("dataplex_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataprocCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataproc_custom_endpoint");
        set => SetProperty("dataproc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_gdc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataprocGdcCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataproc_gdc_custom_endpoint");
        set => SetProperty("dataproc_gdc_custom_endpoint", value);
    }

    /// <summary>
    /// The dataproc_metastore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DataprocMetastoreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataproc_metastore_custom_endpoint");
        set => SetProperty("dataproc_metastore_custom_endpoint", value);
    }

    /// <summary>
    /// The datastream_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DatastreamCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("datastream_custom_endpoint");
        set => SetProperty("datastream_custom_endpoint", value);
    }

    /// <summary>
    /// The default_labels configuration.
    /// (Optional)
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> DefaultLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("default_labels");
        set => SetProperty("default_labels", value);
    }

    /// <summary>
    /// The deployment_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DeploymentManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_manager_custom_endpoint");
        set => SetProperty("deployment_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The developer_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DeveloperConnectCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("developer_connect_custom_endpoint");
        set => SetProperty("developer_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DialogflowCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dialogflow_custom_endpoint");
        set => SetProperty("dialogflow_custom_endpoint", value);
    }

    /// <summary>
    /// The dialogflow_cx_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DialogflowCxCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dialogflow_cx_custom_endpoint");
        set => SetProperty("dialogflow_cx_custom_endpoint", value);
    }

    /// <summary>
    /// The discovery_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DiscoveryEngineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("discovery_engine_custom_endpoint");
        set => SetProperty("discovery_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The dns_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DnsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_custom_endpoint");
        set => SetProperty("dns_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DocumentAiCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_ai_custom_endpoint");
        set => SetProperty("document_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The document_ai_warehouse_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> DocumentAiWarehouseCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_ai_warehouse_custom_endpoint");
        set => SetProperty("document_ai_warehouse_custom_endpoint", value);
    }

    /// <summary>
    /// The edgecontainer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> EdgecontainerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edgecontainer_custom_endpoint");
        set => SetProperty("edgecontainer_custom_endpoint", value);
    }

    /// <summary>
    /// The edgenetwork_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> EdgenetworkCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edgenetwork_custom_endpoint");
        set => SetProperty("edgenetwork_custom_endpoint", value);
    }

    /// <summary>
    /// The essential_contacts_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> EssentialContactsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("essential_contacts_custom_endpoint");
        set => SetProperty("essential_contacts_custom_endpoint", value);
    }

    /// <summary>
    /// The eventarc_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> EventarcCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventarc_custom_endpoint");
        set => SetProperty("eventarc_custom_endpoint", value);
    }

    /// <summary>
    /// The filestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FilestoreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filestore_custom_endpoint");
        set => SetProperty("filestore_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_check_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FirebaseAppCheckCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firebase_app_check_custom_endpoint");
        set => SetProperty("firebase_app_check_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_app_hosting_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FirebaseAppHostingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firebase_app_hosting_custom_endpoint");
        set => SetProperty("firebase_app_hosting_custom_endpoint", value);
    }

    /// <summary>
    /// The firebase_data_connect_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FirebaseDataConnectCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firebase_data_connect_custom_endpoint");
        set => SetProperty("firebase_data_connect_custom_endpoint", value);
    }

    /// <summary>
    /// The firebaserules_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FirebaserulesCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firebaserules_custom_endpoint");
        set => SetProperty("firebaserules_custom_endpoint", value);
    }

    /// <summary>
    /// The firestore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> FirestoreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firestore_custom_endpoint");
        set => SetProperty("firestore_custom_endpoint", value);
    }

    /// <summary>
    /// The gemini_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> GeminiCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gemini_custom_endpoint");
        set => SetProperty("gemini_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_backup_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> GkeBackupCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gke_backup_custom_endpoint");
        set => SetProperty("gke_backup_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> GkeHub2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gke_hub2_custom_endpoint");
        set => SetProperty("gke_hub2_custom_endpoint", value);
    }

    /// <summary>
    /// The gke_hub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> GkeHubCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gke_hub_custom_endpoint");
        set => SetProperty("gke_hub_custom_endpoint", value);
    }

    /// <summary>
    /// The gkeonprem_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> GkeonpremCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gkeonprem_custom_endpoint");
        set => SetProperty("gkeonprem_custom_endpoint", value);
    }

    /// <summary>
    /// The healthcare_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> HealthcareCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("healthcare_custom_endpoint");
        set => SetProperty("healthcare_custom_endpoint", value);
    }

    /// <summary>
    /// The iam2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Iam2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam2_custom_endpoint");
        set => SetProperty("iam2_custom_endpoint", value);
    }

    /// <summary>
    /// The iam3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Iam3CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam3_custom_endpoint");
        set => SetProperty("iam3_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_beta_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IamBetaCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_beta_custom_endpoint");
        set => SetProperty("iam_beta_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_credentials_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IamCredentialsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_credentials_custom_endpoint");
        set => SetProperty("iam_credentials_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IamCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_custom_endpoint");
        set => SetProperty("iam_custom_endpoint", value);
    }

    /// <summary>
    /// The iam_workforce_pool_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IamWorkforcePoolCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_workforce_pool_custom_endpoint");
        set => SetProperty("iam_workforce_pool_custom_endpoint", value);
    }

    /// <summary>
    /// The iap_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IapCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iap_custom_endpoint");
        set => SetProperty("iap_custom_endpoint", value);
    }

    /// <summary>
    /// The identity_platform_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IdentityPlatformCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_platform_custom_endpoint");
        set => SetProperty("identity_platform_custom_endpoint", value);
    }

    /// <summary>
    /// The impersonate_service_account configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ImpersonateServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("impersonate_service_account");
        set => SetProperty("impersonate_service_account", value);
    }

    /// <summary>
    /// The impersonate_service_account_delegates configuration.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>> ImpersonateServiceAccountDelegates
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("impersonate_service_account_delegates");
        set => SetProperty("impersonate_service_account_delegates", value);
    }

    /// <summary>
    /// The integration_connectors_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IntegrationConnectorsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_connectors_custom_endpoint");
        set => SetProperty("integration_connectors_custom_endpoint", value);
    }

    /// <summary>
    /// The integrations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> IntegrationsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integrations_custom_endpoint");
        set => SetProperty("integrations_custom_endpoint", value);
    }

    /// <summary>
    /// The kms_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> KmsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_custom_endpoint");
        set => SetProperty("kms_custom_endpoint", value);
    }

    /// <summary>
    /// The logging_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> LoggingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logging_custom_endpoint");
        set => SetProperty("logging_custom_endpoint", value);
    }

    /// <summary>
    /// The looker_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> LookerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("looker_custom_endpoint");
        set => SetProperty("looker_custom_endpoint", value);
    }

    /// <summary>
    /// The lustre_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> LustreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lustre_custom_endpoint");
        set => SetProperty("lustre_custom_endpoint", value);
    }

    /// <summary>
    /// The managed_kafka_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ManagedKafkaCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_kafka_custom_endpoint");
        set => SetProperty("managed_kafka_custom_endpoint", value);
    }

    /// <summary>
    /// The memcache_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MemcacheCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("memcache_custom_endpoint");
        set => SetProperty("memcache_custom_endpoint", value);
    }

    /// <summary>
    /// The memorystore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MemorystoreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("memorystore_custom_endpoint");
        set => SetProperty("memorystore_custom_endpoint", value);
    }

    /// <summary>
    /// The migration_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MigrationCenterCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("migration_center_custom_endpoint");
        set => SetProperty("migration_center_custom_endpoint", value);
    }

    /// <summary>
    /// The ml_engine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MlEngineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ml_engine_custom_endpoint");
        set => SetProperty("ml_engine_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ModelArmorCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_armor_custom_endpoint");
        set => SetProperty("model_armor_custom_endpoint", value);
    }

    /// <summary>
    /// The model_armor_global_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ModelArmorGlobalCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_armor_global_custom_endpoint");
        set => SetProperty("model_armor_global_custom_endpoint", value);
    }

    /// <summary>
    /// The monitoring_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MonitoringCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitoring_custom_endpoint");
        set => SetProperty("monitoring_custom_endpoint", value);
    }

    /// <summary>
    /// The netapp_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetappCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("netapp_custom_endpoint");
        set => SetProperty("netapp_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivity_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetworkConnectivityCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_connectivity_custom_endpoint");
        set => SetProperty("network_connectivity_custom_endpoint", value);
    }

    /// <summary>
    /// The network_connectivityv1_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetworkConnectivityv1CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_connectivityv1_custom_endpoint");
        set => SetProperty("network_connectivityv1_custom_endpoint", value);
    }

    /// <summary>
    /// The network_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetworkManagementCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_management_custom_endpoint");
        set => SetProperty("network_management_custom_endpoint", value);
    }

    /// <summary>
    /// The network_security_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetworkSecurityCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_security_custom_endpoint");
        set => SetProperty("network_security_custom_endpoint", value);
    }

    /// <summary>
    /// The network_services_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NetworkServicesCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_services_custom_endpoint");
        set => SetProperty("network_services_custom_endpoint", value);
    }

    /// <summary>
    /// The notebooks_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> NotebooksCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notebooks_custom_endpoint");
        set => SetProperty("notebooks_custom_endpoint", value);
    }

    /// <summary>
    /// The observability_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ObservabilityCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("observability_custom_endpoint");
        set => SetProperty("observability_custom_endpoint", value);
    }

    /// <summary>
    /// The oracle_database_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OracleDatabaseCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oracle_database_custom_endpoint");
        set => SetProperty("oracle_database_custom_endpoint", value);
    }

    /// <summary>
    /// The org_policy_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OrgPolicyCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_policy_custom_endpoint");
        set => SetProperty("org_policy_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OsConfigCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_config_custom_endpoint");
        set => SetProperty("os_config_custom_endpoint", value);
    }

    /// <summary>
    /// The os_config_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OsConfigV2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_config_v2_custom_endpoint");
        set => SetProperty("os_config_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The os_login_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OsLoginCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_login_custom_endpoint");
        set => SetProperty("os_login_custom_endpoint", value);
    }

    /// <summary>
    /// The parallelstore_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ParallelstoreCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parallelstore_custom_endpoint");
        set => SetProperty("parallelstore_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ParameterManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_manager_custom_endpoint");
        set => SetProperty("parameter_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The parameter_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ParameterManagerRegionalCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_manager_regional_custom_endpoint");
        set => SetProperty("parameter_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The privateca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PrivatecaCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privateca_custom_endpoint");
        set => SetProperty("privateca_custom_endpoint", value);
    }

    /// <summary>
    /// The privileged_access_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PrivilegedAccessManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privileged_access_manager_custom_endpoint");
        set => SetProperty("privileged_access_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The project configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The public_ca_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PublicCaCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ca_custom_endpoint");
        set => SetProperty("public_ca_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PubsubCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pubsub_custom_endpoint");
        set => SetProperty("pubsub_custom_endpoint", value);
    }

    /// <summary>
    /// The pubsub_lite_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PubsubLiteCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pubsub_lite_custom_endpoint");
        set => SetProperty("pubsub_lite_custom_endpoint", value);
    }

    /// <summary>
    /// The recaptcha_enterprise_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> RecaptchaEnterpriseCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recaptcha_enterprise_custom_endpoint");
        set => SetProperty("recaptcha_enterprise_custom_endpoint", value);
    }

    /// <summary>
    /// The redis_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> RedisCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_custom_endpoint");
        set => SetProperty("redis_custom_endpoint", value);
    }

    /// <summary>
    /// The region configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The request_reason configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> RequestReason
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_reason");
        set => SetProperty("request_reason", value);
    }

    /// <summary>
    /// The request_timeout configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> RequestTimeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_timeout");
        set => SetProperty("request_timeout", value);
    }

    /// <summary>
    /// The resource_manager3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ResourceManager3CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_manager3_custom_endpoint");
        set => SetProperty("resource_manager3_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ResourceManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_manager_custom_endpoint");
        set => SetProperty("resource_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The resource_manager_v3_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ResourceManagerV3CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_manager_v3_custom_endpoint");
        set => SetProperty("resource_manager_v3_custom_endpoint", value);
    }

    /// <summary>
    /// The scopes configuration.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The secret_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecretManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_manager_custom_endpoint");
        set => SetProperty("secret_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The secret_manager_regional_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecretManagerRegionalCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_manager_regional_custom_endpoint");
        set => SetProperty("secret_manager_regional_custom_endpoint", value);
    }

    /// <summary>
    /// The secure_source_manager_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecureSourceManagerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secure_source_manager_custom_endpoint");
        set => SetProperty("secure_source_manager_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecurityCenterCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_center_custom_endpoint");
        set => SetProperty("security_center_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecurityCenterManagementCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_center_management_custom_endpoint");
        set => SetProperty("security_center_management_custom_endpoint", value);
    }

    /// <summary>
    /// The security_center_v2_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecurityCenterV2CustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_center_v2_custom_endpoint");
        set => SetProperty("security_center_v2_custom_endpoint", value);
    }

    /// <summary>
    /// The securityposture_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SecuritypostureCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("securityposture_custom_endpoint");
        set => SetProperty("securityposture_custom_endpoint", value);
    }

    /// <summary>
    /// The service_management_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ServiceManagementCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_management_custom_endpoint");
        set => SetProperty("service_management_custom_endpoint", value);
    }

    /// <summary>
    /// The service_networking_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ServiceNetworkingCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_networking_custom_endpoint");
        set => SetProperty("service_networking_custom_endpoint", value);
    }

    /// <summary>
    /// The service_usage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ServiceUsageCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_usage_custom_endpoint");
        set => SetProperty("service_usage_custom_endpoint", value);
    }

    /// <summary>
    /// The site_verification_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SiteVerificationCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("site_verification_custom_endpoint");
        set => SetProperty("site_verification_custom_endpoint", value);
    }

    /// <summary>
    /// The source_repo_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SourceRepoCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_repo_custom_endpoint");
        set => SetProperty("source_repo_custom_endpoint", value);
    }

    /// <summary>
    /// The spanner_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SpannerCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spanner_custom_endpoint");
        set => SetProperty("spanner_custom_endpoint", value);
    }

    /// <summary>
    /// The sql_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SqlCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_custom_endpoint");
        set => SetProperty("sql_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_batch_operations_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> StorageBatchOperationsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_batch_operations_custom_endpoint");
        set => SetProperty("storage_batch_operations_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_control_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> StorageControlCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_control_custom_endpoint");
        set => SetProperty("storage_control_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> StorageCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_custom_endpoint");
        set => SetProperty("storage_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_insights_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> StorageInsightsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_insights_custom_endpoint");
        set => SetProperty("storage_insights_custom_endpoint", value);
    }

    /// <summary>
    /// The storage_transfer_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> StorageTransferCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_transfer_custom_endpoint");
        set => SetProperty("storage_transfer_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> TagsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tags_custom_endpoint");
        set => SetProperty("tags_custom_endpoint", value);
    }

    /// <summary>
    /// The tags_location_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> TagsLocationCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tags_location_custom_endpoint");
        set => SetProperty("tags_location_custom_endpoint", value);
    }

    /// <summary>
    /// The terraform_attribution_label_addition_strategy configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> TerraformAttributionLabelAdditionStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terraform_attribution_label_addition_strategy");
        set => SetProperty("terraform_attribution_label_addition_strategy", value);
    }

    /// <summary>
    /// The transcoder_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> TranscoderCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transcoder_custom_endpoint");
        set => SetProperty("transcoder_custom_endpoint", value);
    }

    /// <summary>
    /// The universe_domain configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> UniverseDomain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("universe_domain");
        set => SetProperty("universe_domain", value);
    }

    /// <summary>
    /// The user_project_override configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UserProjectOverride
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("user_project_override");
        set => SetProperty("user_project_override", value);
    }

    /// <summary>
    /// The vertex_ai_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> VertexAiCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vertex_ai_custom_endpoint");
        set => SetProperty("vertex_ai_custom_endpoint", value);
    }

    /// <summary>
    /// The vmwareengine_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> VmwareengineCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vmwareengine_custom_endpoint");
        set => SetProperty("vmwareengine_custom_endpoint", value);
    }

    /// <summary>
    /// The vpc_access_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> VpcAccessCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_access_custom_endpoint");
        set => SetProperty("vpc_access_custom_endpoint", value);
    }

    /// <summary>
    /// The workbench_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> WorkbenchCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workbench_custom_endpoint");
        set => SetProperty("workbench_custom_endpoint", value);
    }

    /// <summary>
    /// The workflows_custom_endpoint configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> WorkflowsCustomEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workflows_custom_endpoint");
        set => SetProperty("workflows_custom_endpoint", value);
    }

    /// <summary>
    /// The zone configuration.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }
}
