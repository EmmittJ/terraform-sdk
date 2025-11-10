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
        set => SetProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorPassword
    {
        set => SetProperty("administrator_password", value);
    }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    public TerraformProperty<string>? DualStandbyPairName
    {
        set => SetProperty("dual_standby_pair_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticPoolName
    {
        set => SetProperty("elastic_pool_name", value);
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformProperty<string>? PricingTier
    {
        set => SetProperty("pricing_tier", value);
    }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    public required TerraformProperty<string> ServerEndpoint
    {
        set => SetProperty("server_endpoint", value);
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
        set => SetProperty("data_integration_unit", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<double>? TimeToLive
    {
        set => SetProperty("time_to_live", value);
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
        set => SetProperty("blob_container_uri", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    public required TerraformProperty<string> SasToken
    {
        set => SetProperty("sas_token", value);
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
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    public TerraformProperty<string>? PowershellVersion
    {
        set => SetProperty("powershell_version", value);
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
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("number_of_external_nodes", value);
    }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfPipelineNodes
    {
        set => SetProperty("number_of_pipeline_nodes", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformProperty<double>? TimeToLive
    {
        set => SetProperty("time_to_live", value);
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
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    public required TerraformProperty<string> SelfHostedIntegrationRuntimeName
    {
        set => SetProperty("self_hosted_integration_runtime_name", value);
    }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    public required TerraformProperty<string> StagingStorageLinkedServiceName
    {
        set => SetProperty("staging_storage_linked_service_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetName
    {
        set => SetProperty("subnet_name", value);
    }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VnetId
    {
        set => SetProperty("vnet_id", value);
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
        SetOutput("credential_name");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("edition");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("max_parallel_executions_per_node");
        SetOutput("name");
        SetOutput("node_size");
        SetOutput("number_of_nodes");
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    public TerraformProperty<string> CredentialName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credential_name");
        set => SetProperty("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public TerraformProperty<double> MaxParallelExecutionsPerNode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_parallel_executions_per_node");
        set => SetProperty("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformProperty<string> NodeSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_size");
        set => SetProperty("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfNodes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_nodes");
        set => SetProperty("number_of_nodes", value);
    }

    /// <summary>
    /// Block for catalog_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>? CatalogInfo
    {
        set => SetProperty("catalog_info", value);
    }

    /// <summary>
    /// Block for copy_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>? CopyComputeScale
    {
        set => SetProperty("copy_compute_scale", value);
    }

    /// <summary>
    /// Block for custom_setup_script.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>? CustomSetupScript
    {
        set => SetProperty("custom_setup_script", value);
    }

    /// <summary>
    /// Block for express_custom_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>? ExpressCustomSetup
    {
        set => SetProperty("express_custom_setup", value);
    }

    /// <summary>
    /// Block for express_vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>? ExpressVnetIntegration
    {
        set => SetProperty("express_vnet_integration", value);
    }

    /// <summary>
    /// Block for package_store.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>? PackageStore
    {
        set => SetProperty("package_store", value);
    }

    /// <summary>
    /// Block for pipeline_external_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>? PipelineExternalComputeScale
    {
        set => SetProperty("pipeline_external_compute_scale", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>? Proxy
    {
        set => SetProperty("proxy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    public List<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>? VnetIntegration
    {
        set => SetProperty("vnet_integration", value);
    }

}
