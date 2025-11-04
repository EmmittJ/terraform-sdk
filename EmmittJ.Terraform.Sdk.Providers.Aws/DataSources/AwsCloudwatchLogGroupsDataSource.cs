using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_log_groups.
/// </summary>
public class AwsCloudwatchLogGroupsDataSource : TerraformDataSource
{
    public AwsCloudwatchLogGroupsDataSource(string name) : base("aws_cloudwatch_log_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
        this.DeclareOutput("log_group_names");
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
    /// The log_group_name_prefix attribute.
    /// </summary>
    public string? LogGroupNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_group_name_prefix")?.Value;
        set => this.WithProperty("log_group_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    public TerraformExpression LogGroupNames => this["log_group_names"];

}
