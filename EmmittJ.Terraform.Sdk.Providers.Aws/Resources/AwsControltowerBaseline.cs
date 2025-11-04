using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_controltower_baseline resource.
/// </summary>
public class AwsControltowerBaseline : TerraformResource
{
    public AwsControltowerBaseline(string name) : base("aws_controltower_baseline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("operation_identifier");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The baseline_identifier attribute.
    /// </summary>
    public string? BaselineIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("baseline_identifier")?.Value;
        set => this.WithProperty("baseline_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The baseline_version attribute.
    /// </summary>
    public string? BaselineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("baseline_version")?.Value;
        set => this.WithProperty("baseline_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_identifier attribute.
    /// </summary>
    public string? TargetIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_identifier")?.Value;
        set => this.WithProperty("target_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The operation_identifier attribute.
    /// </summary>
    public TerraformExpression OperationIdentifier => this["operation_identifier"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
