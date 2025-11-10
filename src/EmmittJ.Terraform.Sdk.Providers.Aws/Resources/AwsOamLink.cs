using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for link_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsOamLinkLinkConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOamLinkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelTemplate is required")]
    public required TerraformProperty<string> LabelTemplate
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public HashSet<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

    /// <summary>
    /// The sink_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SinkIdentifier is required")]
    public required TerraformProperty<string> SinkIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("sink_identifier");
        set => this.WithProperty("sink_identifier", value);
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
    /// Block for link_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkConfiguration block(s) allowed")]
    public List<AwsOamLinkLinkConfigurationBlock>? LinkConfiguration
    {
        get => GetProperty<List<AwsOamLinkLinkConfigurationBlock>>("link_configuration");
        set => this.WithProperty("link_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOamLinkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsOamLinkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
