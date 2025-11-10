using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_oam_link.
/// </summary>
public class AwsOamLinkDataSource : TerraformDataSource
{
    public AwsOamLinkDataSource(string name) : base("aws_oam_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("label");
        SetOutput("label_template");
        SetOutput("link_configuration");
        SetOutput("link_id");
        SetOutput("resource_types");
        SetOutput("sink_arn");
        SetOutput("id");
        SetOutput("link_identifier");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    public required TerraformProperty<string> LinkIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("link_identifier");
        set => SetProperty("link_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
    /// The label_template attribute.
    /// </summary>
    public TerraformExpression LabelTemplate => this["label_template"];

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    public TerraformExpression LinkConfiguration => this["link_configuration"];

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformExpression LinkId => this["link_id"];

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformExpression ResourceTypes => this["resource_types"];

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformExpression SinkArn => this["sink_arn"];

}
