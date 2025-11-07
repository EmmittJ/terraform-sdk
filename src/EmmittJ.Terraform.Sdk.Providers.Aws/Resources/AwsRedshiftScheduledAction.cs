using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_scheduled_action resource.
/// </summary>
public class AwsRedshiftScheduledAction : TerraformResource
{
    public AwsRedshiftScheduledAction(string name) : base("aws_redshift_scheduled_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable");
        set => this.WithProperty("enable", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role");
        set => this.WithProperty("iam_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

}
