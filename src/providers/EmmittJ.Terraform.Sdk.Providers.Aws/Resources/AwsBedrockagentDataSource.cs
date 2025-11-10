using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Block type for vector_ingestion_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_bedrockagent_data_source resource.
/// </summary>
public class AwsBedrockagentDataSource : TerraformResource
{
    public AwsBedrockagentDataSource(string name) : base("aws_bedrockagent_data_source", name)
    {
    }

    /// <summary>
    /// The data_deletion_policy attribute.
    /// </summary>
    [TerraformPropertyName("data_deletion_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DataDeletionPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_deletion_policy");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    [TerraformPropertyName("knowledge_base_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KnowledgeBaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for data_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_source_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceDataSourceConfigurationBlock>>? DataSourceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("server_side_encryption_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vector_ingestion_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vector_ingestion_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>>? VectorIngestionConfiguration { get; set; } = new();

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformPropertyName("data_source_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_source_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
