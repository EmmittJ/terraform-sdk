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
    public TerraformProperty<string>? BaselineIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("baseline_identifier");
        set => this.WithProperty("baseline_identifier", value);
    }

    /// <summary>
    /// The baseline_version attribute.
    /// </summary>
    public TerraformProperty<string>? BaselineVersion
    {
        get => GetProperty<TerraformProperty<string>>("baseline_version");
        set => this.WithProperty("baseline_version", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The target_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? TargetIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("target_identifier");
        set => this.WithProperty("target_identifier", value);
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
