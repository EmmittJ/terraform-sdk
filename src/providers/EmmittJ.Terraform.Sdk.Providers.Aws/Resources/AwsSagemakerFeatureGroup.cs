using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for feature_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlock : ITerraformBlock
{
    /// <summary>
    /// The collection_type attribute.
    /// </summary>
    [TerraformPropertyName("collection_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CollectionType { get; set; }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    [TerraformPropertyName("feature_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FeatureName { get; set; }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [TerraformPropertyName("feature_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FeatureType { get; set; }

}

/// <summary>
/// Block type for offline_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_glue_table_creation attribute.
    /// </summary>
    [TerraformPropertyName("disable_glue_table_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableGlueTableCreation { get; set; }

    /// <summary>
    /// The table_format attribute.
    /// </summary>
    [TerraformPropertyName("table_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TableFormat { get; set; }

}

/// <summary>
/// Block type for online_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_online_store attribute.
    /// </summary>
    [TerraformPropertyName("enable_online_store")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableOnlineStore { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageType { get; set; }

}

/// <summary>
/// Block type for throughput_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupThroughputConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The provisioned_read_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_read_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ProvisionedReadCapacityUnits { get; set; }

    /// <summary>
    /// The provisioned_write_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_write_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ProvisionedWriteCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ThroughputMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "throughput_mode");

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The event_time_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeFeatureName is required")]
    [TerraformPropertyName("event_time_feature_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventTimeFeatureName { get; set; }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupName is required")]
    [TerraformPropertyName("feature_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FeatureGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The record_identifier_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordIdentifierFeatureName is required")]
    [TerraformPropertyName("record_identifier_feature_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for feature_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2500, ErrorMessage = "Maximum 2500 FeatureDefinition block(s) allowed")]
    [TerraformPropertyName("feature_definition")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupFeatureDefinitionBlock>>? FeatureDefinition { get; set; } = new();

    /// <summary>
    /// Block for offline_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OfflineStoreConfig block(s) allowed")]
    [TerraformPropertyName("offline_store_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>>? OfflineStoreConfig { get; set; } = new();

    /// <summary>
    /// Block for online_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineStoreConfig block(s) allowed")]
    [TerraformPropertyName("online_store_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>>? OnlineStoreConfig { get; set; } = new();

    /// <summary>
    /// Block for throughput_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThroughputConfig block(s) allowed")]
    [TerraformPropertyName("throughput_config")]
    public TerraformList<TerraformBlock<AwsSagemakerFeatureGroupThroughputConfigBlock>>? ThroughputConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
