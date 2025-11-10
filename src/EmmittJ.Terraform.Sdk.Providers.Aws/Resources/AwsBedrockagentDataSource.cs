using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Block type for vector_ingestion_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_bedrockagent_data_source resource.
/// </summary>
public class AwsBedrockagentDataSource : TerraformResource
{
    public AwsBedrockagentDataSource(string name) : base("aws_bedrockagent_data_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("data_source_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The data_deletion_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DataDeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("data_deletion_policy");
        set => this.WithProperty("data_deletion_policy", value);
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
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    public required TerraformProperty<string> KnowledgeBaseId
    {
        get => GetProperty<TerraformProperty<string>>("knowledge_base_id");
        set => this.WithProperty("knowledge_base_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for data_source_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentDataSourceDataSourceConfigurationBlock>? DataSourceConfiguration
    {
        get => GetProperty<List<AwsBedrockagentDataSourceDataSourceConfigurationBlock>>("data_source_configuration");
        set => this.WithProperty("data_source_configuration", value);
    }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetProperty<List<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => this.WithProperty("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vector_ingestion_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>? VectorIngestionConfiguration
    {
        get => GetProperty<List<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>>("vector_ingestion_configuration");
        set => this.WithProperty("vector_ingestion_configuration", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformExpression DataSourceId => this["data_source_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
