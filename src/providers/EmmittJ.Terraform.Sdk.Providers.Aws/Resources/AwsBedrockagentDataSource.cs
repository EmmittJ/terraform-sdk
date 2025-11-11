using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentDataSourceDataSourceConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Block type for vector_ingestion_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentDataSourceVectorIngestionConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_bedrockagent_data_source resource.
/// </summary>
public partial class AwsBedrockagentDataSource : TerraformResource
{
    public AwsBedrockagentDataSource(string name) : base("aws_bedrockagent_data_source", name)
    {
    }

    /// <summary>
    /// The data_deletion_policy attribute.
    /// </summary>
    [TerraformProperty("data_deletion_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DataDeletionPolicy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    [TerraformProperty("knowledge_base_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KnowledgeBaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for data_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_source_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceDataSourceConfigurationBlock>>? DataSourceConfiguration { get; set; }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("server_side_encryption_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsBedrockagentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vector_ingestion_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vector_ingestion_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>>? VectorIngestionConfiguration { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformProperty("data_source_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataSourceId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
