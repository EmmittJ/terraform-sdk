using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schema_column in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryDatasetSnowflakeSchemaColumnBlock() : TerraformBlock("schema_column")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The precision attribute.
    /// </summary>
    [TerraformProperty("precision")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Precision { get; set; }

    /// <summary>
    /// The scale attribute.
    /// </summary>
    [TerraformProperty("scale")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Scale { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryDatasetSnowflakeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_data_factory_dataset_snowflake resource.
/// </summary>
public partial class AzurermDataFactoryDatasetSnowflake : TerraformResource
{
    public AzurermDataFactoryDatasetSnowflake(string name) : base("azurerm_data_factory_dataset_snowflake", name)
    {
    }

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
    /// The folder attribute.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedServiceName { get; set; }

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
    /// The schema_name attribute.
    /// </summary>
    [TerraformProperty("schema_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SchemaName { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [TerraformProperty("table_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableName { get; set; }

    /// <summary>
    /// Block for schema_column.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("schema_column")]
    public TerraformList<AzurermDataFactoryDatasetSnowflakeSchemaColumnBlock> SchemaColumn { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryDatasetSnowflakeTimeoutsBlock Timeouts { get; set; } = new();

}
