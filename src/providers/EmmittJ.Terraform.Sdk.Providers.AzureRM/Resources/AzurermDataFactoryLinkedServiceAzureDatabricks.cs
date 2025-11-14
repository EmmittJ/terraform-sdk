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
/// Block type for instance_pool in .
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
    [TerraformArgument("cluster_version")]
    public required TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    [TerraformArgument("instance_pool_id")]
    public required TerraformValue<string> InstancePoolId
    {
        get => new TerraformReference<string>(this, "instance_pool_id");
        set => SetArgument("instance_pool_id", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformArgument("max_number_of_workers")]
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformArgument("min_number_of_workers")]
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "min_number_of_workers");
        set => SetArgument("min_number_of_workers", value);
    }

}

/// <summary>
/// Block type for key_vault_password in .
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
    [TerraformArgument("linked_service_name")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformArgument("secret_name")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for new_cluster_config in .
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
    [TerraformArgument("cluster_version")]
    public required TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    [TerraformArgument("custom_tags")]
    public TerraformMap<string>? CustomTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_tags").ResolveNodes(ctx));
        set => SetArgument("custom_tags", value);
    }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    [TerraformArgument("driver_node_type")]
    public TerraformValue<string>? DriverNodeType
    {
        get => new TerraformReference<string>(this, "driver_node_type");
        set => SetArgument("driver_node_type", value);
    }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    [TerraformArgument("init_scripts")]
    public TerraformList<string>? InitScripts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "init_scripts").ResolveNodes(ctx));
        set => SetArgument("init_scripts", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformArgument("log_destination")]
    public TerraformValue<string>? LogDestination
    {
        get => new TerraformReference<string>(this, "log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformArgument("max_number_of_workers")]
    public TerraformValue<double>? MaxNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "max_number_of_workers");
        set => SetArgument("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformArgument("min_number_of_workers")]
    public TerraformValue<double>? MinNumberOfWorkers
    {
        get => new TerraformReference<double>(this, "min_number_of_workers");
        set => SetArgument("min_number_of_workers", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformArgument("node_type")]
    public required TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    [TerraformArgument("spark_config")]
    public TerraformMap<string>? SparkConfig
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "spark_config").ResolveNodes(ctx));
        set => SetArgument("spark_config", value);
    }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    [TerraformArgument("spark_environment_variables")]
    public TerraformMap<string>? SparkEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "spark_environment_variables").ResolveNodes(ctx));
        set => SetArgument("spark_environment_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_data_factory_linked_service_azure_databricks resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryLinkedServiceAzureDatabricks : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureDatabricks(string name) : base("azurerm_data_factory_linked_service_azure_databricks", name)
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformArgument("access_token")]
    public TerraformValue<string>? AccessToken
    {
        get => new TerraformReference<string>(this, "access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    [TerraformArgument("adb_domain")]
    public required TerraformValue<string> AdbDomain
    {
        get => new TerraformReference<string>(this, "adb_domain");
        set => SetArgument("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformArgument("additional_properties")]
    public TerraformMap<string>? AdditionalProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_properties").ResolveNodes(ctx));
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformArgument("annotations")]
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    [TerraformArgument("existing_cluster_id")]
    public TerraformValue<string>? ExistingClusterId
    {
        get => new TerraformReference<string>(this, "existing_cluster_id");
        set => SetArgument("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformArgument("integration_runtime_name")]
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => new TerraformReference<string>(this, "integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    [TerraformArgument("msi_work_space_resource_id")]
    public TerraformValue<string>? MsiWorkSpaceResourceId
    {
        get => new TerraformReference<string>(this, "msi_work_space_resource_id");
        set => SetArgument("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Block for instance_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    [TerraformArgument("instance_pool")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock> InstancePool { get; set; } = new();

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    [TerraformArgument("key_vault_password")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock> KeyVaultPassword { get; set; } = new();

    /// <summary>
    /// Block for new_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    [TerraformArgument("new_cluster_config")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock> NewClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock Timeouts { get; set; } = new();

}
