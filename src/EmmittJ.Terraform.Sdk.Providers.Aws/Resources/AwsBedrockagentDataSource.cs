using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? KnowledgeBaseId
    {
        get => GetProperty<TerraformProperty<string>>("knowledge_base_id");
        set => this.WithProperty("knowledge_base_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    /// The data_source_id attribute.
    /// </summary>
    public TerraformExpression DataSourceId => this["data_source_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
