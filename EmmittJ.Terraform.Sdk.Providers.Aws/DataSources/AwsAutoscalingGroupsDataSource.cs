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
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

}
