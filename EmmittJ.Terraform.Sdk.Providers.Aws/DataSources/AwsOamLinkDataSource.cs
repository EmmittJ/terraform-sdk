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
        this.DeclareOutput("arn");
        this.DeclareOutput("label");
        this.DeclareOutput("label_template");
        this.DeclareOutput("link_configuration");
        this.DeclareOutput("link_id");
        this.DeclareOutput("resource_types");
        this.DeclareOutput("sink_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    public string? LinkIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("link_identifier")?.Value;
        set => this.WithProperty("link_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
