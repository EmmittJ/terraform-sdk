using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for instance_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformPropertyName("cluster_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterVersion { get; set; }

    /// <summary>
    /// The instance_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePoolId is required")]
    [TerraformPropertyName("instance_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstancePoolId { get; set; }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxNumberOfWorkers { get; set; }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("min_number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinNumberOfWorkers { get; set; }

}

/// <summary>
/// Block type for key_vault_password in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock : ITerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformPropertyName("linked_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformPropertyName("secret_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretName { get; set; }

}

/// <summary>
/// Block type for new_cluster_config in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformPropertyName("cluster_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterVersion { get; set; }

    /// <summary>
    /// The custom_tags attribute.
    /// </summary>
    [TerraformPropertyName("custom_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? CustomTags { get; set; }

    /// <summary>
    /// The driver_node_type attribute.
    /// </summary>
    [TerraformPropertyName("driver_node_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DriverNodeType { get; set; }

    /// <summary>
    /// The init_scripts attribute.
    /// </summary>
    [TerraformPropertyName("init_scripts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InitScripts { get; set; }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformPropertyName("log_destination")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogDestination { get; set; }

    /// <summary>
    /// The max_number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxNumberOfWorkers { get; set; }

    /// <summary>
    /// The min_number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("min_number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinNumberOfWorkers { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeType { get; set; }

    /// <summary>
    /// The spark_config attribute.
    /// </summary>
    [TerraformPropertyName("spark_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? SparkConfig { get; set; }

    /// <summary>
    /// The spark_environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("spark_environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? SparkEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("access_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccessToken { get; set; }

    /// <summary>
    /// The adb_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdbDomain is required")]
    [TerraformPropertyName("adb_domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdbDomain { get; set; }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The existing_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("existing_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExistingClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformPropertyName("integration_runtime_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The msi_work_space_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("msi_work_space_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MsiWorkSpaceResourceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// Block for instance_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstancePool block(s) allowed")]
    [TerraformPropertyName("instance_pool")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceAzureDatabricksInstancePoolBlock>>? InstancePool { get; set; } = new();

    /// <summary>
    /// Block for key_vault_password.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyVaultPassword block(s) allowed")]
    [TerraformPropertyName("key_vault_password")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceAzureDatabricksKeyVaultPasswordBlock>>? KeyVaultPassword { get; set; } = new();

    /// <summary>
    /// Block for new_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewClusterConfig block(s) allowed")]
    [TerraformPropertyName("new_cluster_config")]
    public TerraformList<TerraformBlock<AzurermDataFactoryLinkedServiceAzureDatabricksNewClusterConfigBlock>>? NewClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryLinkedServiceAzureDatabricksTimeoutsBlock>? Timeouts { get; set; } = new();

}
