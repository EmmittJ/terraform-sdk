using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for instance_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformProperty<string> ClusterVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_version");
        set => WithProperty("cluster_version", value);
    }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    public required TerraformProperty<string> InstancePoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_pool_id");
        set => WithProperty("instance_pool_id", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxNumberOfWorkers
    {
        get => GetProperty<TerraformProperty<double>>("max_number_of_workers");
        set => WithProperty("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MinNumberOfWorkers
    {
        get => GetProperty<TerraformProperty<double>>("min_number_of_workers");
        set => WithProperty("min_number_of_workers", value);
    }

}

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock : TerraformBlock
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
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

}

/// <summary>
/// Block type for new_cluster_config in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformProperty<string> ClusterVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_version");
        set => WithProperty("cluster_version", value);
    }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("custom_tags");
        set => WithProperty("custom_tags", value);
    }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    public TerraformProperty<string>? DriverNodeType
    {
        get => GetProperty<TerraformProperty<string>>("driver_node_type");
        set => WithProperty("driver_node_type", value);
    }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InitScripts
    {
        get => GetProperty<List<TerraformProperty<string>>>("init_scripts");
        set => WithProperty("init_scripts", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformProperty<string>? LogDestination
    {
        get => GetProperty<TerraformProperty<string>>("log_destination");
        set => WithProperty("log_destination", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxNumberOfWorkers
    {
        get => GetProperty<TerraformProperty<double>>("max_number_of_workers");
        set => WithProperty("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MinNumberOfWorkers
    {
        get => GetProperty<TerraformProperty<double>>("min_number_of_workers");
        set => WithProperty("min_number_of_workers", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("node_type");
        set => WithProperty("node_type", value);
    }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SparkConfig
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("spark_config");
        set => WithProperty("spark_config", value);
    }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SparkEnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("spark_environment_variables");
        set => WithProperty("spark_environment_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_linked_service_azure_databricks resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryLinkedServiceAzureDatabricks : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureDatabricks(string name) : base("azurerm_data_factory_linked_service_azure_databricks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    public required TerraformProperty<string> AdbDomain
    {
        get => GetRequiredProperty<TerraformProperty<string>>("adb_domain");
        set => this.WithProperty("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExistingClusterId
    {
        get => GetProperty<TerraformProperty<string>>("existing_cluster_id");
        set => this.WithProperty("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationRuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("integration_runtime_name");
        set => this.WithProperty("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? MsiWorkSpaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("msi_work_space_resource_id");
        set => this.WithProperty("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for instance_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>? InstancePool
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>>("instance_pool");
        set => this.WithProperty("instance_pool", value);
    }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>? KeyVaultPassword
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>>("key_vault_password");
        set => this.WithProperty("key_vault_password", value);
    }

    /// <summary>
    /// Block for new_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>? NewClusterConfig
    {
        get => GetProperty<List<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>>("new_cluster_config");
        set => this.WithProperty("new_cluster_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
