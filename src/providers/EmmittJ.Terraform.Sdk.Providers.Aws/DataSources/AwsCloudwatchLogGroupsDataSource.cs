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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_group_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? LogGroupNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name_prefix");
        set => this.WithProperty("log_group_name_prefix", value);
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
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    public TerraformExpression LogGroupNames => this["log_group_names"];

}
