using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_query_log resource.
/// </summary>
public class AwsRoute53QueryLog : TerraformResource
{
    public AwsRoute53QueryLog(string name) : base("aws_route53_query_log", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => this.WithProperty("cloudwatch_log_group_arn", value);
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
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
