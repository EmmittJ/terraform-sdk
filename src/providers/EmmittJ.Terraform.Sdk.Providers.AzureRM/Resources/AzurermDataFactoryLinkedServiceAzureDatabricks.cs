using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for instance_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock() : TerraformBlock("instance_pool")
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformProperty("cluster_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterVersion { get; set; }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    [TerraformProperty("instance_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstancePoolId { get; set; }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformProperty("max_number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxNumberOfWorkers { get; set; }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformProperty("min_number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinNumberOfWorkers { get; set; }

}

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock() : TerraformBlock("key_vault_password")
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretName { get; set; }

}

/// <summary>
/// Block type for new_cluster_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock() : TerraformBlock("new_cluster_config")
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformProperty("cluster_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterVersion { get; set; }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    [TerraformProperty("custom_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CustomTags { get; set; }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    [TerraformProperty("driver_node_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DriverNodeType { get; set; }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    [TerraformProperty("init_scripts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InitScripts { get; set; }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformProperty("log_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogDestination { get; set; }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformProperty("max_number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxNumberOfWorkers { get; set; }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformProperty("min_number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinNumberOfWorkers { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    [TerraformProperty("spark_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SparkConfig { get; set; }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    [TerraformProperty("spark_environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SparkEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_databricks resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryLinkedServiceAzureDatabricks : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureDatabricks(string name) : base("azurerm_data_factory_linked_service_azure_databricks", name)
    {
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformProperty("access_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessToken { get; set; }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    [TerraformProperty("adb_domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdbDomain { get; set; }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The existing_cluster_id attribute.
    /// </summary>
    [TerraformProperty("existing_cluster_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExistingClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformProperty("integration_runtime_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    [TerraformProperty("msi_work_space_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MsiWorkSpaceResourceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// Block for instance_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    [TerraformProperty("instance_pool")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock> InstancePool { get; set; } = new();

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    [TerraformProperty("key_vault_password")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock> KeyVaultPassword { get; set; } = new();

    /// <summary>
    /// Block for new_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    [TerraformProperty("new_cluster_config")]
    public TerraformList<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock> NewClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock Timeouts { get; set; } = new();

}
