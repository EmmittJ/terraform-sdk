using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_evidently_feature resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsEvidentlyFeature : TerraformResource
{
    public AwsEvidentlyFeature(string name) : base("aws_evidently_feature", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("evaluation_rules");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("status");
        this.DeclareOutput("value_type");
    }

    /// <summary>
    /// The default_variation attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultVariation
    {
        get => GetProperty<TerraformProperty<string>>("default_variation");
        set => this.WithProperty("default_variation", value);
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
    /// The entity_overrides attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? EntityOverrides
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("entity_overrides");
        set => this.WithProperty("entity_overrides", value);
    }

    /// <summary>
    /// The evaluation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? EvaluationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("evaluation_strategy");
        set => this.WithProperty("evaluation_strategy", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The evaluation_rules attribute.
    /// </summary>
    public TerraformExpression EvaluationRules => this["evaluation_rules"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The value_type attribute.
    /// </summary>
    public TerraformExpression ValueType => this["value_type"];

}
