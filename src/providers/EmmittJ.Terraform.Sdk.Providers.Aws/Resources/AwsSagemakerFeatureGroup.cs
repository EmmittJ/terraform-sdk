using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for feature_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlock
{
    /// <summary>
    /// The collection_type attribute.
    /// </summary>
    [TerraformPropertyName("collection_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CollectionType { get; set; }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    [TerraformPropertyName("feature_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FeatureName { get; set; }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [TerraformPropertyName("feature_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FeatureType { get; set; }

}

/// <summary>
/// Block type for offline_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlock
{
    /// <summary>
    /// The disable_glue_table_creation attribute.
    /// </summary>
    [TerraformPropertyName("disable_glue_table_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableGlueTableCreation { get; set; }

    /// <summary>
    /// The table_format attribute.
    /// </summary>
    [TerraformPropertyName("table_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TableFormat { get; set; }

}

/// <summary>
/// Block type for online_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlock
{
    /// <summary>
    /// The enable_online_store attribute.
    /// </summary>
    [TerraformPropertyName("enable_online_store")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableOnlineStore { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageType { get; set; }

}

/// <summary>
/// Block type for throughput_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupThroughputConfigBlock
{
    /// <summary>
    /// The provisioned_read_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_read_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ProvisionedReadCapacityUnits { get; set; }

    /// <summary>
    /// The provisioned_write_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_write_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ProvisionedWriteCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ThroughputMode { get; set; } = default!;

}

/// <summary>
/// Manages a aws_sagemaker_feature_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerFeatureGroup : TerraformResource
{
    public AwsSagemakerFeatureGroup(string name) : base("aws_sagemaker_feature_group", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The event_time_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeFeatureName is required")]
    [TerraformPropertyName("event_time_feature_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EventTimeFeatureName { get; set; }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupName is required")]
    [TerraformPropertyName("feature_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FeatureGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The record_identifier_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordIdentifierFeatureName is required")]
    [TerraformPropertyName("record_identifier_feature_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for feature_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2500, ErrorMessage = "Maximum 2500 FeatureDefinition block(s) allowed")]
    [TerraformPropertyName("feature_definition")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupFeatureDefinitionBlock>>? FeatureDefinition { get; set; }

    /// <summary>
    /// Block for offline_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OfflineStoreConfig block(s) allowed")]
    [TerraformPropertyName("offline_store_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>>? OfflineStoreConfig { get; set; }

    /// <summary>
    /// Block for online_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineStoreConfig block(s) allowed")]
    [TerraformPropertyName("online_store_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>>? OnlineStoreConfig { get; set; }

    /// <summary>
    /// Block for throughput_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThroughputConfig block(s) allowed")]
    [TerraformPropertyName("throughput_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupThroughputConfigBlock>>? ThroughputConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
