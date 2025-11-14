using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for catalog_info in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog_info";

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string>? AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformArgument("administrator_password")]
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    [TerraformArgument("dual_standby_pair_name")]
    public TerraformValue<string>? DualStandbyPairName
    {
        get => new TerraformReference<string>(this, "dual_standby_pair_name");
        set => SetArgument("dual_standby_pair_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformArgument("elastic_pool_name")]
    public TerraformValue<string>? ElasticPoolName
    {
        get => new TerraformReference<string>(this, "elastic_pool_name");
        set => SetArgument("elastic_pool_name", value);
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformArgument("pricing_tier")]
    public TerraformValue<string>? PricingTier
    {
        get => new TerraformReference<string>(this, "pricing_tier");
        set => SetArgument("pricing_tier", value);
    }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    [TerraformArgument("server_endpoint")]
    public required TerraformValue<string> ServerEndpoint
    {
        get => new TerraformReference<string>(this, "server_endpoint");
        set => SetArgument("server_endpoint", value);
    }

}

/// <summary>
/// Block type for copy_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "copy_compute_scale";

    /// <summary>
    /// The data_integration_unit attribute.
    /// </summary>
    [TerraformArgument("data_integration_unit")]
    public TerraformValue<double>? DataIntegrationUnit
    {
        get => new TerraformReference<double>(this, "data_integration_unit");
        set => SetArgument("data_integration_unit", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformArgument("time_to_live")]
    public TerraformValue<double>? TimeToLive
    {
        get => new TerraformReference<double>(this, "time_to_live");
        set => SetArgument("time_to_live", value);
    }

}

/// <summary>
/// Block type for custom_setup_script in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_setup_script";

    /// <summary>
    /// The blob_container_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobContainerUri is required")]
    [TerraformArgument("blob_container_uri")]
    public required TerraformValue<string> BlobContainerUri
    {
        get => new TerraformReference<string>(this, "blob_container_uri");
        set => SetArgument("blob_container_uri", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    [TerraformArgument("sas_token")]
    public required TerraformValue<string> SasToken
    {
        get => new TerraformReference<string>(this, "sas_token");
        set => SetArgument("sas_token", value);
    }

}

/// <summary>
/// Block type for express_custom_setup in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "express_custom_setup";

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformArgument("environment")]
    public TerraformMap<string>? Environment
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment").ResolveNodes(ctx));
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    [TerraformArgument("powershell_version")]
    public TerraformValue<string>? PowershellVersion
    {
        get => new TerraformReference<string>(this, "powershell_version");
        set => SetArgument("powershell_version", value);
    }

}

/// <summary>
/// Block type for express_vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "express_vnet_integration";

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for package_store in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "package_store";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for pipeline_external_compute_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_external_compute_scale";

    /// <summary>
    /// The number_of_external_nodes attribute.
    /// </summary>
    [TerraformArgument("number_of_external_nodes")]
    public TerraformValue<double>? NumberOfExternalNodes
    {
        get => new TerraformReference<double>(this, "number_of_external_nodes");
        set => SetArgument("number_of_external_nodes", value);
    }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    [TerraformArgument("number_of_pipeline_nodes")]
    public TerraformValue<double>? NumberOfPipelineNodes
    {
        get => new TerraformReference<double>(this, "number_of_pipeline_nodes");
        set => SetArgument("number_of_pipeline_nodes", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    [TerraformArgument("time_to_live")]
    public TerraformValue<double>? TimeToLive
    {
        get => new TerraformReference<double>(this, "time_to_live");
        set => SetArgument("time_to_live", value);
    }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    [TerraformArgument("self_hosted_integration_runtime_name")]
    public required TerraformValue<string> SelfHostedIntegrationRuntimeName
    {
        get => new TerraformReference<string>(this, "self_hosted_integration_runtime_name");
        set => SetArgument("self_hosted_integration_runtime_name", value);
    }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    [TerraformArgument("staging_storage_linked_service_name")]
    public required TerraformValue<string> StagingStorageLinkedServiceName
    {
        get => new TerraformReference<string>(this, "staging_storage_linked_service_name");
        set => SetArgument("staging_storage_linked_service_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for vnet_integration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vnet_integration";

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformArgument("public_ips")]
    public TerraformList<string>? PublicIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ips").ResolveNodes(ctx));
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    [TerraformArgument("subnet_name")]
    public TerraformValue<string>? SubnetName
    {
        get => new TerraformReference<string>(this, "subnet_name");
        set => SetArgument("subnet_name", value);
    }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    [TerraformArgument("vnet_id")]
    public TerraformValue<string>? VnetId
    {
        get => new TerraformReference<string>(this, "vnet_id");
        set => SetArgument("vnet_id", value);
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
    }

    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    [TerraformArgument("credential_name")]
    public TerraformValue<string>? CredentialName
    {
        get => new TerraformReference<string>(this, "credential_name");
        set => SetArgument("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformArgument("data_factory_id")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformArgument("edition")]
    public TerraformValue<string>? Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    [TerraformArgument("max_parallel_executions_per_node")]
    public TerraformValue<double>? MaxParallelExecutionsPerNode
    {
        get => new TerraformReference<double>(this, "max_parallel_executions_per_node");
        set => SetArgument("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    [TerraformArgument("node_size")]
    public required TerraformValue<string> NodeSize
    {
        get => new TerraformReference<string>(this, "node_size");
        set => SetArgument("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformArgument("number_of_nodes")]
    public TerraformValue<double>? NumberOfNodes
    {
        get => new TerraformReference<double>(this, "number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// Block for catalog_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    [TerraformArgument("catalog_info")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock> CatalogInfo { get; set; } = new();

    /// <summary>
    /// Block for copy_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    [TerraformArgument("copy_compute_scale")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock> CopyComputeScale { get; set; } = new();

    /// <summary>
    /// Block for custom_setup_script.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    [TerraformArgument("custom_setup_script")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock> CustomSetupScript { get; set; } = new();

    /// <summary>
    /// Block for express_custom_setup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    [TerraformArgument("express_custom_setup")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock> ExpressCustomSetup { get; set; } = new();

    /// <summary>
    /// Block for express_vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    [TerraformArgument("express_vnet_integration")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock> ExpressVnetIntegration { get; set; } = new();

    /// <summary>
    /// Block for package_store.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("package_store")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock> PackageStore { get; set; } = new();

    /// <summary>
    /// Block for pipeline_external_compute_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    [TerraformArgument("pipeline_external_compute_scale")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock> PipelineExternalComputeScale { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformArgument("proxy")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock> Proxy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vnet_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    [TerraformArgument("vnet_integration")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock> VnetIntegration { get; set; } = new();

}
