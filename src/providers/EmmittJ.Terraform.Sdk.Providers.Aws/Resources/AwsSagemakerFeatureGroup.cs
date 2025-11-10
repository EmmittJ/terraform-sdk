using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for feature_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// The collection_type attribute.
    /// </summary>
    public TerraformProperty<string>? CollectionType
    {
        get => GetProperty<TerraformProperty<string>>("collection_type");
        set => WithProperty("collection_type", value);
    }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    public TerraformProperty<string>? FeatureName
    {
        get => GetProperty<TerraformProperty<string>>("feature_name");
        set => WithProperty("feature_name", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    public TerraformProperty<string>? FeatureType
    {
        get => GetProperty<TerraformProperty<string>>("feature_type");
        set => WithProperty("feature_type", value);
    }

}

/// <summary>
/// Block type for offline_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// The disable_glue_table_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableGlueTableCreation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_glue_table_creation");
        set => WithProperty("disable_glue_table_creation", value);
    }

    /// <summary>
    /// The table_format attribute.
    /// </summary>
    public TerraformProperty<string>? TableFormat
    {
        get => GetProperty<TerraformProperty<string>>("table_format");
        set => WithProperty("table_format", value);
    }

}

/// <summary>
/// Block type for online_store_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enable_online_store attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableOnlineStore
    {
        get => GetProperty<TerraformProperty<bool>>("enable_online_store");
        set => WithProperty("enable_online_store", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => WithProperty("storage_type", value);
    }

}

/// <summary>
/// Block type for throughput_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupThroughputConfigBlock : TerraformBlock
{
    /// <summary>
    /// The provisioned_read_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedReadCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_read_capacity_units");
        set => WithProperty("provisioned_read_capacity_units", value);
    }

    /// <summary>
    /// The provisioned_write_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedWriteCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_write_capacity_units");
        set => WithProperty("provisioned_write_capacity_units", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThroughputMode
    {
        get => GetProperty<TerraformProperty<string>>("throughput_mode");
        set => WithProperty("throughput_mode", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_feature_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerFeatureGroup : TerraformResource
{
    public AwsSagemakerFeatureGroup(string name) : base("aws_sagemaker_feature_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// The event_time_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeFeatureName is required")]
    public required TerraformProperty<string> EventTimeFeatureName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("event_time_feature_name");
        set => this.WithProperty("event_time_feature_name", value);
    }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupName is required")]
    public required TerraformProperty<string> FeatureGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("feature_group_name");
        set => this.WithProperty("feature_group_name", value);
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
    /// The record_identifier_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordIdentifierFeatureName is required")]
    public required TerraformProperty<string> RecordIdentifierFeatureName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("record_identifier_feature_name");
        set => this.WithProperty("record_identifier_feature_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for feature_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2500, ErrorMessage = "Maximum 2500 FeatureDefinition block(s) allowed")]
    public List<AwsSagemakerFeatureGroupFeatureDefinitionBlock>? FeatureDefinition
    {
        get => GetProperty<List<AwsSagemakerFeatureGroupFeatureDefinitionBlock>>("feature_definition");
        set => this.WithProperty("feature_definition", value);
    }

    /// <summary>
    /// Block for offline_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OfflineStoreConfig block(s) allowed")]
    public List<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>? OfflineStoreConfig
    {
        get => GetProperty<List<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>>("offline_store_config");
        set => this.WithProperty("offline_store_config", value);
    }

    /// <summary>
    /// Block for online_store_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineStoreConfig block(s) allowed")]
    public List<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>? OnlineStoreConfig
    {
        get => GetProperty<List<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>>("online_store_config");
        set => this.WithProperty("online_store_config", value);
    }

    /// <summary>
    /// Block for throughput_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThroughputConfig block(s) allowed")]
    public List<AwsSagemakerFeatureGroupThroughputConfigBlock>? ThroughputConfig
    {
        get => GetProperty<List<AwsSagemakerFeatureGroupThroughputConfigBlock>>("throughput_config");
        set => this.WithProperty("throughput_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
