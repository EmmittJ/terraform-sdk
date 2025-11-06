using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_tracker_associations.
/// </summary>
public class AwsLocationTrackerAssociationsDataSource : TerraformDataSource
{
    public AwsLocationTrackerAssociationsDataSource(string name) : base("aws_location_tracker_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("consumer_arns");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    public string? TrackerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracker_name")?.Value;
        set => this.WithProperty("tracker_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The consumer_arns attribute.
    /// </summary>
    public TerraformExpression ConsumerArns => this["consumer_arns"];

}
