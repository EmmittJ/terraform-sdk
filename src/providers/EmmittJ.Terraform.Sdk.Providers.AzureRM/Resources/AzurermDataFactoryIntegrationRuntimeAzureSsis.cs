using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for catalog_info in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock() : TerraformBlock("catalog_info")
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformProperty("administrator_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorPassword { get; set; }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    [TerraformProperty("dual_standby_pair_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DualStandbyPairName { get; set; }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformProperty("elastic_pool_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ElasticPoolName { get; set; }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformProperty("pricing_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PricingTier { get; set; }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    [TerraformProperty("server_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerEndpoint { get; set; }

}

/// <summary>
/// Block type for copy_compute_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock() : TerraformBlock("copy_compute_scale")
{
    /// <summary>
    /// The data_integration_unit attribute.
    /// </summary>
    [TerraformProperty("data_integration_unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DataIntegrationUnit { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformProperty("time_to_live")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for custom_setup_script in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock() : TerraformBlock("custom_setup_script")
{
    /// <summary>
    /// The blob_container_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobContainerUri is required")]
    [TerraformProperty("blob_container_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BlobContainerUri { get; set; }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    [TerraformProperty("sas_token")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SasToken { get; set; }

}

/// <summary>
/// Block type for express_custom_setup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock() : TerraformBlock("express_custom_setup")
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    [TerraformProperty("powershell_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PowershellVersion { get; set; }

}

/// <summary>
/// Block type for express_vnet_integration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock() : TerraformBlock("express_vnet_integration")
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for package_store in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock() : TerraformBlock("package_store")
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for pipeline_external_compute_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock() : TerraformBlock("pipeline_external_compute_scale")
{
    /// <summary>
    /// The number_of_external_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_external_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfExternalNodes { get; set; }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_pipeline_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfPipelineNodes { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformProperty("time_to_live")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock() : TerraformBlock("proxy")
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    [TerraformProperty("self_hosted_integration_runtime_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    [TerraformProperty("staging_storage_linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StagingStorageLinkedServiceName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vnet_integration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock() : TerraformBlock("vnet_integration")
{
    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformProperty("public_ips")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PublicIps { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [TerraformProperty("subnet_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetName { get; set; }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    [TerraformProperty("vnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VnetId { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_azure_ssis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsis : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzureSsis(string name) : base("azurerm_data_factory_integration_runtime_azure_ssis", name)
    {
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    [TerraformProperty("credential_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CredentialName { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformProperty("edition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Edition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    [TerraformProperty("max_parallel_executions_per_node")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformProperty("node_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeSize { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfNodes { get; set; }

    /// <summary>
    /// Block for catalog_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    [TerraformProperty("catalog_info")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock> CatalogInfo { get; set; } = new();

    /// <summary>
    /// Block for copy_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    [TerraformProperty("copy_compute_scale")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock> CopyComputeScale { get; set; } = new();

    /// <summary>
    /// Block for custom_setup_script.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    [TerraformProperty("custom_setup_script")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock> CustomSetupScript { get; set; } = new();

    /// <summary>
    /// Block for express_custom_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    [TerraformProperty("express_custom_setup")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock> ExpressCustomSetup { get; set; } = new();

    /// <summary>
    /// Block for express_vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    [TerraformProperty("express_vnet_integration")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock> ExpressVnetIntegration { get; set; } = new();

    /// <summary>
    /// Block for package_store.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("package_store")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock> PackageStore { get; set; } = new();

    /// <summary>
    /// Block for pipeline_external_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    [TerraformProperty("pipeline_external_compute_scale")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock> PipelineExternalComputeScale { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformProperty("proxy")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock> Proxy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    [TerraformProperty("vnet_integration")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock> VnetIntegration { get; set; } = new();

}
