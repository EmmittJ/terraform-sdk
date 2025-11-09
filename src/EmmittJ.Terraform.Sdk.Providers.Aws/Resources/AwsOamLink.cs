using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_oam_link resource.
/// </summary>
public class AwsOamLink : TerraformResource
{
    public AwsOamLink(string name) : base("aws_oam_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("label");
        this.DeclareOutput("link_id");
        this.DeclareOutput("sink_arn");
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
    /// The label_template attribute.
    /// </summary>
    public TerraformProperty<string>? LabelTemplate
    {
        get => GetProperty<TerraformProperty<string>>("label_template");
        set => this.WithProperty("label_template", value);
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
    /// The resource_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ResourceTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

    /// <summary>
    /// The sink_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SinkIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("sink_identifier");
        set => this.WithProperty("sink_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformExpression Label => this["label"];

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformExpression LinkId => this["link_id"];

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformExpression SinkArn => this["sink_arn"];

}
