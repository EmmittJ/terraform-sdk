using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for feature_definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFeatureGroupFeatureDefinitionBlock : TerraformBlockBase
{
    /// <summary>
    /// The collection_type attribute.
    /// </summary>
    [TerraformProperty("collection_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CollectionType { get; set; }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    [TerraformProperty("feature_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FeatureName { get; set; }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [TerraformProperty("feature_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FeatureType { get; set; }

}

/// <summary>
/// Block type for offline_store_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFeatureGroupOfflineStoreConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_glue_table_creation attribute.
    /// </summary>
    [TerraformProperty("disable_glue_table_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableGlueTableCreation { get; set; }

    /// <summary>
    /// The table_format attribute.
    /// </summary>
    [TerraformProperty("table_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableFormat { get; set; }

}

/// <summary>
/// Block type for online_store_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFeatureGroupOnlineStoreConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_online_store attribute.
    /// </summary>
    [TerraformProperty("enable_online_store")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableOnlineStore { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageType { get; set; }

}

/// <summary>
/// Block type for throughput_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerFeatureGroupThroughputConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The provisioned_read_capacity_units attribute.
    /// </summary>
    [TerraformProperty("provisioned_read_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ProvisionedReadCapacityUnits { get; set; }

    /// <summary>
    /// The provisioned_write_capacity_units attribute.
    /// </summary>
    [TerraformProperty("provisioned_write_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ProvisionedWriteCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformProperty("throughput_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ThroughputMode { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_feature_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerFeatureGroup : TerraformResource
{
    public AwsSagemakerFeatureGroup(string name) : base("aws_sagemaker_feature_group", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The event_time_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeFeatureName is required")]
    [TerraformProperty("event_time_feature_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventTimeFeatureName { get; set; }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupName is required")]
    [TerraformProperty("feature_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FeatureGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The record_identifier_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordIdentifierFeatureName is required")]
    [TerraformProperty("record_identifier_feature_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for feature_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2500, ErrorMessage = "Maximum 2500 FeatureDefinition block(s) allowed")]
    [TerraformProperty("feature_definition")]
    public partial TerraformList<TerraformBlock<AwsSagemakerFeatureGroupFeatureDefinitionBlock>>? FeatureDefinition { get; set; }

    /// <summary>
    /// Block for offline_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OfflineStoreConfig block(s) allowed")]
    [TerraformProperty("offline_store_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>>? OfflineStoreConfig { get; set; }

    /// <summary>
    /// Block for online_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineStoreConfig block(s) allowed")]
    [TerraformProperty("online_store_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>>? OnlineStoreConfig { get; set; }

    /// <summary>
    /// Block for throughput_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThroughputConfig block(s) allowed")]
    [TerraformProperty("throughput_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerFeatureGroupThroughputConfigBlock>>? ThroughputConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
