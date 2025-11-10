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
        set => SetProperty("cluster_version", value);
    }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    public required TerraformProperty<string> InstancePoolId
    {
        set => SetProperty("instance_pool_id", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxNumberOfWorkers
    {
        set => SetProperty("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MinNumberOfWorkers
    {
        set => SetProperty("min_number_of_workers", value);
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
        set => SetProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        set => SetProperty("secret_name", value);
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
        set => SetProperty("cluster_version", value);
    }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomTags
    {
        set => SetProperty("custom_tags", value);
    }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    public TerraformProperty<string>? DriverNodeType
    {
        set => SetProperty("driver_node_type", value);
    }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InitScripts
    {
        set => SetProperty("init_scripts", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformProperty<string>? LogDestination
    {
        set => SetProperty("log_destination", value);
    }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxNumberOfWorkers
    {
        set => SetProperty("max_number_of_workers", value);
    }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MinNumberOfWorkers
    {
        set => SetProperty("min_number_of_workers", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SparkConfig
    {
        set => SetProperty("spark_config", value);
    }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SparkEnvironmentVariables
    {
        set => SetProperty("spark_environment_variables", value);
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
        SetOutput("access_token");
        SetOutput("adb_domain");
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("existing_cluster_id");
        SetOutput("id");
        SetOutput("integration_runtime_name");
        SetOutput("msi_work_space_resource_id");
        SetOutput("name");
        SetOutput("parameters");
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string> AccessToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_token");
        set => SetProperty("access_token", value);
    }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    public required TerraformProperty<string> AdbDomain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("adb_domain");
        set => SetProperty("adb_domain", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
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
    /// The existing_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string> ExistingClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("existing_cluster_id");
        set => SetProperty("existing_cluster_id", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationRuntimeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_runtime_name");
        set => SetProperty("integration_runtime_name", value);
    }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> MsiWorkSpaceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("msi_work_space_resource_id");
        set => SetProperty("msi_work_space_resource_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Block for instance_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>? InstancePool
    {
        set => SetProperty("instance_pool", value);
    }

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>? KeyVaultPassword
    {
        set => SetProperty("key_vault_password", value);
    }

    /// <summary>
    /// Block for new_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    public List<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>? NewClusterConfig
    {
        set => SetProperty("new_cluster_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
