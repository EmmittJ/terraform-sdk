using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for catalog_info in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPassword
    {
        get => GetArgument<TerraformValue<string>>("administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The dual_standby_pair_name attribute.
    /// </summary>
    public TerraformValue<string>? DualStandbyPairName
    {
        get => GetArgument<TerraformValue<string>>("dual_standby_pair_name");
        set => SetArgument("dual_standby_pair_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? ElasticPoolName
    {
        get => GetArgument<TerraformValue<string>>("elastic_pool_name");
        set => SetArgument("elastic_pool_name", value);
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformValue<string>? PricingTier
    {
        get => GetArgument<TerraformValue<string>>("pricing_tier");
        set => SetArgument("pricing_tier", value);
    }

    /// <summary>
    /// The server_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerEndpoint is required")]
    public required TerraformValue<string> ServerEndpoint
    {
        get => GetArgument<TerraformValue<string>>("server_endpoint");
        set => SetArgument("server_endpoint", value);
    }

}


/// <summary>
/// Block type for copy_compute_scale in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<double>>("data_integration_unit");
        set => SetArgument("data_integration_unit", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformValue<double>? TimeToLive
    {
        get => GetArgument<TerraformValue<double>>("time_to_live");
        set => SetArgument("time_to_live", value);
    }

}


/// <summary>
/// Block type for custom_setup_script in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("blob_container_uri");
        set => SetArgument("blob_container_uri", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    public required TerraformValue<string> SasToken
    {
        get => GetArgument<TerraformValue<string>>("sas_token");
        set => SetArgument("sas_token", value);
    }

}


/// <summary>
/// Block type for express_custom_setup in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformMap<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The powershell_version attribute.
    /// </summary>
    public TerraformValue<string>? PowershellVersion
    {
        get => GetArgument<TerraformValue<string>>("powershell_version");
        set => SetArgument("powershell_version", value);
    }

    /// <summary>
    /// CommandKey block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlock>? CommandKey
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlock>>("command_key");
        set => SetArgument("command_key", value);
    }

    /// <summary>
    /// Component block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlock>? Component
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlock>>("component");
        set => SetArgument("component", value);
    }

}

/// <summary>
/// Block type for command_key in AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "command_key";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformValue<string> TargetName
    {
        get => GetArgument<TerraformValue<string>>("target_name");
        set => SetArgument("target_name", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// KeyVaultPassword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlockKeyVaultPasswordBlock>? KeyVaultPassword
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlockKeyVaultPasswordBlock>>("key_vault_password");
        set => SetArgument("key_vault_password", value);
    }

}

/// <summary>
/// Block type for key_vault_password in AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockCommandKeyBlockKeyVaultPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_password";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The secret_version attribute.
    /// </summary>
    public TerraformValue<string>? SecretVersion
    {
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for component in AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component";

    /// <summary>
    /// The license attribute.
    /// </summary>
    public TerraformValue<string>? License
    {
        get => GetArgument<TerraformValue<string>>("license");
        set => SetArgument("license", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// KeyVaultLicense block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultLicense block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlockKeyVaultLicenseBlock>? KeyVaultLicense
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlockKeyVaultLicenseBlock>>("key_vault_license");
        set => SetArgument("key_vault_license", value);
    }

}

/// <summary>
/// Block type for key_vault_license in AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlockComponentBlockKeyVaultLicenseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault_license";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The secret_version attribute.
    /// </summary>
    public TerraformValue<string>? SecretVersion
    {
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for express_vnet_integration in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for package_store in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for pipeline_external_compute_scale in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<double>>("number_of_external_nodes");
        set => SetArgument("number_of_external_nodes", value);
    }

    /// <summary>
    /// The number_of_pipeline_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfPipelineNodes
    {
        get => GetArgument<TerraformValue<double>>("number_of_pipeline_nodes");
        set => SetArgument("number_of_pipeline_nodes", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformValue<double>? TimeToLive
    {
        get => GetArgument<TerraformValue<double>>("time_to_live");
        set => SetArgument("time_to_live", value);
    }

}


/// <summary>
/// Block type for proxy in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The self_hosted_integration_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelfHostedIntegrationRuntimeName is required")]
    public required TerraformValue<string> SelfHostedIntegrationRuntimeName
    {
        get => GetArgument<TerraformValue<string>>("self_hosted_integration_runtime_name");
        set => SetArgument("self_hosted_integration_runtime_name", value);
    }

    /// <summary>
    /// The staging_storage_linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StagingStorageLinkedServiceName is required")]
    public required TerraformValue<string> StagingStorageLinkedServiceName
    {
        get => GetArgument<TerraformValue<string>>("staging_storage_linked_service_name");
        set => SetArgument("staging_storage_linked_service_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vnet_integration in AzurermDataFactoryIntegrationRuntimeAzureSsis.
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
        get => GetArgument<TerraformList<string>>("public_ips");
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? SubnetName
    {
        get => GetArgument<TerraformValue<string>>("subnet_name");
        set => SetArgument("subnet_name", value);
    }

    /// <summary>
    /// The vnet_id attribute.
    /// </summary>
    public TerraformValue<string>? VnetId
    {
        get => GetArgument<TerraformValue<string>>("vnet_id");
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
        get => GetArgument<TerraformValue<string>>("credential_name");
        set => SetArgument("credential_name", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string>? Edition
    {
        get => GetArgument<TerraformValue<string>>("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_parallel_executions_per_node attribute.
    /// </summary>
    public TerraformValue<double>? MaxParallelExecutionsPerNode
    {
        get => GetArgument<TerraformValue<double>>("max_parallel_executions_per_node");
        set => SetArgument("max_parallel_executions_per_node", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeSize is required")]
    public required TerraformValue<string> NodeSize
    {
        get => GetArgument<TerraformValue<string>>("node_size");
        set => SetArgument("node_size", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => GetArgument<TerraformValue<double>>("number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// CatalogInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CatalogInfo block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>? CatalogInfo
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCatalogInfoBlock>>("catalog_info");
        set => SetArgument("catalog_info", value);
    }

    /// <summary>
    /// CopyComputeScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyComputeScale block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>? CopyComputeScale
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCopyComputeScaleBlock>>("copy_compute_scale");
        set => SetArgument("copy_compute_scale", value);
    }

    /// <summary>
    /// CustomSetupScript block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSetupScript block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>? CustomSetupScript
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisCustomSetupScriptBlock>>("custom_setup_script");
        set => SetArgument("custom_setup_script", value);
    }

    /// <summary>
    /// ExpressCustomSetup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressCustomSetup block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>? ExpressCustomSetup
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupBlock>>("express_custom_setup");
        set => SetArgument("express_custom_setup", value);
    }

    /// <summary>
    /// ExpressVnetIntegration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpressVnetIntegration block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>? ExpressVnetIntegration
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegrationBlock>>("express_vnet_integration");
        set => SetArgument("express_vnet_integration", value);
    }

    /// <summary>
    /// PackageStore block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>? PackageStore
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPackageStoreBlock>>("package_store");
        set => SetArgument("package_store", value);
    }

    /// <summary>
    /// PipelineExternalComputeScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineExternalComputeScale block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>? PipelineExternalComputeScale
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScaleBlock>>("pipeline_external_compute_scale");
        set => SetArgument("pipeline_external_compute_scale", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisProxyBlock>>("proxy");
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
    public TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>? VnetIntegration
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIntegrationRuntimeAzureSsisVnetIntegrationBlock>>("vnet_integration");
        set => SetArgument("vnet_integration", value);
    }

}
