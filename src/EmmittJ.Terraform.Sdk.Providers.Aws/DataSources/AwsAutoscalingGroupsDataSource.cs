using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_autoscaling_groups.
/// </summary>
public class AwsAutoscalingGroupsDataSource : TerraformDataSource
{
    public AwsAutoscalingGroupsDataSource(string name) : base("aws_autoscaling_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
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
    /// The names attribute.
    /// </summary>
    public List<string>? Names
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("names")?.Value;
        set => this.WithProperty("names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

}
