using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for catalog_info in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock : TerraformBlock
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password");
        set => WithProperty("administrator_password", value);
    }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    public TerraformProperty<string>? DualStandbyPairName
    {
        get => GetProperty<TerraformProperty<string>>("dual_standby_pair_name");
        set => WithProperty("dual_standby_pair_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticPoolName
    {
        get => GetProperty<TerraformProperty<string>>("elastic_pool_name");
        set => WithProperty("elastic_pool_name", value);
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformProperty<string>? PricingTier
    {
        get => GetProperty<TerraformProperty<string>>("pricing_tier");
        set => WithProperty("pricing_tier", value);
    }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    public required TerraformProperty<string> ServerEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_endpoint");
        set => WithProperty("server_endpoint", value);
    }

}

/// <summary>
/// Block type for copy_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock : TerraformBlock
{
    /// <summary>
    /// The data_integration_unit attribute.
    /// </summary>
    public TerraformProperty<double>? DataIntegrationUnit
    {
        get => GetProperty<TerraformProperty<double>>("data_integration_unit");
        set => WithProperty("data_integration_unit", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<double>? TimeToLive
    {
        get => GetProperty<TerraformProperty<double>>("time_to_live");
        set => WithProperty("time_to_live", value);
    }

}

/// <summary>
/// Block type for custom_setup_script in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock : TerraformBlock
{
    /// <summary>
    /// The blob_container_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobContainerUri is required")]
    public required TerraformProperty<string> BlobContainerUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("blob_container_uri");
        set => WithProperty("blob_container_uri", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    public required TerraformProperty<string> SasToken
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sas_token");
        set => WithProperty("sas_token", value);
    }

}

/// <summary>
/// Block type for express_custom_setup in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock : TerraformBlock
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment");
        set => WithProperty("environment", value);
    }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    public TerraformProperty<string>? PowershellVersion
    {
        get => GetProperty<TerraformProperty<string>>("powershell_version");
        set => WithProperty("powershell_version", value);
    }

}

/// <summary>
/// Block type for express_vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for package_store in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for pipeline_external_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock : TerraformBlock
{
    /// <summary>
    /// The number_of_external_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfExternalNodes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_external_nodes");
        set => WithProperty("number_of_external_nodes", value);
    }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfPipelineNodes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_pipeline_nodes");
        set => WithProperty("number_of_pipeline_nodes", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<double>? TimeToLive
    {
        get => GetProperty<TerraformProperty<double>>("time_to_live");
        set => WithProperty("time_to_live", value);
    }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock : TerraformBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    public required TerraformProperty<string> SelfHostedIntegrationRuntimeName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("self_hosted_integration_runtime_name");
        set => WithProperty("self_hosted_integration_runtime_name", value);
    }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    public required TerraformProperty<string> StagingStorageLinkedServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("staging_storage_linked_service_name");
        set => WithProperty("staging_storage_linked_service_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIps
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ips");
        set => WithProperty("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetName
    {
        get => GetProperty<TerraformProperty<string>>("subnet_name");
        set => WithProperty("subnet_name", value);
    }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetId
    {
        get => GetProperty<TerraformProperty<string>>("vnet_id");
        set => WithProperty("vnet_id", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_integration_runtime_azure_ssis resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryIntegrationRuntimeAzureSsis : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeAzureSsis(string name) : base("azurerm_data_factory_integration_runtime_azure_ssis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    public TerraformProperty<string>? CredentialName
    {
        get => GetProperty<TerraformProperty<string>>("credential_name");
        set => this.WithProperty("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public TerraformProperty<double>? MaxParallelExecutionsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_parallel_executions_per_node");
        set => this.WithProperty("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformProperty<string> NodeSize
    {
        get => GetRequiredProperty<TerraformProperty<string>>("node_size");
        set => this.WithProperty("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfNodes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_nodes");
        set => this.WithProperty("number_of_nodes", value);
    }

    /// <summary>
    /// Block for catalog_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>? CatalogInfo
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>>("catalog_info");
        set => this.WithProperty("catalog_info", value);
    }

    /// <summary>
    /// Block for copy_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>? CopyComputeScale
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>>("copy_compute_scale");
        set => this.WithProperty("copy_compute_scale", value);
    }

    /// <summary>
    /// Block for custom_setup_script.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>? CustomSetupScript
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>>("custom_setup_script");
        set => this.WithProperty("custom_setup_script", value);
    }

    /// <summary>
    /// Block for express_custom_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>? ExpressCustomSetup
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>>("express_custom_setup");
        set => this.WithProperty("express_custom_setup", value);
    }

    /// <summary>
    /// Block for express_vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>? ExpressVnetIntegration
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>>("express_vnet_integration");
        set => this.WithProperty("express_vnet_integration", value);
    }

    /// <summary>
    /// Block for package_store.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>? PackageStore
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>>("package_store");
        set => this.WithProperty("package_store", value);
    }

    /// <summary>
    /// Block for pipeline_external_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>? PipelineExternalComputeScale
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>>("pipeline_external_compute_scale");
        set => this.WithProperty("pipeline_external_compute_scale", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>? Proxy
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>>("proxy");
        set => this.WithProperty("proxy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>? VnetIntegration
    {
        get => GetProperty<List<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>>("vnet_integration");
        set => this.WithProperty("vnet_integration", value);
    }

}
