using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for instance_pool in AzurermDataFactoryLinkedServiceAzureDatabricks.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_pool";

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformValue<string> ClusterVersion
    {
        get => GetArgument<TerraformValue<string>>("cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    public required TerraformValue<string> InstancePoolId
    {
        get => GetArgument<TerraformValue<string>>("instance_pool_id");
        set => SetArgument("instance_pool_id", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("min_number_of_workers");
        set => SetArgument("min_number_of_workers", value);
    }

}


/// <summary>
/// Block type for key_vault_password in AzurermDataFactoryLinkedServiceAzureDatabricks.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock : TerraformBlock
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
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}


/// <summary>
/// Block type for new_cluster_config in AzurermDataFactoryLinkedServiceAzureDatabricks.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_cluster_config";

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformValue<string> ClusterVersion
    {
        get => GetArgument<TerraformValue<string>>("cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    public TerraformMap<string>? CustomTags
    {
        get => GetArgument<TerraformMap<string>>("custom_tags");
        set => SetArgument("custom_tags", value);
    }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    public TerraformValue<string>? DriverNodeType
    {
        get => GetArgument<TerraformValue<string>>("driver_node_type");
        set => SetArgument("driver_node_type", value);
    }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    public TerraformList<string>? InitScripts
    {
        get => GetArgument<TerraformList<string>>("init_scripts");
        set => SetArgument("init_scripts", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformValue<string>? LogDestination
    {
        get => GetArgument<TerraformValue<string>>("log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("min_number_of_workers");
        set => SetArgument("min_number_of_workers", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    public TerraformMap<string>? SparkConfig
    {
        get => GetArgument<TerraformMap<string>>("spark_config");
        set => SetArgument("spark_config", value);
    }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SparkEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("spark_environment_variables");
        set => SetArgument("spark_environment_variables", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryLinkedServiceAzureDatabricks.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_linked_service_azure_databricks Terraform resource.
/// Manages a azurerm_data_factory_linked_service_azure_databricks resource.
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureDatabricks(string name) : TerraformResource("azurerm_data_factory_linked_service_azure_databricks", name)
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    public required TerraformValue<string> AdbDomain
    {
        get => GetArgument<TerraformValue<string>>("adb_domain");
        set => SetArgument("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? ExistingClusterId
    {
        get => GetArgument<TerraformValue<string>>("existing_cluster_id");
        set => SetArgument("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => GetArgument<TerraformValue<string>>("integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? MsiWorkSpaceResourceId
    {
        get => GetArgument<TerraformValue<string>>("msi_work_space_resource_id");
        set => SetArgument("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// InstancePool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>? InstancePool
    {
        get => GetArgument<TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>>("instance_pool");
        set => SetArgument("instance_pool", value);
    }

    /// <summary>
    /// KeyVaultPassword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>? KeyVaultPassword
    {
        get => GetArgument<TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>>("key_vault_password");
        set => SetArgument("key_vault_password", value);
    }

    /// <summary>
    /// NewClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>? NewClusterConfig
    {
        get => GetArgument<TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>>("new_cluster_config");
        set => SetArgument("new_cluster_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
