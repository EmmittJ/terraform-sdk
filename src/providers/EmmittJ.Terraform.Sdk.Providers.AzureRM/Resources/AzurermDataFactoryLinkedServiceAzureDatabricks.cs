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
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    public required TerraformValue<string> InstancePoolId
    {
        get => new TerraformReference<string>(this, "instance_pool_id");
        set => SetArgument("instance_pool_id", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "min_number_of_workers");
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
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
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
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    public TerraformMap<string>? CustomTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_tags").ResolveNodes(ctx));
        set => SetArgument("custom_tags", value);
    }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    public TerraformValue<string>? DriverNodeType
    {
        get => new TerraformReference<string>(this, "driver_node_type");
        set => SetArgument("driver_node_type", value);
    }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    public TerraformList<string>? InitScripts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "init_scripts").ResolveNodes(ctx));
        set => SetArgument("init_scripts", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformValue<string>? LogDestination
    {
        get => new TerraformReference<string>(this, "log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "min_number_of_workers");
        set => SetArgument("min_number_of_workers", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    public TerraformMap<string>? SparkConfig
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "spark_config").ResolveNodes(ctx));
        set => SetArgument("spark_config", value);
    }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SparkEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "spark_environment_variables").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    public required TerraformValue<string> AdbDomain
    {
        get => new TerraformReference<string>(this, "adb_domain");
        set => SetArgument("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_properties").ResolveNodes(ctx));
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? ExistingClusterId
    {
        get => new TerraformReference<string>(this, "existing_cluster_id");
        set => SetArgument("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => new TerraformReference<string>(this, "integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? MsiWorkSpaceResourceId
    {
        get => new TerraformReference<string>(this, "msi_work_space_resource_id");
        set => SetArgument("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
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
