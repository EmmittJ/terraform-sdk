using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_tag_option resource.
/// </summary>
public class AwsServicecatalogTagOption : TerraformResource
{
    public AwsServicecatalogTagOption(string name) : base("aws_servicecatalog_tag_option", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("owner");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public bool? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active")?.Value;
        set => this.WithProperty("active", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The key attribute.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

}
