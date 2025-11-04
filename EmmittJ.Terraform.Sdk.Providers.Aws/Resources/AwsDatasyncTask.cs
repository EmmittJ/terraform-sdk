using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_task resource.
/// </summary>
public class AwsDatasyncTask : TerraformResource
{
    public AwsDatasyncTask(string name) : base("aws_datasync_task", name)
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
    public string? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_log_group_arn")?.Value;
        set => this.WithProperty("cloudwatch_log_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    public string? DestinationLocationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_location_arn")?.Value;
        set => this.WithProperty("destination_location_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    public string? SourceLocationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_location_arn")?.Value;
        set => this.WithProperty("source_location_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The task_mode attribute.
    /// </summary>
    public string? TaskMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_mode")?.Value;
        set => this.WithProperty("task_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
