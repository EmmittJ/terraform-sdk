using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for catalog_info in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministratorPassword { get; set; }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    [TerraformPropertyName("dual_standby_pair_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DualStandbyPairName { get; set; }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("elastic_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ElasticPoolName { get; set; }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformPropertyName("pricing_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PricingTier { get; set; }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    [TerraformPropertyName("server_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerEndpoint { get; set; }

}

/// <summary>
/// Block type for copy_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock : ITerraformBlock
{
    /// <summary>
    /// The data_integration_unit attribute.
    /// </summary>
    [TerraformPropertyName("data_integration_unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DataIntegrationUnit { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformPropertyName("time_to_live")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for custom_setup_script in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock : ITerraformBlock
{
    /// <summary>
    /// The blob_container_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobContainerUri is required")]
    [TerraformPropertyName("blob_container_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BlobContainerUri { get; set; }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    [TerraformPropertyName("sas_token")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SasToken { get; set; }

}

/// <summary>
/// Block type for express_custom_setup in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock : ITerraformBlock
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Environment { get; set; }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    [TerraformPropertyName("powershell_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PowershellVersion { get; set; }

}

/// <summary>
/// Block type for express_vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock : ITerraformBlock
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for package_store in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock : ITerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformPropertyName("linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkedServiceName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for pipeline_external_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock : ITerraformBlock
{
    /// <summary>
    /// The number_of_external_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_external_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfExternalNodes { get; set; }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_pipeline_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfPipelineNodes { get; set; }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformPropertyName("time_to_live")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeToLive { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock : ITerraformBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    [TerraformPropertyName("self_hosted_integration_runtime_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SelfHostedIntegrationRuntimeName { get; set; }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    [TerraformPropertyName("staging_storage_linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StagingStorageLinkedServiceName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock : ITerraformBlock
{
    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformPropertyName("public_ips")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PublicIps { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetName { get; set; }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    [TerraformPropertyName("vnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VnetId { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_azure_ssis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryIntegrationRuntimeAzureSsis : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzureSsis(string name) : base("azurerm_data_factory_integration_runtime_azure_ssis", name)
    {
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    [TerraformPropertyName("credential_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CredentialName { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Edition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    [TerraformPropertyName("max_parallel_executions_per_node")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxParallelExecutionsPerNode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformPropertyName("node_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeSize { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfNodes { get; set; }

    /// <summary>
    /// Block for catalog_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    [TerraformPropertyName("catalog_info")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>>? CatalogInfo { get; set; } = new();

    /// <summary>
    /// Block for copy_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    [TerraformPropertyName("copy_compute_scale")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>>? CopyComputeScale { get; set; } = new();

    /// <summary>
    /// Block for custom_setup_script.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    [TerraformPropertyName("custom_setup_script")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>>? CustomSetupScript { get; set; } = new();

    /// <summary>
    /// Block for express_custom_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    [TerraformPropertyName("express_custom_setup")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>>? ExpressCustomSetup { get; set; } = new();

    /// <summary>
    /// Block for express_vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    [TerraformPropertyName("express_vnet_integration")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>>? ExpressVnetIntegration { get; set; } = new();

    /// <summary>
    /// Block for package_store.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("package_store")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>>? PackageStore { get; set; } = new();

    /// <summary>
    /// Block for pipeline_external_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    [TerraformPropertyName("pipeline_external_compute_scale")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>>? PipelineExternalComputeScale { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformPropertyName("proxy")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>>? Proxy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    [TerraformPropertyName("vnet_integration")]
    public TerraformList<TerraformBlock<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>>? VnetIntegration { get; set; } = new();

}
