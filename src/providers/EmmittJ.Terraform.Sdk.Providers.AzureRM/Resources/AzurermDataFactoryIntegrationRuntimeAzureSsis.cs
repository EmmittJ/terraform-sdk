using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    public TerraformValue<string>? DualStandbyPairName
    {
        get => new TerraformReference<string>(this, "dual_standby_pair_name");
        set => SetArgument("dual_standby_pair_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? ElasticPoolName
    {
        get => new TerraformReference<string>(this, "elastic_pool_name");
        set => SetArgument("elastic_pool_name", value);
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformValue<string>? PricingTier
    {
        get => new TerraformReference<string>(this, "pricing_tier");
        set => SetArgument("pricing_tier", value);
    }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
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
    public TerraformValue<double>? DataIntegrationUnit
    {
        get => new TerraformReference<double>(this, "data_integration_unit");
        set => SetArgument("data_integration_unit", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
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
    public required TerraformValue<string> BlobContainerUri
    {
        get => new TerraformReference<string>(this, "blob_container_uri");
        set => SetArgument("blob_container_uri", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
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
    public TerraformMap<string>? Environment
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment").ResolveNodes(ctx));
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
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
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
    public TerraformValue<double>? NumberOfExternalNodes
    {
        get => new TerraformReference<double>(this, "number_of_external_nodes");
        set => SetArgument("number_of_external_nodes", value);
    }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfPipelineNodes
    {
        get => new TerraformReference<double>(this, "number_of_pipeline_nodes");
        set => SetArgument("number_of_pipeline_nodes", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
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
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    public required TerraformValue<string> SelfHostedIntegrationRuntimeName
    {
        get => new TerraformReference<string>(this, "self_hosted_integration_runtime_name");
        set => SetArgument("self_hosted_integration_runtime_name", value);
    }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformList<string>? PublicIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ips").ResolveNodes(ctx));
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? SubnetName
    {
        get => new TerraformReference<string>(this, "subnet_name");
        set => SetArgument("subnet_name", value);
    }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    public TerraformValue<string>? VnetId
    {
        get => new TerraformReference<string>(this, "vnet_id");
        set => SetArgument("vnet_id", value);
    }

}

/// <summary>
/// Represents a azurerm_data_factory_integration_runtime_azure_ssis Terraform resource.
/// Manages a azurerm_data_factory_integration_runtime_azure_ssis resource.
/// </summary>
public partial class AzurermDataFactoryIntegrationRuntimeAzureSsis(string name) : TerraformResource("azurerm_data_factory_integration_runtime_azure_ssis", name)
{
    /// <summary>
    /// The credential_name attribute.
    /// </summary>
    public TerraformValue<string>? CredentialName
    {
        get => new TerraformReference<string>(this, "credential_name");
        set => SetArgument("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string>? Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public TerraformValue<double>? MaxParallelExecutionsPerNode
    {
        get => new TerraformReference<double>(this, "max_parallel_executions_per_node");
        set => SetArgument("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformValue<string> NodeSize
    {
        get => new TerraformReference<string>(this, "node_size");
        set => SetArgument("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => new TerraformReference<double>(this, "number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// CatalogInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock? CatalogInfo
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>("catalog_info");
        set => SetArgument("catalog_info", value);
    }

    /// <summary>
    /// CopyComputeScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock? CopyComputeScale
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>("copy_compute_scale");
        set => SetArgument("copy_compute_scale", value);
    }

    /// <summary>
    /// CustomSetupScript block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock? CustomSetupScript
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>("custom_setup_script");
        set => SetArgument("custom_setup_script", value);
    }

    /// <summary>
    /// ExpressCustomSetup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock? ExpressCustomSetup
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>("express_custom_setup");
        set => SetArgument("express_custom_setup", value);
    }

    /// <summary>
    /// ExpressVnetIntegration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock? ExpressVnetIntegration
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>("express_vnet_integration");
        set => SetArgument("express_vnet_integration", value);
    }

    /// <summary>
    /// PackageStore block (nesting mode: list).
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock? PackageStore
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>("package_store");
        set => SetArgument("package_store", value);
    }

    /// <summary>
    /// PipelineExternalComputeScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock? PipelineExternalComputeScale
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>("pipeline_external_compute_scale");
        set => SetArgument("pipeline_external_compute_scale", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock? Proxy
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VnetIntegration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VnetIntegration block(s) allowed")]
    public AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock? VnetIntegration
    {
        get => GetArgument<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>("vnet_integration");
        set => SetArgument("vnet_integration", value);
    }

}
